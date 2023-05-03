Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Export
    Private Sub Export_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub bttnExport_Click(sender As Object, e As EventArgs) Handles bttnExport.Click
        Dim xlapp As Excel.Application
        Dim xlworkbook As Excel.Workbook
        Dim xlworksheet As Excel.Worksheet
        Dim misvalue As Object = System.Reflection.Missing.Value
        Dim i, j As Integer

        xlapp = New Excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlworkbook.Sheets("sheet1")

        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                xlworksheet.Cells(i + 1, j + 1) =
                    DataGridView1(j, i).Value.ToString()
            Next
        Next
        xlworksheet.SaveAs("C:\Users\alyza\OneDrive\Desktop\ProfileReport.xlsx")
        xlworkbook.Close()
        xlapp.Quit()

        releaseObject(xlapp)
        releaseObject(xlworkbook)
        releaseObject(xlworksheet)
        MessageBox.Show("Successfull!")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing

        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub bttshow_Click(sender As Object, e As EventArgs) Handles bttshow.Click
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

End Class