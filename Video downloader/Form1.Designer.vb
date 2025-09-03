<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Button_Download = New System.Windows.Forms.Button()
		Me.Box_Url = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button_Update = New System.Windows.Forms.Button()
		Me.GroupBox_Formats = New System.Windows.Forms.GroupBox()
		Me.Label_Quality = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ComboBox_Quality = New System.Windows.Forms.ComboBox()
		Me.ComboBox_FileType = New System.Windows.Forms.ComboBox()
		Me.TextBox_Output = New System.Windows.Forms.TextBox()
		Me.GroupBox_Basics = New System.Windows.Forms.GroupBox()
		Me.Button_Directory = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox_Destination = New System.Windows.Forms.TextBox()
		Me.CheckBox_Metadata = New System.Windows.Forms.CheckBox()
		Me.GroupBox_Settings = New System.Windows.Forms.GroupBox()
		Me.CheckBox_CompatibilityMode = New System.Windows.Forms.CheckBox()
		Me.CheckBox_AddIDToFilename = New System.Windows.Forms.CheckBox()
		Me.CheckBox_SplitChapters = New System.Windows.Forms.CheckBox()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.ProgressBar_Download = New System.Windows.Forms.ProgressBar()
		Me.GroupBox_Output = New System.Windows.Forms.GroupBox()
		Me.LinkLabel_FuzePage = New System.Windows.Forms.LinkLabel()
		Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
		Me.GroupBox_Formats.SuspendLayout()
		Me.GroupBox_Basics.SuspendLayout()
		Me.GroupBox_Settings.SuspendLayout()
		Me.GroupBox_Output.SuspendLayout()
		Me.SuspendLayout()
		'
		'Button_Download
		'
		Me.Button_Download.Location = New System.Drawing.Point(283, 45)
		Me.Button_Download.Name = "Button_Download"
		Me.Button_Download.Size = New System.Drawing.Size(77, 23)
		Me.Button_Download.TabIndex = 2
		Me.Button_Download.Text = "Download"
		Me.Button_Download.UseVisualStyleBackColor = True
		'
		'Box_Url
		'
		Me.HelpProvider1.SetHelpString(Me.Box_Url, "Insert a link to a YouTube video or playlist. Other sites are supported, shown he" &
		"re: https://github.com/yt-dlp/yt-dlp/blob/master/supportedsites.md")
		Me.Box_Url.Location = New System.Drawing.Point(73, 19)
		Me.Box_Url.Name = "Box_Url"
		Me.HelpProvider1.SetShowHelp(Me.Box_Url, True)
		Me.Box_Url.Size = New System.Drawing.Size(287, 20)
		Me.Box_Url.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(42, 22)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(29, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "URL"
		'
		'Button_Update
		'
		Me.HelpProvider1.SetHelpString(Me.Button_Update, "Opens fuzevd-updater and checks fuze.page for new packages. Requires administrato" &
		"r privileges.")
		Me.Button_Update.Location = New System.Drawing.Point(271, 412)
		Me.Button_Update.Name = "Button_Update"
		Me.HelpProvider1.SetShowHelp(Me.Button_Update, True)
		Me.Button_Update.Size = New System.Drawing.Size(109, 23)
		Me.Button_Update.TabIndex = 11
		Me.Button_Update.Text = "Check For Updates"
		Me.Button_Update.UseVisualStyleBackColor = True
		'
		'GroupBox_Formats
		'
		Me.GroupBox_Formats.Controls.Add(Me.Label_Quality)
		Me.GroupBox_Formats.Controls.Add(Me.Label3)
		Me.GroupBox_Formats.Controls.Add(Me.ComboBox_Quality)
		Me.GroupBox_Formats.Controls.Add(Me.ComboBox_FileType)
		Me.GroupBox_Formats.Location = New System.Drawing.Point(12, 122)
		Me.GroupBox_Formats.Name = "GroupBox_Formats"
		Me.GroupBox_Formats.Size = New System.Drawing.Size(180, 131)
		Me.GroupBox_Formats.TabIndex = 5
		Me.GroupBox_Formats.TabStop = False
		Me.GroupBox_Formats.Text = "Formats"
		'
		'Label_Quality
		'
		Me.Label_Quality.AutoSize = True
		Me.Label_Quality.Location = New System.Drawing.Point(27, 76)
		Me.Label_Quality.Name = "Label_Quality"
		Me.Label_Quality.Size = New System.Drawing.Size(39, 13)
		Me.Label_Quality.TabIndex = 3
		Me.Label_Quality.Text = "Quality"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(25, 23)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(43, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Filetype"
		'
		'ComboBox_Quality
		'
		Me.ComboBox_Quality.FormattingEnabled = True
		Me.HelpProvider1.SetHelpString(Me.ComboBox_Quality, "Saves the video at the specified quality, or if the quality isn't available, down" &
		"loads at the highest available resolution. Ignored when Filetype is Source.")
		Me.ComboBox_Quality.Items.AddRange(New Object() {"Source", "1080p", "720p", "480p", "360p", "Among Us drip"})
		Me.ComboBox_Quality.Location = New System.Drawing.Point(73, 74)
		Me.ComboBox_Quality.Name = "ComboBox_Quality"
		Me.HelpProvider1.SetShowHelp(Me.ComboBox_Quality, True)
		Me.ComboBox_Quality.Size = New System.Drawing.Size(99, 21)
		Me.ComboBox_Quality.TabIndex = 6
		'
		'ComboBox_FileType
		'
		Me.ComboBox_FileType.FormattingEnabled = True
		Me.HelpProvider1.SetHelpString(Me.ComboBox_FileType, """Source"" selects the format stored in YouTube servers, thus avoiding a quality lo" &
		"ss caused by reformatting.")
		Me.ComboBox_FileType.Items.AddRange(New Object() {"Source", "MP4", "WebM", "MKV", "Source (audio)", "AAC (audio)", "MP3 (audio)", "OGG (audio)", "OPUS (audio)"})
		Me.ComboBox_FileType.Location = New System.Drawing.Point(73, 20)
		Me.ComboBox_FileType.Name = "ComboBox_FileType"
		Me.HelpProvider1.SetShowHelp(Me.ComboBox_FileType, True)
		Me.ComboBox_FileType.Size = New System.Drawing.Size(99, 21)
		Me.ComboBox_FileType.TabIndex = 5
		'
		'TextBox_Output
		'
		Me.TextBox_Output.BackColor = System.Drawing.Color.DimGray
		Me.TextBox_Output.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold)
		Me.TextBox_Output.ForeColor = System.Drawing.Color.White
		Me.HelpProvider1.SetHelpString(Me.TextBox_Output, "Output from yt-dlp.")
		Me.TextBox_Output.Location = New System.Drawing.Point(6, 48)
		Me.TextBox_Output.Multiline = True
		Me.TextBox_Output.Name = "TextBox_Output"
		Me.TextBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.HelpProvider1.SetShowHelp(Me.TextBox_Output, True)
		Me.TextBox_Output.Size = New System.Drawing.Size(356, 93)
		Me.TextBox_Output.TabIndex = 6
		Me.TextBox_Output.TabStop = False
		'
		'GroupBox_Basics
		'
		Me.GroupBox_Basics.Controls.Add(Me.Button_Directory)
		Me.GroupBox_Basics.Controls.Add(Me.Label2)
		Me.GroupBox_Basics.Controls.Add(Me.TextBox_Destination)
		Me.GroupBox_Basics.Controls.Add(Me.Label1)
		Me.GroupBox_Basics.Controls.Add(Me.Box_Url)
		Me.GroupBox_Basics.Controls.Add(Me.Button_Download)
		Me.GroupBox_Basics.Location = New System.Drawing.Point(12, 11)
		Me.GroupBox_Basics.Name = "GroupBox_Basics"
		Me.GroupBox_Basics.Size = New System.Drawing.Size(368, 105)
		Me.GroupBox_Basics.TabIndex = 7
		Me.GroupBox_Basics.TabStop = False
		Me.GroupBox_Basics.Text = "Basics"
		'
		'Button_Directory
		'
		Me.Button_Directory.Image = CType(resources.GetObject("Button_Directory.Image"), System.Drawing.Image)
		Me.Button_Directory.Location = New System.Drawing.Point(336, 71)
		Me.Button_Directory.Name = "Button_Directory"
		Me.Button_Directory.Size = New System.Drawing.Size(24, 24)
		Me.Button_Directory.TabIndex = 4
		Me.Button_Directory.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(9, 77)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(60, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Destination"
		'
		'TextBox_Destination
		'
		Me.HelpProvider1.SetHelpString(Me.TextBox_Destination, "Saves the video at the specified URL. %userprofile% is your home directory (eg. C" &
		":\Users\Donald).")
		Me.TextBox_Destination.Location = New System.Drawing.Point(73, 74)
		Me.TextBox_Destination.Name = "TextBox_Destination"
		Me.HelpProvider1.SetShowHelp(Me.TextBox_Destination, True)
		Me.TextBox_Destination.Size = New System.Drawing.Size(258, 20)
		Me.TextBox_Destination.TabIndex = 3
		'
		'CheckBox_Metadata
		'
		Me.CheckBox_Metadata.AutoSize = True
		Me.CheckBox_Metadata.Checked = True
		Me.CheckBox_Metadata.CheckState = System.Windows.Forms.CheckState.Checked
		Me.HelpProvider1.SetHelpString(Me.CheckBox_Metadata, "Embed metadata to the video file.")
		Me.CheckBox_Metadata.Location = New System.Drawing.Point(7, 65)
		Me.CheckBox_Metadata.Name = "CheckBox_Metadata"
		Me.HelpProvider1.SetShowHelp(Me.CheckBox_Metadata, True)
		Me.CheckBox_Metadata.Size = New System.Drawing.Size(135, 17)
		Me.CheckBox_Metadata.TabIndex = 9
		Me.CheckBox_Metadata.Text = "Embed video metadata"
		Me.CheckBox_Metadata.UseVisualStyleBackColor = True
		'
		'GroupBox_Settings
		'
		Me.GroupBox_Settings.Controls.Add(Me.CheckBox_CompatibilityMode)
		Me.GroupBox_Settings.Controls.Add(Me.CheckBox_AddIDToFilename)
		Me.GroupBox_Settings.Controls.Add(Me.CheckBox_SplitChapters)
		Me.GroupBox_Settings.Controls.Add(Me.CheckBox_Metadata)
		Me.GroupBox_Settings.Location = New System.Drawing.Point(200, 122)
		Me.GroupBox_Settings.Name = "GroupBox_Settings"
		Me.GroupBox_Settings.Size = New System.Drawing.Size(180, 131)
		Me.GroupBox_Settings.TabIndex = 6
		Me.GroupBox_Settings.TabStop = False
		Me.GroupBox_Settings.Text = "Settings"
		'
		'CheckBox_CompatibilityMode
		'
		Me.CheckBox_CompatibilityMode.AutoSize = True
		Me.CheckBox_CompatibilityMode.Checked = True
		Me.CheckBox_CompatibilityMode.CheckState = System.Windows.Forms.CheckState.Checked
		Me.HelpProvider1.SetHelpString(Me.CheckBox_CompatibilityMode, "AV1 is only compatible with newer hardware. AV1 videos on older systems may stutt" &
		"er or be blank with only audio.")
		Me.CheckBox_CompatibilityMode.Location = New System.Drawing.Point(7, 42)
		Me.CheckBox_CompatibilityMode.Name = "CheckBox_CompatibilityMode"
		Me.HelpProvider1.SetShowHelp(Me.CheckBox_CompatibilityMode, True)
		Me.CheckBox_CompatibilityMode.Size = New System.Drawing.Size(157, 17)
		Me.CheckBox_CompatibilityMode.TabIndex = 8
		Me.CheckBox_CompatibilityMode.Text = "Compatibility mode (no AV1)"
		Me.CheckBox_CompatibilityMode.UseVisualStyleBackColor = True
		'
		'CheckBox_AddIDToFilename
		'
		Me.CheckBox_AddIDToFilename.AutoSize = True
		Me.CheckBox_AddIDToFilename.Checked = True
		Me.CheckBox_AddIDToFilename.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckBox_AddIDToFilename.Location = New System.Drawing.Point(7, 19)
		Me.CheckBox_AddIDToFilename.Name = "CheckBox_AddIDToFilename"
		Me.CheckBox_AddIDToFilename.Size = New System.Drawing.Size(142, 17)
		Me.CheckBox_AddIDToFilename.TabIndex = 7
		Me.CheckBox_AddIDToFilename.Text = "Add video ID to filename"
		Me.CheckBox_AddIDToFilename.UseVisualStyleBackColor = True
		'
		'CheckBox_SplitChapters
		'
		Me.CheckBox_SplitChapters.AutoSize = True
		Me.HelpProvider1.SetHelpString(Me.CheckBox_SplitChapters, "If the video contains chapters, download multiple files each corresponsing to a c" &
		"hapter.")
		Me.CheckBox_SplitChapters.Location = New System.Drawing.Point(7, 88)
		Me.CheckBox_SplitChapters.Name = "CheckBox_SplitChapters"
		Me.HelpProvider1.SetShowHelp(Me.CheckBox_SplitChapters, True)
		Me.CheckBox_SplitChapters.Size = New System.Drawing.Size(154, 17)
		Me.CheckBox_SplitChapters.TabIndex = 10
		Me.CheckBox_SplitChapters.Text = "Separate chapters into files"
		Me.CheckBox_SplitChapters.UseVisualStyleBackColor = True
		'
		'BackgroundWorker1
		'
		'
		'ProgressBar_Download
		'
		Me.HelpProvider1.SetHelpString(Me.ProgressBar_Download, "Progress bar. May fill up multiple times before completion.")
		Me.ProgressBar_Download.Location = New System.Drawing.Point(6, 19)
		Me.ProgressBar_Download.Name = "ProgressBar_Download"
		Me.HelpProvider1.SetShowHelp(Me.ProgressBar_Download, True)
		Me.ProgressBar_Download.Size = New System.Drawing.Size(356, 23)
		Me.ProgressBar_Download.TabIndex = 6
		'
		'GroupBox_Output
		'
		Me.GroupBox_Output.Controls.Add(Me.ProgressBar_Download)
		Me.GroupBox_Output.Controls.Add(Me.TextBox_Output)
		Me.GroupBox_Output.Location = New System.Drawing.Point(12, 259)
		Me.GroupBox_Output.Name = "GroupBox_Output"
		Me.GroupBox_Output.Size = New System.Drawing.Size(368, 147)
		Me.GroupBox_Output.TabIndex = 8
		Me.GroupBox_Output.TabStop = False
		Me.GroupBox_Output.Text = "Output"
		'
		'LinkLabel_FuzePage
		'
		Me.LinkLabel_FuzePage.AutoSize = True
		Me.LinkLabel_FuzePage.Location = New System.Drawing.Point(12, 417)
		Me.LinkLabel_FuzePage.Name = "LinkLabel_FuzePage"
		Me.LinkLabel_FuzePage.Size = New System.Drawing.Size(145, 13)
		Me.LinkLabel_FuzePage.TabIndex = 12
		Me.LinkLabel_FuzePage.Text = "Fuze.page/software/FuzeVD"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(389, 441)
		Me.Controls.Add(Me.LinkLabel_FuzePage)
		Me.Controls.Add(Me.Button_Update)
		Me.Controls.Add(Me.GroupBox_Output)
		Me.Controls.Add(Me.GroupBox_Settings)
		Me.Controls.Add(Me.GroupBox_Basics)
		Me.Controls.Add(Me.GroupBox_Formats)
		Me.HelpButton = True
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(405, 480)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(405, 480)
		Me.Name = "Form1"
		Me.Text = "Fuze Video Downloader v2.1.1"
		Me.GroupBox_Formats.ResumeLayout(False)
		Me.GroupBox_Formats.PerformLayout()
		Me.GroupBox_Basics.ResumeLayout(False)
		Me.GroupBox_Basics.PerformLayout()
		Me.GroupBox_Settings.ResumeLayout(False)
		Me.GroupBox_Settings.PerformLayout()
		Me.GroupBox_Output.ResumeLayout(False)
		Me.GroupBox_Output.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button_Download As Button
	Friend WithEvents Box_Url As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Button_Update As Button
	Friend WithEvents GroupBox_Formats As GroupBox
	Friend WithEvents TextBox_Output As TextBox
	Friend WithEvents ComboBox_Quality As ComboBox
	Friend WithEvents ComboBox_FileType As ComboBox
	Friend WithEvents GroupBox_Basics As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox_Destination As TextBox
	Friend WithEvents Button_Directory As Button
	Friend WithEvents GroupBox_Settings As GroupBox
	Friend WithEvents Label_Quality As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents CheckBox_Metadata As CheckBox
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents ProgressBar_Download As ProgressBar
	Friend WithEvents GroupBox_Output As GroupBox
	Friend WithEvents LinkLabel_FuzePage As LinkLabel
	Friend WithEvents HelpProvider1 As HelpProvider
	Friend WithEvents CheckBox_SplitChapters As CheckBox
	Friend WithEvents CheckBox_AddIDToFilename As CheckBox
	Friend WithEvents CheckBox_CompatibilityMode As CheckBox
End Class
