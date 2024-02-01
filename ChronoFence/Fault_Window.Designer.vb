<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fault_Window
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ok_btn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.fence_fault
        PictureBox1.Location = New Point(12, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(117, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 60)
        Label1.TabIndex = 1
        Label1.Text = "Fault" & vbCrLf & "Detected"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ok_btn
        ' 
        ok_btn.Location = New Point(12, 102)
        ok_btn.Name = "ok_btn"
        ok_btn.Size = New Size(206, 23)
        ok_btn.TabIndex = 2
        ok_btn.Text = "OK"
        ok_btn.UseVisualStyleBackColor = True
        ' 
        ' Fault_Window
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(230, 148)
        Controls.Add(ok_btn)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Fault_Window"
        StartPosition = FormStartPosition.CenterParent
        Text = "Fault_Window"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ok_btn As Button
End Class
