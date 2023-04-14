Imports MySql.Data.MySqlClient
Module Connection
    Public conn As New MySql.Data.MySqlClient.MySqlConnection
    Public myConnectionString As String

    Public Sub Connect_to_DB()
        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=MyNewPass;" _
                    & "database=binlayo_db"

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
            'MessageBox.Show("Connection Success!")

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Module