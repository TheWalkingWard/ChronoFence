﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        PictureBox1 = New PictureBox()
        ScheduleStart = New Label()
        PictureBox2 = New PictureBox()
        ScheduleStartTextbox = New TextBox()
        ScheduleUntil = New Label()
        PictureBox3 = New PictureBox()
        ScheduleUntilTextbox = New TextBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        FromTextbox = New TextBox()
        ToTextbox = New TextBox()
        StartButton = New Button()
        StopButton = New Button()
        LogRichTextBox = New RichTextBox()
        FencePic = New PictureBox()
        CType(tod, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(FencePic, ComponentModel.ISupportInitialize).BeginInit()
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
        current_date.Image = My.Resources.Resources.e59178a329eaf5a268d2b86eba410181_removebg_preview5
        current_date.Location = New Point(147, 143)
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
        digiclock.Font = New Font("Bahnschrift Condensed", 38.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        digiclock.ForeColor = SystemColors.HighlightText
        digiclock.Image = My.Resources.Resources.e59178a329eaf5a268d2b86eba410181_removebg_preview2
        digiclock.Location = New Point(98, 81)
        digiclock.Name = "digiclock"
        digiclock.Size = New Size(225, 62)
        digiclock.TabIndex = 1
        digiclock.Text = "00:00:00 AM"
        ' 
        ' tod
        ' 
        tod.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tod.BackColor = Color.Transparent
        tod.BackgroundImage = CType(resources.GetObject("tod.BackgroundImage"), Image)
        tod.Image = My.Resources.Resources.day
        tod.Location = New Point(24, 81)
        tod.Name = "tod"
        tod.Size = New Size(68, 62)
        tod.SizeMode = PictureBoxSizeMode.Zoom
        tod.TabIndex = 4
        tod.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.e59178a329eaf5a268d2b86eba410181_removebg_preview1
        PictureBox1.Location = New Point(24, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(362, 188)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' ScheduleStart
        ' 
        ScheduleStart.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ScheduleStart.AutoSize = True
        ScheduleStart.BackColor = Color.Transparent
        ScheduleStart.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScheduleStart.ForeColor = SystemColors.HighlightText
        ScheduleStart.Location = New Point(9, 236)
        ScheduleStart.Name = "ScheduleStart"
        ScheduleStart.Size = New Size(174, 39)
        ScheduleStart.TabIndex = 9
        ScheduleStart.Text = "Schedule Start"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.Paint_Colors_by_Project_Nursery_removebg_preview
        PictureBox2.Location = New Point(-24, 240)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(220, 130)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' ScheduleStartTextbox
        ' 
        ScheduleStartTextbox.BackColor = SystemColors.Window
        ScheduleStartTextbox.Enabled = False
        ScheduleStartTextbox.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScheduleStartTextbox.Location = New Point(24, 291)
        ScheduleStartTextbox.Name = "ScheduleStartTextbox"
        ScheduleStartTextbox.Size = New Size(136, 27)
        ScheduleStartTextbox.TabIndex = 11
        ' 
        ' ScheduleUntil
        ' 
        ScheduleUntil.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ScheduleUntil.AutoSize = True
        ScheduleUntil.BackColor = Color.Transparent
        ScheduleUntil.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScheduleUntil.ForeColor = SystemColors.HighlightText
        ScheduleUntil.Location = New Point(202, 240)
        ScheduleUntil.Name = "ScheduleUntil"
        ScheduleUntil.Size = New Size(168, 39)
        ScheduleUntil.TabIndex = 12
        ScheduleUntil.Text = "Schedule Until"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.Paint_Colors_by_Project_Nursery_removebg_preview
        PictureBox3.Location = New Point(176, 240)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(220, 130)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' ScheduleUntilTextbox
        ' 
        ScheduleUntilTextbox.BackColor = SystemColors.Window
        ScheduleUntilTextbox.Enabled = False
        ScheduleUntilTextbox.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScheduleUntilTextbox.Location = New Point(224, 291)
        ScheduleUntilTextbox.Name = "ScheduleUntilTextbox"
        ScheduleUntilTextbox.Size = New Size(136, 27)
        ScheduleUntilTextbox.TabIndex = 14
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.bf6af0661f4889036dded79ed6e0d3bc_removebg_preview2
        PictureBox4.Location = New Point(-125, 309)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(649, 552)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 15
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bahnschrift Condensed", 38.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Desktop
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(80, 386)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 62)
        Label1.TabIndex = 16
        Label1.Text = "SET ALARM"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Desktop
        Label2.Image = My.Resources.Resources.bf6af0661f4889036dded79ed6e0d3bc_removebg_preview3
        Label2.Location = New Point(1, 459)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 39)
        Label2.TabIndex = 17
        Label2.Text = "From:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Desktop
        Label3.Image = My.Resources.Resources.bf6af0661f4889036dded79ed6e0d3bc_removebg_preview4
        Label3.Location = New Point(200, 459)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 39)
        Label3.TabIndex = 18
        Label3.Text = "To:"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = My.Resources.Resources.bf6af0661f4889036dded79ed6e0d3bc_removebg_preview5
        PictureBox5.Image = My.Resources.Resources.Paint_Colors_by_Project_Nursery_removebg_preview
        PictureBox5.Location = New Point(62, 418)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(146, 130)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = My.Resources.Resources.bf6af0661f4889036dded79ed6e0d3bc_removebg_preview5
        PictureBox6.Image = My.Resources.Resources.Paint_Colors_by_Project_Nursery_removebg_preview
        PictureBox6.Location = New Point(233, 418)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(146, 130)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 20
        PictureBox6.TabStop = False
        ' 
        ' FromTextbox
        ' 
        FromTextbox.BackColor = SystemColors.Window
        FromTextbox.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FromTextbox.Location = New Point(90, 470)
        FromTextbox.Name = "FromTextbox"
        FromTextbox.Size = New Size(98, 27)
        FromTextbox.TabIndex = 21
        ' 
        ' ToTextbox
        ' 
        ToTextbox.BackColor = SystemColors.Window
        ToTextbox.Font = New Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToTextbox.Location = New Point(260, 471)
        ToTextbox.Name = "ToTextbox"
        ToTextbox.Size = New Size(98, 27)
        ToTextbox.TabIndex = 22
        ' 
        ' StartButton
        ' 
        StartButton.BackColor = Color.Transparent
        StartButton.Font = New Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StartButton.Image = My.Resources.Resources._4749a48027bcef458141768634d00be5
        StartButton.Location = New Point(90, 554)
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
        StopButton.Location = New Point(90, 594)
        StopButton.Name = "StopButton"
        StopButton.Size = New Size(203, 34)
        StopButton.TabIndex = 24
        StopButton.Text = "Stop"
        StopButton.UseVisualStyleBackColor = False
        ' 
        ' LogRichTextBox
        ' 
        LogRichTextBox.Location = New Point(405, 327)
        LogRichTextBox.Name = "LogRichTextBox"
        LogRichTextBox.Size = New Size(421, 210)
        LogRichTextBox.TabIndex = 25
        LogRichTextBox.Text = ""
        ' 
        ' FencePic
        ' 
        FencePic.Image = My.Resources.Resources.FenceWithoutElectricReal
        FencePic.Location = New Point(405, 27)
        FencePic.Name = "FencePic"
        FencePic.Size = New Size(439, 248)
        FencePic.SizeMode = PictureBoxSizeMode.Zoom
        FencePic.TabIndex = 26
        FencePic.TabStop = False
        ' 
        ' Main_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.d884313f59e3570229be10a8526d9619
        ClientSize = New Size(976, 709)
        Controls.Add(FencePic)
        Controls.Add(LogRichTextBox)
        Controls.Add(StopButton)
        Controls.Add(StartButton)
        Controls.Add(ToTextbox)
        Controls.Add(FromTextbox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ScheduleUntilTextbox)
        Controls.Add(ScheduleUntil)
        Controls.Add(ScheduleStartTextbox)
        Controls.Add(ScheduleStart)
        Controls.Add(digiclock)
        Controls.Add(tod)
        Controls.Add(current_date)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox4)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Main_Menu"
        Text = "ChronoFence Dashboard"
        CType(tod, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(FencePic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents realclock As Timer
    Friend WithEvents current_date As Label
    Friend WithEvents digiclock As Label
    Friend WithEvents tod As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ScheduleStart As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ScheduleStartTextbox As TextBox
    Friend WithEvents ScheduleUntil As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ScheduleUntilTextbox As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents FromTextbox As TextBox
    Friend WithEvents ToTextbox As TextBox
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents LogRichTextBox As RichTextBox
    Friend WithEvents FencePic As PictureBox
End Class
