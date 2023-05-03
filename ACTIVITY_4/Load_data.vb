Imports MySql.Data.MySqlClient
Public Class Load_data
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect_to_DB()
        Dim cmd1 As New MySqlCommand("Select idprofile, fname, lname, address from profile", myconn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Disconnect_to_DB()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Connect_to_DB()
        Dim cmd1 As New MySqlCommand("Select idgrades, finalgrades from grades", myconn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Disconnect_to_DB()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Connect_to_DB()
        Dim cmd1 As New MySqlCommand("Select idcollege, department from college", myconn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Disconnect_to_DB()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Connect_to_DB()
        Dim cmd1 As New MySqlCommand("Select idcontact_details, contact_person, phone_num from contact_details", myconn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Disconnect_to_DB()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call Connect_to_DB()
        Dim cmd1 As New MySqlCommand("Select idstudentstat, status from studentstat", myconn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        Disconnect_to_DB()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MenuForm.Show()
        Hide()
    End Sub

    Private Sub Load_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class