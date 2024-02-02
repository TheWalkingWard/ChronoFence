Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        realclock.Start()
    End Sub

    Private Sub realclock_Tick(sender As Object, e As EventArgs) Handles realclock.Tick
        Dim RealTime As String = Format(Date.Now, "h:mm:ss tt")
        digiclock.Text = RealTime
        current_date.Text = Format(Date.Now, "MMMM d, yyyy")
        Dim minsofday As Integer = (Convert.ToInt32(Date.Now.Hour) * 60) + Convert.ToInt32(Date.Now.Minute)
        timeofday(minsofday)
        If (StoreValues.start_hh <= Date.Now.Hour And StoreValues.start_mm <= Date.Now.Minute) Then
            statusbox.Image = My.Resources.ResourceManager.GetObject("fence_active")
        ElseIf (StoreValues.start_hh > Date.Now.Hour And StoreValues.start_mm > Date.Now.Minute) Then
        End If
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

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Please_Wait.Show()
        statusbox.Image = My.Resources.ResourceManager.GetObject("fence_active")
    End Sub

    Private Sub Settime_Click(sender As Object, e As EventArgs) Handles Settime.Click
        StoreValues.start_hh = fromhh.SelectedItem
        StoreValues.start_mm = frommm.SelectedItem
        StoreValues.start_tt = fromtt.SelectedItem
        StoreValues.end_hh = tohh.SelectedItem
        StoreValues.end_mm = tomm.SelectedItem
        StoreValues.end_tt = tott.SelectedItem

        ScheduleStartTextbox.Text = Convert.ToString(fromhh.SelectedItem) & ":" & Convert.ToString(frommm.SelectedItem) & " " & Convert.ToString(fromtt.SelectedItem)
        ScheduleUntilTextbox.Text = tohh.SelectedItem & ":" & tomm.SelectedItem & " " & tott.SelectedItem
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        Please_Wait.Show()
        statusbox.Image = My.Resources.ResourceManager.GetObject("fence_offline")
    End Sub

    'Dapat may changes dun sa mismong website ng GitHub
    Private Sub testf_Click(sender As Object, e As EventArgs) Handles testf.Click
        Fault_Window.ShowDialog()
    End Sub
End Class