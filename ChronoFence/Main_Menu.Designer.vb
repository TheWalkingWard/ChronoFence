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
        digiclock = New Label()
        realclock = New Timer(components)
        SuspendLayout()
        ' 
        ' digiclock
        ' 
        digiclock.AutoSize = True
        digiclock.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        digiclock.Location = New Point(529, 44)
        digiclock.Name = "digiclock"
        digiclock.Size = New Size(195, 45)
        digiclock.TabIndex = 1
        digiclock.Text = "00:00:00 AM"
        ' 
        ' Main_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(digiclock)
        Name = "Main_Menu"
        Text = "Main_Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents digiclock As Label
    Friend WithEvents realclock As Timer
End Class
