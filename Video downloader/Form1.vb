Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1
	' Dim settings
	Dim format As String = "null"
	Dim quality As String = "null"
	Dim command = "null"
	Dim video_formats() As String = {"mp4", "webm", "mkv"}
	' Dim Notify_Intent As Boolean = False
	Dim Quality_Settings As New Dictionary(Of String, Object)
	Dim Format_Dict As New Dictionary(Of String, Object)
	Dim client As WebClient = New WebClient()

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		BackgroundWorker_Banner.RunWorkerAsync()
		TextBox_Destination.Text = My.Settings.Destination_Directory
		Format_Dict("Source") = "best"
		Format_Dict("MP4") = "mp4"
		Format_Dict("WebM") = "webm"
		Format_Dict("MKV") = "mkv"
		Format_Dict("Source (audio)") = "bestaudio"
		Format_Dict("AAC (audio)") = "aac"
		Format_Dict("MP3 (audio)") = "mp3"
		Format_Dict("OGG (audio)") = "vorbis"
		Format_Dict("OPUS (audio)") = "opus"
		Quality_Settings("Source") = "best"
		Quality_Settings("1080p") = "1080"
		Quality_Settings("720p") = "720"
		Quality_Settings("480p") = "480"
		Quality_Settings("360p") = "360"
		Quality_Settings("144p") = "144"
		ComboBox_FileType.SelectedIndex = My.Settings.Filetype_index
		If ComboBox_FileType.SelectedIndex >= 4 Then
			ComboBox_Quality.Enabled = False
			CheckBox_CompatibilityMode.Enabled = False
		Else
			ComboBox_Quality.Enabled = True
			CheckBox_CompatibilityMode.Enabled = True
		End If
		ComboBox_Quality.SelectedIndex = My.Settings.Quality_index
		CheckBox_AddIDToFilename.Checked = My.Settings.Add_video_id_in_filename
		CheckBox_CompatibilityMode.Checked = My.Settings.Compatibility_mode
		CheckBox_Metadata.Checked = My.Settings.Embed_video_metadata
		CheckBox_SplitChapters.Checked = My.Settings.Split_chapters
	End Sub


	Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles Button_Download.Click
		TextBox_Output.Text = "[FuzeVD] Downloading..." + Environment.NewLine + TextBox_Output.Text
		' Check if required libraries are installed
		If My.Computer.FileSystem.FileExists(Windows.Forms.Application.StartupPath & "\yt-dlp.exe") AndAlso My.Computer.FileSystem.FileExists(Windows.Forms.Application.StartupPath & "\ffmpeg.exe") Then
			command = ""
			If Format_Dict.Item(ComboBox_FileType.Text) IsNot "best" Then
				' If the selected format isn't audio only
				If video_formats.Contains(Format_Dict.Item(ComboBox_FileType.Text)) Then
					If Quality_Settings.Item(ComboBox_Quality.Text) Is "best" Then
						command += "--merge-output-format " + Format_Dict.Item(ComboBox_FileType.Text)
					Else
						command += "--format ""bv*[height<=" + Quality_Settings.Item(ComboBox_Quality.Text) + "]+ba/b[height<=" + Quality_Settings.Item(ComboBox_Quality.Text) + "]""" _
								& " --merge-output-format " + Format_Dict.Item(ComboBox_FileType.Text)
					End If
				Else
					command += "-x "
					If Format_Dict.Item(ComboBox_FileType.Text) IsNot "bestaudio" Then
						command += "--audio-format " + Format_Dict.Item(ComboBox_FileType.Text)
					End If
				End If
			ElseIf ComboBox_Quality.SelectedIndex >= 1 Then
				command += "-S ""height:" + Quality_Settings.Item(ComboBox_Quality.Text) + """"
			End If

			If CheckBox_Metadata.Checked Then
				command += " --add-metadata"
			End If
			If CheckBox_SplitChapters.Checked Then
				command += " --split-chapters"
			End If
			If CheckBox_CompatibilityMode.Checked Then
				command += " --compat-opt prefer-vp9-sort"
			End If
			' In yt-dlp 2025.07.21 the default behaviour changed so that it will no longer save the video last modified date. --mtime brings it back
			command += " --mtime"
			' If CheckBox_Notify.Checked Then
			' Notify_Intent = True
			' End If
			command += " " + Box_Url.Text + " -P """ + TextBox_Destination.Text + """" ' -o ""%(title)s.%(ext)s"""
			If Not CheckBox_AddIDToFilename.Checked Then
				command += " -o ""%(title)s.%(ext)s"""
			End If
			BackgroundWorker_VideoDownload.RunWorkerAsync()
		Else
			MsgBox("One or more required libraries are missing." + Environment.NewLine + "Open FuzeVD Updater and use the ""Re-Install"" option", vbOKOnly + vbExclamation, "Error 404")
		End If
	End Sub

	Private Sub BackgroundWorker_VideoDownload_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_VideoDownload.DoWork
		Run_Ytdl()
	End Sub

	Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
		Dim ProcessInfo As New ProcessStartInfo
		ProcessInfo.FileName = "fuzevd-updater"
		ProcessInfo.WindowStyle = ProcessWindowStyle.Normal
		Dim myProcess As Process = Process.Start(ProcessInfo)
		' MsgBox("This feature is only available in the 64-bit version...", vbOKOnly + vbCritical)
	End Sub

	Private Sub Run_Ytdl()
		Dim process As New Process
		AddHandler process.OutputDataReceived, AddressOf OutputHandler
		AddHandler process.ErrorDataReceived, AddressOf OutputHandler
		Dim processInfo As New ProcessStartInfo
		processInfo.FileName = "yt-dlp.exe"
		' processInfo.Arguments = ("yt-dlp https://www.youtube.com/watch?v=kGW8SDFikeg")
		processInfo.Arguments = (command)
		processInfo.UseShellExecute = False
		processInfo.WindowStyle = ProcessWindowStyle.Hidden
		processInfo.CreateNoWindow = True
		processInfo.RedirectStandardOutput = True
		processInfo.RedirectStandardError = True
		process.StartInfo = processInfo
		process.Start()
		process.BeginOutputReadLine()
		process.BeginErrorReadLine()
	End Sub

	Private Sub OutputHandler(sender As Object, args As DataReceivedEventArgs)
		If Not String.IsNullOrEmpty(args.Data) Then
			If args.Data.Contains("[download]") Then
				Update_Progress_Bar(args.Data.Substring(11, 3).Trim())
			End If
			TextBox_Output.Text = args.Data + Environment.NewLine + TextBox_Output.Text
		End If
	End Sub

	Private Sub Update_Progress_Bar(percent_complete As String)
		If Regex.IsMatch(percent_complete, "^[0-9 ]+$") Then
			If CInt(percent_complete) <= 100 Then
				ProgressBar_Download.Value = CInt(percent_complete)
			End If
			'If ProgressBar_Download.Value = 100 And Notify_Intent = True Then
			'    Show_Notification()
			'    Notify_Intent = False
			'End If
		End If
	End Sub

	'Private Sub Show_Notification()
	'    Dim Notification_Window = MsgBox("Video has finished downloading :)")
	'End Sub

	' Private Shared Sub ErrorDataReceivedAsync(sender As Object, args As DataReceivedEventArgs)
	' If Not args.Data Is Nothing AndAlso Not String.IsNullOrEmpty(args.Data) Then
	'         Form1.TextBox_Output.Text += args.Data
	' End If
	' End Sub

	Private Sub Button_Directory_Click(sender As Object, e As EventArgs) Handles Button_Directory.Click
		Dim dialog = New FolderBrowserDialog()
		dialog.SelectedPath = Windows.Forms.Application.StartupPath
		If DialogResult.OK = dialog.ShowDialog() Then
			TextBox_Destination.Text = dialog.SelectedPath
			My.Settings.Destination_Directory = dialog.SelectedPath
		End If
	End Sub

	Private Sub LinkLabel_FuzePage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_FuzePage.LinkClicked
		Process.Start("https://fuze.page/software/fuzevd")
	End Sub

	Private Sub ComboBox_FileType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_FileType.SelectedIndexChanged
		My.Settings.Filetype_index = ComboBox_FileType.SelectedIndex
		If ComboBox_FileType.SelectedIndex >= 4 Then
			ComboBox_Quality.Enabled = False
		Else
			ComboBox_Quality.Enabled = True
		End If
	End Sub

	Private Sub ComboBox_Quality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Quality.SelectedIndexChanged
		My.Settings.Quality_index = ComboBox_Quality.SelectedIndex
	End Sub

	Private Sub CheckBox_AddIDToFilename_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_AddIDToFilename.CheckedChanged
		My.Settings.Add_video_id_in_filename = CheckBox_AddIDToFilename.Checked
	End Sub

	Private Sub CheckBox_CompatibilityMode_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_CompatibilityMode.CheckedChanged
		My.Settings.Compatibility_mode = CheckBox_CompatibilityMode.Checked
	End Sub

	Private Sub CheckBox_Metadata_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Metadata.CheckedChanged
		My.Settings.Embed_video_metadata = CheckBox_Metadata.Checked
	End Sub

	Private Sub CheckBox_SplitChapters_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_SplitChapters.CheckedChanged
		My.Settings.Split_chapters = CheckBox_SplitChapters.Checked
	End Sub

	Private Sub BackgroundWorker_Banner_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_Banner.DoWork
		LinkLabel_FuzePage.Text = client.DownloadString("https://fuze.page/static/fuzevd/banner.txt").Trim()
	End Sub

End Class
