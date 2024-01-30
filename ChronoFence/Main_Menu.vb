Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        realclock.Start()
    End Sub

    Private Sub realclock_Tick(sender As Object, e As EventArgs) Handles realclock.Tick
        Dim RealTime As String = Format(Date.Now, "h:mm:sstt")
        digiclock.Text = RealTime
        current_date.Text = Format(Date.Now, "MMMM d, yyyy")
        Dim minsofday As Integer = (Convert.ToInt32(Date.Now.Hour) * 60) + Convert.ToInt32(Date.Now.Minute)
        timeofday(minsofday)
    End Sub

    Private Sub Main_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        realclock.Stop()
    End Sub

    Private Sub timeofday(minsofday As Integer)
        If (minsofday >= 1110 Or minsofday < 300) Then
            tod.Image = My.Resources.ResourceManager.GetObject("night")
        ElseIf (minsofday >= 1050 Or (minsofday < 390)) Then
            tod.Image = My.Resources.ResourceManager.GetObject("sunriseset")
        Else
            tod.Image = My.Resources.ResourceManager.GetObject("day")
        End If
    End Sub


End Class