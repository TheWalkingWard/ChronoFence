<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        realclock = New Timer(components)
        current_date = New Label()
        digiclock = New Label()
        tod = New PictureBox()
        ScheduleStartTextbox = New TextBox()
        ScheduleUntilTextbox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        FromTextbox = New TextBox()
        ToTextbox = New TextBox()
        StartButton = New Button()
        StopButton = New Button()
        LogRichTextBox = New RichTextBox()
        FencePic = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox12 = New PictureBox()
        CType(tod, ComponentModel.ISupportInitialize).BeginInit()
        CType(FencePic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' realclock
        ' 
        ' 
        ' current_date
        ' 
        current_date.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        current_date.AutoSize = True
        current_date.BackColor = Color.Transparent
        current_date.Font = New Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        current_date.ForeColor = SystemColors.HighlightText
        current_date.Location = New Point(159, 189)
        current_date.Name = "current_date"
        current_date.Size = New Size(109, 23)
        current_date.TabIndex = 2
        current_date.Text = "January 1, 2024"
        ' 
        ' digiclock
        ' 
        digiclock.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        digiclock.AutoSize = True
        digiclock.BackColor = Color.Transparent
        digiclock.Font = New Font("Bahnschrift Condensed", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        digiclock.ForeColor = SystemColors.HighlightText
        digiclock.Location = New Point(107, 117)
        digiclock.Name = "digiclock"
        digiclock.Size = New Size(283, 77)
        digiclock.TabIndex = 1
        digiclock.Text = "00:00:00 AM"
        ' 
        ' tod
        ' 
        tod.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tod.BackColor = Color.Transparent
        tod.Image = My.Resources.Resources.day
        tod.Location = New Point(59, 133)
        tod.Name = "tod"
        tod.Size = New Size(57, 50)
        tod.SizeMode = PictureBoxSizeMode.Zoom
        tod.TabIndex = 4
        tod.TabStop = False
        ' 
        ' ScheduleStartTextbox
        ' 
        ScheduleStartTextbox.BackColor = SystemColors.Window
        ScheduleStartTextbox.Enabled = False
        ScheduleStartTextbox.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScheduleStartTextbox.Location = New Point(59, 308)
        ScheduleStartTextbox.Name = "ScheduleStartTextbox"
        ScheduleStartTextbox.Size = New Size(136, 27)
        ScheduleStartTextbox.TabIndex = 11
        ' 
        ' ScheduleUntilTextbox
        ' 
        ScheduleUntilTextbox.BackColor = SystemColors.Window
        ScheduleUntilTextbox.Enabled = False
        ScheduleUntilTextbox.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScheduleUntilTextbox.Location = New Point(226, 308)
        ScheduleUntilTextbox.Name = "ScheduleUntilTextbox"
        ScheduleUntilTextbox.Size = New Size(136, 27)
        ScheduleUntilTextbox.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bahnschrift Condensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(131, 387)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 45)
        Label1.TabIndex = 16
        Label1.Text = "SET ALARM"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(132, 501)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 33)
        Label2.TabIndex = 17
        Label2.Text = "FROM"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(308, 500)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 33)
        Label3.TabIndex = 18
        Label3.Text = "TO"
        ' 
        ' FromTextbox
        ' 
        FromTextbox.BackColor = SystemColors.Window
        FromTextbox.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FromTextbox.Location = New Point(59, 479)
        FromTextbox.Name = "FromTextbox"
        FromTextbox.Size = New Size(136, 27)
        FromTextbox.TabIndex = 21
        ' 
        ' ToTextbox
        ' 
        ToTextbox.BackColor = SystemColors.Window
        ToTextbox.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToTextbox.Location = New Point(226, 479)
        ToTextbox.Name = "ToTextbox"
        ToTextbox.Size = New Size(136, 27)
        ToTextbox.TabIndex = 22
        ' 
        ' StartButton
        ' 
        StartButton.BackColor = Color.Transparent
        StartButton.Font = New Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StartButton.Image = My.Resources.Resources._4749a48027bcef458141768634d00be5
        StartButton.Location = New Point(104, 569)
        StartButton.Margin = New Padding(0)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(203, 34)
        StartButton.TabIndex = 23
        StartButton.Text = "Start"
        StartButton.UseVisualStyleBackColor = False
        ' 
        ' StopButton
        ' 
        StopButton.BackColor = Color.Transparent
        StopButton.Font = New Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StopButton.Image = My.Resources.Resources._7f44006055ccf18af7e6d43ebd748d69
        StopButton.Location = New Point(104, 609)
        StopButton.Name = "StopButton"
        StopButton.Size = New Size(203, 34)
        StopButton.TabIndex = 24
        StopButton.Text = "Stop"
        StopButton.UseVisualStyleBackColor = False
        ' 
        ' LogRichTextBox
        ' 
        LogRichTextBox.Location = New Point(479, 370)
        LogRichTextBox.Name = "LogRichTextBox"
        LogRichTextBox.Size = New Size(321, 210)
        LogRichTextBox.TabIndex = 25
        LogRichTextBox.Text = ""
        ' 
        ' FencePic
        ' 
        FencePic.Image = My.Resources.Resources.FenceWithoutElectricReal
        FencePic.Location = New Point(479, 106)
        FencePic.Name = "FencePic"
        FencePic.Size = New Size(321, 211)
        FencePic.SizeMode = PictureBoxSizeMode.Zoom
        FencePic.TabIndex = 26
        FencePic.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.a4078e2840aa46de9fbf97827ab44442_removebg_preview1
        PictureBox1.Location = New Point(69, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(284, 248)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._78bd03c1085104e1c49a8deb85e8ac82
        PictureBox2.Location = New Point(211, 252)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(167, 138)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 28
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._78bd03c1085104e1c49a8deb85e8ac82
        PictureBox3.Location = New Point(43, 252)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(167, 138)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 29
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.fccb8e517e67a78af4db615396f7a27f_removebg_preview
        PictureBox4.Location = New Point(135, 87)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(154, 152)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 30
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources._2cada2d84518376a26fa76e2c9b618211
        PictureBox5.Location = New Point(23, 362)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(377, 94)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 31
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.Image = My.Resources.Resources._61ed8c40a8cc9570a803d24477a796d0_removebg_preview1
        PictureBox6.Location = New Point(23, 392)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(377, 36)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 32
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources._78bd03c1085104e1c49a8deb85e8ac82
        PictureBox7.Location = New Point(211, 423)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(167, 138)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 33
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources._78bd03c1085104e1c49a8deb85e8ac82
        PictureBox8.Location = New Point(43, 423)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(167, 138)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 34
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.Image = My.Resources.Resources._06caefe7b99fad174054c01f0bbf5e97_removebg_preview
        PictureBox9.Location = New Point(-13, 12)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(452, 685)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 35
        PictureBox9.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.Transparent
        PictureBox11.Image = My.Resources.Resources._06caefe7b99fad174054c01f0bbf5e97_removebg_preview
        PictureBox11.Location = New Point(415, 12)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(452, 685)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 37
        PictureBox11.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.Transparent
        PictureBox10.Image = My.Resources.Resources._9a1bcb9f5863bbe057f09079be20d968_removebg_preview
        PictureBox10.Location = New Point(446, 80)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(386, 263)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 38
        PictureBox10.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = Color.Transparent
        PictureBox12.Image = My.Resources.Resources._9a1bcb9f5863bbe057f09079be20d968_removebg_preview
        PictureBox12.Location = New Point(446, 343)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(386, 263)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 39
        PictureBox12.TabStop = False
        ' 
        ' Main_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bd59432c229ffd9d17dbefa285b730f4
        ClientSize = New Size(854, 709)
        Controls.Add(tod)
        Controls.Add(ToTextbox)
        Controls.Add(FromTextbox)
        Controls.Add(Label1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(digiclock)
        Controls.Add(ScheduleUntilTextbox)
        Controls.Add(ScheduleStartTextbox)
        Controls.Add(FencePic)
        Controls.Add(LogRichTextBox)
        Controls.Add(StopButton)
        Controls.Add(StartButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(current_date)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox12)
        Controls.Add(PictureBox11)
        ForeColor = Color.Transparent
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Main_Menu"
        Text = "ChronoFence Dashboard"
        CType(tod, ComponentModel.ISupportInitialize).EndInit()
        CType(FencePic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents realclock As Timer
    Friend WithEvents current_date As Label
    Friend WithEvents digiclock As Label
    Friend WithEvents tod As PictureBox
    Friend WithEvents ScheduleStartTextbox As TextBox
    Friend WithEvents ScheduleUntilTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FromTextbox As TextBox
    Friend WithEvents ToTextbox As TextBox
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents LogRichTextBox As RichTextBox
    Friend WithEvents FencePic As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
End Class
