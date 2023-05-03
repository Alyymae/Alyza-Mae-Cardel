Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextPassword.UseSystemPasswordChar = True Then
            'hide password
            TextPassword.UseSystemPasswordChar = False
        Else
            'show password
            TextPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        If TextUsername.Text = "admin" And TextPassword.Text = "admin" Then
            Clear_Boxes()
            MenuForm.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
        End If
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Hide()
    End Sub


    Private Sub Clear_Boxes()
        With Me
            .TextUsername.Text = ""
            .TextPassword.Text = ""
        End With
    End Sub
End Class
