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
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(tod, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' realclock
        ' 
        ' 
        ' current_date
        ' 
        current_date.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        current_date.AutoSize = True
        current_date.Font = New Font("Segoe UI", 14F)
        current_date.Location = New Point(93, 50)
        current_date.Name = "current_date"
        current_date.Size = New Size(204, 25)
        current_date.TabIndex = 2
        current_date.Text = "January 1, 2024"
        ' 
        ' digiclock
        ' 
        digiclock.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        digiclock.AutoSize = True
        digiclock.Font = New Font("Segoe UI", 15F)
        digiclock.Location = New Point(93, 11)
        digiclock.Name = "digiclock"
        digiclock.Size = New Size(204, 28)
        digiclock.TabIndex = 1
        digiclock.Text = "00:00:00AM"
        ' 
        ' tod
        ' 
        tod.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tod.Image = My.Resources.Resources.day
        tod.Location = New Point(3, 13)
        tod.Name = "tod"
        tod.Size = New Size(84, 34)
        tod.SizeMode = PictureBoxSizeMode.Zoom
        tod.TabIndex = 4
        tod.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel1.Controls.Add(tod, 0, 0)
        TableLayoutPanel1.Controls.Add(current_date, 1, 1)
        TableLayoutPanel1.Controls.Add(digiclock, 1, 0)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(300, 100)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' Main_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Main_Menu"
        Text = "ChronoFence Dashboard"
        CType(tod, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents realclock As Timer
    Friend WithEvents current_date As Label
    Friend WithEvents digiclock As Label
    Friend WithEvents tod As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
