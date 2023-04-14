Imports MySql.Data.MySqlClient

Public Class AddPost

    ReadOnly cmd As New MySqlCommand

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim title As String = TbTitle.Text
        Dim content As String = TbContent.Text

        If title = "" And content = "" Then
            MessageBox.Show("All Fields Required", "Input Error")
        Else

            Try
                cmd.CommandText = $"INSERT INTO `binlayo_db`.`posts` (`title`, `content`, `user_id`) VALUES ('{title}', '{content}', {My.Settings.UserId});"


                cmd.ExecuteNonQuery()

                MessageBox.Show("Success Post")

            Catch ex As Exception
                MessageBox.Show("Failed Post")

            End Try



        End If


    End Sub

    Private Sub AddPost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()

        cmd.Connection = conn
    End Sub
End Class