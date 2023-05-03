Namespace CsvHelper
    Friend Class CsvReader
        Private streamReader As IO.StreamReader

        Public Sub New(streamReader As IO.StreamReader)
            Me.streamReader = streamReader
        End Sub
    End Class
End Namespace
