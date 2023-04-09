Public Class MenuForm
    Private Sub ButtonAddrecord_Click(sender As Object, e As EventArgs) Handles ButtonAddrecord.Click
        Choices.Show()
        Hide()
    End Sub

    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        Load_data.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Hide()
    End Sub
End Class