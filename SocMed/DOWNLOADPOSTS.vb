Imports MySql.Data.MySqlClient

Public Class DOWNLOADPOSTS
    ReadOnly cmd As New MySqlCommand

    Private Sub btnListPosts_Click(sender As Object, e As EventArgs) Handles btnListPosts.Click
        Try
            cmd.Connection = conn

            cmd.CommandText = $"select * from posts where user_id = {My.Settings.UserId};"
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim post_id = reader.GetInt32(0)
                Dim post_title = reader.GetString(1)
                Dim post_content = reader.GetString(2)
                Dim post_owner_id = reader.GetInt32(3)

                ' Add a new row to the DataGridView and populate it with the record data
                postDgv.Rows.Add(post_id, post_title, post_content, post_owner_id)
            End While

            reader.Close()
            conn.Close()


        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDownloadPosts_Click(sender As Object, e As EventArgs) Handles btnDownloadPosts.Click
        Call ExportToExcel(postDgv, "benny_name.xlsx")

    End Sub

    Private Sub DOWNLOADPOSTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()
    End Sub

End Class