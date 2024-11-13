Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Loginasadmin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm.Show()
        LoginForm.Enabled = True
        passtext.Clear()
        usernametxt.Clear()
        Me.Hide()
    End Sub

    Private isPasswordVisible As Boolean = False
    Private Sub seebtn_Click(sender As Object, e As EventArgs) Handles seebtn.Click
        If isPasswordVisible Then
            passtext.UseSystemPasswordChar = True
            seebtn.Text = "Show Password"
        Else
            passtext.UseSystemPasswordChar = False
            seebtn.Text = "Hide Password"
        End If

        isPasswordVisible = Not isPasswordVisible
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = usernametxt.Text.Trim()
        Dim password As String = passtext.Text.Trim()
        Dim Position As String = positiontxt.Text.Trim()

        For Each item As Control In Me.Controls
            If (TypeOf item Is TextBox) Then

                If (item.Text = "") Then
                    MsgBox("Please Input Username and Password", vbInformation)
                    Return

                Else

                    Dim con_ = New MySqlConnection(My.Settings.MDMSCon)

                    Try
                        con_.Open()
                        Dim adapter = New MySqlDataAdapter("SELECT * FROM `users_tb` WHERE Username=@Username AND Password=@Password AND Position=@Position", con_)

                        With adapter.SelectCommand.Parameters
                            .AddWithValue("@Username", username)
                            .AddWithValue("@Password", password)
                            .AddWithValue("@Position", Position)
                        End With

                        Dim table = New DataTable()

                        adapter.Fill(table)

                        If (table.Rows.Count > 0) Then
                            MsgBox("Log In Successfully!", vbInformation)

                            Me.Hide()
                            UserRegisterFrm.Show()
                            LoginForm.Enabled = True
                            LoginForm.Hide()
                            passtext.Clear()
                            usernametxt.Clear()
                        Else
                            MsgBox("Incorrect Username, or Password", vbCritical)
                            usernametxt.Clear()
                            passtext.Clear()
                        End If

                    Catch ex As Exception
                        MsgBox(ex.ToString())

                    Finally
                        con_.Dispose()
                        con_.Close()

                    End Try
                    Exit For
                End If
            End If
        Next
    End Sub
End Class