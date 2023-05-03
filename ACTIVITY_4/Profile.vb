Imports MySql.Data.MySqlClient

Public Class Profile
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into profile values('" _
                & .TextID.Text & "', '" _
                & .TextFirstname.Text & "', '" _
                 & .TextLastname.Text & "', '" _
                & .TextAddress.Text & "')"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Added")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .TextID.Text = ""
            .TextFirstname.Text = ""
            .TextLastname.Text = ""
            .TextAddress.Text = ""
        End With
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Hide()
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        MenuForm.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Choices.Show()
        Hide()
    End Sub

    Private Sub upload_Click(sender As Object, e As EventArgs) Handles upload.Click
        uplddata.Show()
        Hide()
    End Sub

    Private Sub bttnExport_Click(sender As Object, e As EventArgs)
        Export.Show()
        Hide()
    End Sub

    Private Sub bttnExport_Click_1(sender As Object, e As EventArgs) Handles bttnExport.Click
        Export.Show()
        Hide()
    End Sub
End Class
