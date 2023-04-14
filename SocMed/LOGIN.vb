Imports MySql.Data.MySqlClient

Public Class LOGIN

    ReadOnly cmd As New MySqlCommand

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click


        Dim email As String = TbEmail.Text
        Dim password As String = TbPassword.Text

        If email = "" And password = "" Then
            MessageBox.Show("All Fields Required", "Input Error")
        Else
            cmd.Connection = conn
            cmd.CommandText = $"SELECT id FROM users where email = '{email}' and password = '{password}' limit 1;"

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim userId As Integer = reader.GetInt32(0)


                MessageBox.Show("Success Login", "Welcome")
                My.Settings.UserId = userId
                My.Settings.Save()

                conn.Close()

                Dim posts = New POSTS
                posts.Show()




                Me.Close()

            Else
                MessageBox.Show("Invalid Email or Password", "Login Error")
            End If

            reader.Close()

        End If
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        Call Connect_to_DB()


    End Sub

    Private Sub BtnSignup_Click(sender As Object, e As EventArgs) Handles BtnSignup.Click

        conn.Close()

        Dim form = New SIGNUP

        form.Show()



        Me.Close()
    End Sub
End Class
