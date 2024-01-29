Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        realclock.Start()
    End Sub

    Private Sub realclock_Tick(sender As Object, e As EventArgs) Handles realclock.Tick
        Dim RealTime As String = Format(Date.Now, "h:mm:ss tt")
        digiclock.Text = RealTime
    End Sub

    Private Sub Main_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        realclock.Stop()
    End Sub
End Class