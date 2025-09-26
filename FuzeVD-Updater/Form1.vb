' FuzeVD Updater
Imports System.IO
Imports System.Net
Public Class Form1
    Dim has_checked_labels As Boolean = False
    Dim ytdlp_version_client As String = "undefined"
    Dim ffmpeg_version_client As String = "undefined"
    Dim fuzevd_version_client As String = "undefined"
    Dim ytdlp_version_server As String = "undefined"
    Dim ffmpeg_version_server As String = "undefined"
    Dim fuzevd_version_server As String = "undefined"
    Dim do_ytdlp_update As Boolean = False
    Dim do_ffmpeg_update As Boolean = False
    Dim do_fuzevd_update As Boolean = False
    Dim do_repair As Boolean = False
    Dim nothing_to_update As Boolean = True
    Dim update_in_progress = False
    Dim client As WebClient = New WebClient()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub LinkLabel_Weblink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://fuze.page/software/fuzevd/")
    End Sub

    Private Sub Kill_Process(sname As String)
        Dim pProcess() As Process = Process.GetProcessesByName(sname)

        For Each p As Process In pProcess
            p.Kill()
        Next
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub CheckBox_Reinstall_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Reinstall.CheckedChanged
        If Not update_in_progress Then
            If CheckBox_Reinstall.Checked Then
                Button_Update.Enabled = True
                Button_Update.Text = "Re-Install"
            Else
                If nothing_to_update = True Then
                    Button_Update.Enabled = False
                    Button_Update.Text = "Up to date"
                Else
                    Button_Update.Text = "Update"
                End If
            End If
        End If
        If CheckBox_Reinstall.Checked Then
            Button_External.Enabled = False
        Else
            Button_External.Enabled = True
        End If
    End Sub

    ' Delegate Sub AddLogText(ByVal Text As String)

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ' Read local file
        For Each Line As String In File.ReadLines(Application.StartupPath & "\fuzevd-versions-client.fauv")
            ' TextBox_Versions.Text += Line + Environment.NewLine
            ' MsgBox(Line.Substring(0, Line.IndexOf("=")).Trim())
            If Line.Substring(0, Line.IndexOf("=")).Trim() = "yt-dlp" Then
                ytdlp_version_client = Line.Substring(Line.IndexOf("=") + 1, (Line.Length - 1) - Line.IndexOf("="))
                ' Label_ytdlp.Text = ytdlp_version_client
                Label_ytdlp.Invoke(Sub() Label_ytdlp.Text = ytdlp_version_client)
            ElseIf Line.Substring(0, Line.IndexOf("=")).Trim() = "ffmpeg" Then
                ffmpeg_version_client = Line.Substring(Line.IndexOf("=") + 1, (Line.Length - 1) - Line.IndexOf("="))
                ' Label_ffmpeg.Text = ffmpeg_version_client
                Label_ffmpeg.Invoke(Sub() Label_ffmpeg.Text = ffmpeg_version_client)
            ElseIf Line.Substring(0, Line.IndexOf("=")).Trim() = "fuzevd" Then
                fuzevd_version_client = Line.Substring(Line.IndexOf("=") + 1, (Line.Length - 1) - Line.IndexOf("="))
                ' Label_fuzevd.Text = fuzevd_version_client
                Label_fuzevd.Invoke(Sub() Label_fuzevd.Text = fuzevd_version_client)
            End If
        Next

        ' Read server file
        client.DownloadFile("https://fuze.page/static/fuzevd/fuzevd-versions-server.fauv", "fuzevd-versions-server.fauv")
        For Each Line As String In File.ReadLines(Application.StartupPath & "\fuzevd-versions-server.fauv")
            ' TextBox_Versions.Text += Line + Environment.NewLine
            ' MsgBox(Line.Substring(0, Line.IndexOf("=")).Trim())
            If Line.Substring(0, Line.IndexOf("=")).Trim() = "yt-dlp" Then
                ytdlp_version_server = Line.Substring(Line.IndexOf("=") + 1, (Line.Length - 1) - Line.IndexOf("="))
                ' Label_ytdlp_server.Text = ytdlp_version_server
                Label_ytdlp_server.Invoke(Sub() Label_ytdlp_server.Text = ytdlp_version_server)
            ElseIf Line.Substring(0, Line.IndexOf("=")).Trim() = "ffmpeg" Then
                ffmpeg_version_server = Line.Substring(Line.IndexOf("=") + 1, (Line.Length - 1) - Line.IndexOf("="))
                ' Label_ffmpeg_server.Text = ffmpeg_version_server
                Label_ffmpeg_server.Invoke(Sub() Label_ffmpeg_server.Text = ffmpeg_version_server)
            ElseIf Line.Substring(0, Line.IndexOf("=")).Trim() = "fuzevd" Then
                fuzevd_version_server = Line.Substring(Line.IndexOf("=") + 1, (Line.Length - 1) - Line.IndexOf("="))
                ' Label_fuzevd_server.Text = fuzevd_version_server
                Label_fuzevd_server.Invoke(Sub() Label_fuzevd_server.Text = fuzevd_version_server)
            End If
        Next

        ' Check if each library version matches
        If ytdlp_version_client <> ytdlp_version_server Then
            do_ytdlp_update = True
            nothing_to_update = False
        End If
        If ffmpeg_version_client <> ffmpeg_version_server Then
            do_ffmpeg_update = True
            nothing_to_update = False
        End If
        If fuzevd_version_client <> fuzevd_version_server Then
            do_fuzevd_update = True
            nothing_to_update = False
        End If

        If nothing_to_update = False Then
            ' Button_Update.Enabled = True
            Button_Update.Invoke(Sub() Button_Update.Enabled = True)
        Else
            ' Button_Update.Text = "Up to date"
            Button_Update.Invoke(Sub() Button_Update.Text = "Up to date")
            File.Delete("fuzevd-versions-server.fauv")
        End If
        has_checked_labels = True
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        If CheckBox_Reinstall.Checked = True Then
            nothing_to_update = False
            do_ytdlp_update = True
            do_ffmpeg_update = True
            do_fuzevd_update = True
        End If
        If nothing_to_update = False Then
            If MsgBox("Updating will close FuzeVD. Are you sure you want to continue?", vbOKCancel + vbExclamation + vbApplicationModal, "Why Ben Shapiro left BuzzFeed (Ft. Jake Paul & PICKLE RIIIIIIICK)") = vbOK Then
                update_in_progress = True
                ' Button_Update.Text = "Updating..."
                Button_Update.Invoke(Sub() Button_Update.Text = "Updating...")
                ' Button_Update.Enabled = False
                Button_Update.Invoke(Sub() Button_Update.Enabled = False)
                If do_ytdlp_update = True Then
                    'If My.Computer.FileSystem.FileExists(Application.StartupPath & "\yt-dlp.exe") Or Not CheckBox_Reinstall.Checked Then
                    '    Kill_Process("yt-dlp")
                    '    Dim ProcessInfo As New ProcessStartInfo
                    '    ProcessInfo.FileName = "yt-dlp"
                    '    ProcessInfo.Arguments = "-U"
                    '    ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden
                    '    ProcessInfo.CreateNoWindow = True
                    '    Dim myProcess As Process = Process.Start(ProcessInfo)
                    '    ' Label_ytdlp.Text = "ytdlp Update complete"
                    '    Label_ytdlp.Invoke(Sub() Label_ytdlp.Text = "ytdlp Update complete")
                    'Else
                    File.Delete("yt-dlp.exe")
                    client.DownloadFile("https://fuze.page/static/fuzevd/yt-dlp.exe", "yt-dlp.exe")
                    Label_ytdlp.Text = "ytdlp Update complete"
                    Label_ytdlp.Invoke(Sub() Label_ytdlp.Text = "ytdlp Update complete")
                    'End If
                End If
				If do_ffmpeg_update = True Or do_repair = True Then
					Kill_Process("ffmpeg")
					Threading.Thread.Sleep(500)
					File.Delete("ffmpeg.exe")
					' MsgBox("ffmpeg File Deleted")
					client.DownloadFile("https://fuze.page/static/fuzevd/ffmpeg.exe", "ffmpeg.exe")
					' Label_ffmpeg.Text = "ffmpeg Update complete"
					Label_ffmpeg.Invoke(Sub() Label_ffmpeg.Text = "ffmpeg Update complete")
				End If
				If do_fuzevd_update = True Or do_repair = True Then
                    Kill_Process("FuzeVD")
                    Threading.Thread.Sleep(500)
                    File.Delete("FuzeVD.exe")
					' MsgBox("fuzevd Deleted")
					client.DownloadFile("https://fuze.page/static/fuzevd/FuzeVD.exe", "FuzeVD.exe")
					' Label_fuzevd.Text = "fuzevd Update complete"
					Label_fuzevd.Invoke(Sub() Label_fuzevd.Text = "fuzevd Update complete")
                End If

                ' Update local versions list to match the server's
                File.Delete("fuzevd-versions-client.fauv")
                File.Move(Application.StartupPath & "\fuzevd-versions-server.fauv", Application.StartupPath & "\fuzevd-versions-client.fauv")
                update_in_progress = False
                ' Button_Update.Text = "Update complete"
                Button_Update.Invoke(Sub() Button_Update.Text = "Update complete")
                MsgBox("FuzeVD has finished updating", vbOKOnly + vbInformation)
            End If
        Else
            MsgBox("Libraries are already up to date", vbOKOnly + vbInformation)
        End If
    End Sub

    Private Sub Button_External_Click(sender As Object, e As EventArgs) Handles Button_External.Click
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\yt-dlp.exe") Then
            update_in_progress = True
            ' Button_Update.Text = "Updating..."
            Button_Update.Invoke(Sub() Button_Update.Text = "Updating...")
            ' Button_Update.Enabled = False
            Button_Update.Invoke(Sub() Button_Update.Enabled = False)
            Kill_Process("yt-dlp")
            Dim ProcessInfo As New ProcessStartInfo
            ProcessInfo.FileName = "yt-dlp"
            ProcessInfo.Arguments = "-U"
            ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden
            ProcessInfo.CreateNoWindow = True
            Dim myProcess As Process = Process.Start(ProcessInfo)
            myProcess.WaitForExit()
            ' Label_ytdlp.Text = "ytdlp Update complete"
            Label_ytdlp.Invoke(Sub() Label_ytdlp.Text = "ytdlp Update complete")
            update_in_progress = False
            ' Button_Update.Text = "Updating..."
            Button_Update.Invoke(Sub() Button_Update.Text = "Update complete")
            ' Button_Update.Enabled = False
            ' Button_Update.Invoke(Sub() Button_Update.Enabled = True)
            MsgBox("yt-dlp is now on the latest version if it wasn't already. Be aware that the old version number will still be shown on the updater.", vbOKOnly + vbInformation)
        Else
            MsgBox("Error: yt-dlp executable not found: please use the re-install option", vbOKOnly + vbCritical)
        End If
    End Sub
End Class
