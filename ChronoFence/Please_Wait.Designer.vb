<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Please_Wait
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
        h_glass = New PictureBox()
        wait_msg = New Label()
        CType(h_glass, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' h_glass
        ' 
        h_glass.Image = My.Resources.Resources.wait_glass
        h_glass.Location = New Point(12, 14)
        h_glass.Name = "h_glass"
        h_glass.Size = New Size(60, 60)
        h_glass.SizeMode = PictureBoxSizeMode.Zoom
        h_glass.TabIndex = 0
        h_glass.TabStop = False
        ' 
        ' wait_msg
        ' 
        wait_msg.AutoSize = True
        wait_msg.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        wait_msg.Location = New Point(88, 28)
        wait_msg.Name = "wait_msg"
        wait_msg.Size = New Size(120, 30)
        wait_msg.TabIndex = 1
        wait_msg.Text = "Please Wait"
        wait_msg.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Please_Wait
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(230, 86)
        Controls.Add(wait_msg)
        Controls.Add(h_glass)
        FormBorderStyle = FormBorderStyle.None
        Name = "Please_Wait"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Please_Wait"
        CType(h_glass, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents h_glass As PictureBox
    Friend WithEvents wait_msg As Label
End Class
