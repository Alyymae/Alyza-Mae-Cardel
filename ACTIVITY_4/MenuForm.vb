Public Class MenuForm
    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
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

    Private Sub backup_Click(sender As Object, e As EventArgs) Handles backup.Click
        Dim retval
        retval = Shell("C:\Users\alyza\backupfunction.bat", 1)
        MessageBox.Show("Backup Successfully!")
    End Sub
End Class