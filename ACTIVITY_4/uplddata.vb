Imports System.IO
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class uplddata
    Private Sub uplddata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Try
            myconn.Open()
            strSQL = "SELECT * FROM upload"
            cmd = New MySqlCommand

            With cmd
                .Connection = myconn
                .CommandText = strSQL
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
        Finally
            myconn.Close()
        End Try
    End Sub
    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Call Connect_to_DB()
        Try
            OpenFileDialog1.Filter = "CSV| *.csv"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                TextBox1.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BttnUpload_Click(sender As Object, e As EventArgs) Handles BttnUpload.Click
        strSQL = "Insert into upload(CSVname) VALUES('" & System.IO.Path.GetFileName(TextBox1.Text) & "')"

        cmd = New MySqlCommand
        With cmd
            .Connection = myconn
            .CommandText = strSQL
            .ExecuteNonQuery()
        End With
        If TextBox1.Text <> "" Then
            System.IO.File.Copy(TextBox1.Text, Application.StartupPath & "\CSVfile\" & System.IO.Path.GetFileName(TextBox1.Text))
        End If

        'Open a StreamReader to read the contents of the CSV file
        Dim sr As New StreamReader(OpenFileDialog1.FileName)
            While Not sr.EndOfStream
                Dim line As String = sr.ReadLine()
                'Split the line into an array of values
                Dim values() As String = line.Split(",")

            'Insert the values into the database using SqlCommand
            Dim cmd As New MySqlCommand("INSERT INTO profile (idprofile, fname, lname, address) VALUES (@idprofile, @fname, @lname, @address)", myconn)
            cmd.Parameters.AddWithValue("@idprofile", values(0))
            cmd.Parameters.AddWithValue("@fname", values(1))
            cmd.Parameters.AddWithValue("@lname", values(2))
            cmd.Parameters.AddWithValue("@address", values(3))
            cmd.ExecuteNonQuery()
            End While

        'Close the SQL connection and the StreamReader
        sr.Close()

        MessageBox.Show("Uploaded Successfully!")
        TextBox1.Clear()
        myconn.Close()
        Call uplddata_Load(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Profile.Show()
        Hide()
    End Sub
End Class