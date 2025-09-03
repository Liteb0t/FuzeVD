<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Label_ffmpeg = New System.Windows.Forms.Label()
		Me.GroupBox_ytdlp = New System.Windows.Forms.GroupBox()
		Me.Label_ffmpeg_server = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label_fuzevd_server = New System.Windows.Forms.Label()
		Me.Label_fuzevd = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label_ytdlp_server = New System.Windows.Forms.Label()
		Me.Label_ytdlp = New System.Windows.Forms.Label()
		Me.Button_Update = New System.Windows.Forms.Button()
		Me.CheckBox_Reinstall = New System.Windows.Forms.CheckBox()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
		Me.Button_External = New System.Windows.Forms.Button()
		Me.GroupBox_ytdlp.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label_ffmpeg
		'
		Me.Label_ffmpeg.AutoSize = True
		Me.Label_ffmpeg.Location = New System.Drawing.Point(6, 16)
		Me.Label_ffmpeg.Name = "Label_ffmpeg"
		Me.Label_ffmpeg.Size = New System.Drawing.Size(54, 13)
		Me.Label_ffmpeg.TabIndex = 1
		Me.Label_ffmpeg.Text = "Loading..."
		'
		'GroupBox_ytdlp
		'
		Me.GroupBox_ytdlp.Controls.Add(Me.Label_ffmpeg_server)
		Me.GroupBox_ytdlp.Controls.Add(Me.Label_ffmpeg)
		Me.GroupBox_ytdlp.Location = New System.Drawing.Point(12, 68)
		Me.GroupBox_ytdlp.Name = "GroupBox_ytdlp"
		Me.GroupBox_ytdlp.Size = New System.Drawing.Size(288, 50)
		Me.GroupBox_ytdlp.TabIndex = 2
		Me.GroupBox_ytdlp.TabStop = False
		Me.GroupBox_ytdlp.Text = "FFmpeg"
		'
		'Label_ffmpeg_server
		'
		Me.Label_ffmpeg_server.AutoSize = True
		Me.Label_ffmpeg_server.Location = New System.Drawing.Point(147, 16)
		Me.Label_ffmpeg_server.Name = "Label_ffmpeg_server"
		Me.Label_ffmpeg_server.Size = New System.Drawing.Size(117, 13)
		Me.Label_ffmpeg_server.TabIndex = 3
		Me.Label_ffmpeg_server.Text = "Waiting for fuze.page..."
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label_fuzevd_server)
		Me.GroupBox1.Controls.Add(Me.Label_fuzevd)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 124)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(288, 50)
		Me.GroupBox1.TabIndex = 3
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "FuzeVD"
		'
		'Label_fuzevd_server
		'
		Me.Label_fuzevd_server.AutoSize = True
		Me.Label_fuzevd_server.Location = New System.Drawing.Point(147, 16)
		Me.Label_fuzevd_server.Name = "Label_fuzevd_server"
		Me.Label_fuzevd_server.Size = New System.Drawing.Size(117, 13)
		Me.Label_fuzevd_server.TabIndex = 4
		Me.Label_fuzevd_server.Text = "Waiting for fuze.page..."
		'
		'Label_fuzevd
		'
		Me.Label_fuzevd.AutoSize = True
		Me.Label_fuzevd.Location = New System.Drawing.Point(6, 16)
		Me.Label_fuzevd.Name = "Label_fuzevd"
		Me.Label_fuzevd.Size = New System.Drawing.Size(54, 13)
		Me.Label_fuzevd.TabIndex = 1
		Me.Label_fuzevd.Text = "Loading..."
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label_ytdlp_server)
		Me.GroupBox2.Controls.Add(Me.Label_ytdlp)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(288, 50)
		Me.GroupBox2.TabIndex = 3
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Yt-dlp"
		'
		'Label_ytdlp_server
		'
		Me.Label_ytdlp_server.AutoSize = True
		Me.Label_ytdlp_server.Location = New System.Drawing.Point(147, 16)
		Me.Label_ytdlp_server.Name = "Label_ytdlp_server"
		Me.Label_ytdlp_server.Size = New System.Drawing.Size(117, 13)
		Me.Label_ytdlp_server.TabIndex = 2
		Me.Label_ytdlp_server.Text = "Waiting for fuze.page..."
		'
		'Label_ytdlp
		'
		Me.Label_ytdlp.AutoSize = True
		Me.Label_ytdlp.Location = New System.Drawing.Point(6, 16)
		Me.Label_ytdlp.Name = "Label_ytdlp"
		Me.Label_ytdlp.Size = New System.Drawing.Size(54, 13)
		Me.Label_ytdlp.TabIndex = 1
		Me.Label_ytdlp.Text = "Loading..."
		'
		'Button_Update
		'
		Me.Button_Update.Enabled = False
		Me.Button_Update.Location = New System.Drawing.Point(225, 180)
		Me.Button_Update.Name = "Button_Update"
		Me.Button_Update.Size = New System.Drawing.Size(75, 23)
		Me.Button_Update.TabIndex = 4
		Me.Button_Update.Text = "Update"
		Me.Button_Update.UseVisualStyleBackColor = True
		'
		'CheckBox_Reinstall
		'
		Me.CheckBox_Reinstall.AutoSize = True
		Me.CheckBox_Reinstall.Location = New System.Drawing.Point(149, 184)
		Me.CheckBox_Reinstall.Name = "CheckBox_Reinstall"
		Me.CheckBox_Reinstall.Size = New System.Drawing.Size(70, 17)
		Me.CheckBox_Reinstall.TabIndex = 6
		Me.CheckBox_Reinstall.Text = "Re-Install"
		Me.CheckBox_Reinstall.UseVisualStyleBackColor = True
		'
		'BackgroundWorker1
		'
		'
		'BackgroundWorker2
		'
		'
		'Button_External
		'
		Me.Button_External.Location = New System.Drawing.Point(12, 180)
		Me.Button_External.Name = "Button_External"
		Me.Button_External.Size = New System.Drawing.Size(121, 23)
		Me.Button_External.TabIndex = 7
		Me.Button_External.Text = "External update yt-dlp"
		Me.Button_External.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(304, 207)
		Me.Controls.Add(Me.Button_External)
		Me.Controls.Add(Me.CheckBox_Reinstall)
		Me.Controls.Add(Me.Button_Update)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.GroupBox_ytdlp)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(320, 246)
		Me.MinimumSize = New System.Drawing.Size(320, 246)
		Me.Name = "Form1"
		Me.Text = "FuzeVD Updater"
		Me.GroupBox_ytdlp.ResumeLayout(False)
		Me.GroupBox_ytdlp.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label_ffmpeg As Label
    Friend WithEvents GroupBox_ytdlp As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label_fuzevd As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label_ytdlp As Label
    Friend WithEvents Button_Update As Button
    Friend WithEvents CheckBox_Reinstall As CheckBox
    Friend WithEvents Label_ffmpeg_server As Label
    Friend WithEvents Label_fuzevd_server As Label
    Friend WithEvents Label_ytdlp_server As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button_External As Button
End Class
