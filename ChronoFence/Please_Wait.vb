Public Class Please_Wait
    Private Sub Please_Wait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        wait(2)
        Close()
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
End Class