'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx


Public Class LoginForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = usernametxt.Text.Trim()
        Dim password As String = passtext.Text.Trim()
        Dim position As String = txtpos.Text

        ' Check for empty fields
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MsgBox("Please Input Username and Password", vbInformation)
            Return
        End If

        Dim con_ = New MySqlConnection(My.Settings.MDMSCon)

        Try
            con_.Open()
            Dim adapter = New MySqlDataAdapter("SELECT * FROM `users_tb` WHERE Position=@Position AND Username=@Username AND Password=@Password", con_)

            With adapter.SelectCommand.Parameters
                .AddWithValue("@Position", position)
                .AddWithValue("@Username", username)
                .AddWithValue("@Password", password)

            End With

            Dim table = New DataTable()
            adapter.Fill(table)

            If (table.Rows.Count > 0) Then


                Dim userId As Integer = Convert.ToInt32(table.Rows(0)("id"))
                Dim position_ As String = table.Rows(0)("Position").ToString()

                RecordLoginHistory(con_, userId)

                Dim dashboardForm As New dashboard()
                dashboardForm.SetCurrentUser(username, position_)

                Dim clerk01frm As New Clerk01frm()
                clerk01frm.SetCurrentUser1(username, position_)

                If position = "Admin" Then
                    MsgBox("Log In As Administrator", vbInformation)
                    dashboardForm.Show()
                ElseIf position = "Secretary" Then
                    MsgBox("Log In As Secretary", vbInformation)
                    dashboardForm.Show()
                ElseIf position = "Clerk 01" Then
                    MsgBox("Log In As Clerk 01", vbInformation)
                    Clerk01frm.Show()
                ElseIf position = "Clerk 02" Then
                    MsgBox("Log In As Clerk 02", vbInformation)
                    Clerk02frm.Show()
                ElseIf position = "Clerk 03" Then
                    MsgBox("Log In As Clerk 03", vbInformation)
                    Clerk03frm.Show()
                ElseIf position = "Clerk 04" Then
                    MsgBox("Log In As Clerk 04", vbInformation)
                    Clerk04frm.Show()
                End If


                usernametxt.Clear()
                passtext.Clear()
                Me.hide()

            Else
                MsgBox("Incorrect Username or Password", vbCritical)
                usernametxt.Clear()
                passtext.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con_.Dispose()
            con_.Close()
        End Try
    End Sub

    Private Sub RecordLoginHistory(con_ As MySqlConnection, userId As Integer)
        Dim loginHistoryQuery As String = "INSERT INTO login_history (user_id, login_time, ip_address) VALUES (@user_id, @login_time, @ip_address)"

        Using cmd As New MySqlCommand(loginHistoryQuery, con_)
            cmd.Parameters.AddWithValue("@user_id", userId)
            cmd.Parameters.AddWithValue("@login_time", DateTime.Now)
            cmd.Parameters.AddWithValue("@ip_address", GetLocalIPAddress())
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Function GetLocalIPAddress() As String
        Dim host As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
        For Each ip As System.Net.IPAddress In host.AddressList
            If ip.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                Return ip.ToString()
            End If
        Next
        Return "127.0.0.1"
    End Function

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub clearbt_Click(sender As Object, e As EventArgs) Handles clearbt.Click
        usernametxt.Clear()
        passtext.Clear()
    End Sub

    Private Sub createlbl_Click(sender As Object, e As EventArgs) Handles createlbl.Click
        Loginasadmin.Show()
        Me.Enabled = False
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class