Public Class SPLASH
    Private Sub SPLASH_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Call Connect_to_DB()

        Timer1.Start()




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If PbProgress.Value >= 100 Then

            If My.Settings.UserId = 0 Then

                conn.Close()


                Dim form = New LOGIN

                form.Show()

                Me.Close()

            Else
                conn.Close()

                Dim posts = New POSTS
                posts.Show()

                Me.Close()

            End If



        Else
            PbProgress.Value += 1
        End If


    End Sub
End Class