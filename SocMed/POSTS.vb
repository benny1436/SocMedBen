Imports MySql.Data.MySqlClient

Public Class POSTS

    ReadOnly cmd As New MySqlCommand


    Private Sub POSTS_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call Connect_to_DB()
        Call LoadPost()



    End Sub

    Private Sub BtnAddPost_Click(sender As Object, e As EventArgs) Handles BtnAddPost.Click
        Dim form = New AddPost

        form.ShowDialog()
    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        My.Settings.UserId = 0
        conn.Close()

        Dim form = New LOGIN

        form.Show()

        Me.Close()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click

        Call LoadPost()

    End Sub

    Private Sub LoadPost()
        TlpHome.Controls.Clear()

        Try
            cmd.Connection = conn

            cmd.CommandText = $"select * from posts where user_id = {My.Settings.UserId};"

            Dim reader As MySqlDataReader = cmd.ExecuteReader()



            While reader.Read()
                Dim post_id = reader.GetInt32(0)
                Dim post_title = reader.GetString(1)
                Dim post_content = reader.GetString(2)
                Dim post_owner_id = reader.GetInt32(3)

                Dim postTitle As New Label With {
                    .AutoSize = True,
                    .Dock = System.Windows.Forms.DockStyle.Top,
                    .ForeColor = System.Drawing.Color.White,
                    .Margin = New System.Windows.Forms.Padding(10),
                    .Text = post_title
                }

                Dim postContent As New Label With {
                    .AutoSize = True,
                    .Dock = System.Windows.Forms.DockStyle.Top,
                    .ForeColor = System.Drawing.Color.White,
                    .Margin = New System.Windows.Forms.Padding(10),
                    .Text = post_content
                }


                Dim postBtnComment As New Button With {
                    .BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(121, Byte), Integer)),
                    .FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    .Size = New System.Drawing.Size(75, 23),
                    .Text = "Comment",
                    .UseVisualStyleBackColor = False
                }
                postBtnComment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(121, Byte), Integer))


                Dim ChildTlp As New TableLayoutPanel With {
                    .AutoSize = True,
                    .AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink,
                    .ColumnCount = 1,
                    .Margin = New System.Windows.Forms.Padding(3, 3, 3, 20),
                    .CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
                }
                ChildTlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
                ChildTlp.Controls.Add(postTitle, 0, 0)
                ChildTlp.Controls.Add(postContent, 0, 1)
                ChildTlp.Controls.Add(postBtnComment, 0, 2)
                ChildTlp.Dock = System.Windows.Forms.DockStyle.Top
                ChildTlp.Padding = New System.Windows.Forms.Padding(3)
                ChildTlp.RowCount = 3
                ChildTlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
                ChildTlp.RowStyles.Add(New System.Windows.Forms.RowStyle())
                ChildTlp.RowStyles.Add(New System.Windows.Forms.RowStyle())

                TlpHome.Controls.Add(ChildTlp)


            End While
            reader.Close()
            conn.Close()


        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnDataManager_Click(sender As Object, e As EventArgs) Handles BtnDataManager.Click
        conn.Close()

        Dim form = New DATA_HANDLER

        form.ShowDialog()

    End Sub
End Class