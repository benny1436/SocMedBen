Imports MySql.Data.MySqlClient
Public Class SIGNUP

    ReadOnly cmd As New MySqlCommand


    Private Sub SIGNUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Connect_to_DB()

    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim name As String = TbName.Text

        Dim email As String = TbEmail.Text
        Dim password As String = TbPassword.Text

        If email = "" And password = "" Then
            MessageBox.Show("All Fields Required", "Input Error")
        Else

            Try
                cmd.Connection = conn

                cmd.CommandText = $"INSERT INTO `binlayo_db`.`users` (`name`, `email`, `password`) VALUES ('{name}', '{email}', '{password}');"

                cmd.ExecuteNonQuery()
                MessageBox.Show("Success", "Signup Status")

            Catch ex As Exception
                MessageBox.Show("Failed", "Signup Status")

            End Try


        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim form = New LOGIN

        form.Show()

        conn.Close()


        Me.Close()
    End Sub
End Class