Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Net.Mime.MediaTypeNames
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class UserRegisterFrm
    Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=mdms_login_db")
    Dim Int As Integer
    Dim DataR As MySqlDataReader

    Private Sub fnametxt_Enter(sender As Object, e As EventArgs) Handles fnametxt.Enter
        If fnametxt.Text = "First Name" Then
            fnametxt.Text = ""
            fnametxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub fnametxt_Leave(sender As Object, e As EventArgs) Handles fnametxt.Leave
        If fnametxt.Text = "" Then
            fnametxt.Text = "First Name"
            fnametxt.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub lnametx_Enter(sender As Object, e As EventArgs) Handles lnametx.Enter
        If lnametx.Text = "Last Name" Then
            lnametx.Text = ""
            lnametx.ForeColor = Color.Black
        End If
    End Sub

    Private Sub lnametx_Leave(sender As Object, e As EventArgs) Handles lnametx.Leave
        If lnametx.Text = "" Then
            lnametx.Text = "Last Name"
            lnametx.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub mnametxt_Enter(sender As Object, e As EventArgs) Handles mnametxt.Enter
        If mnametxt.Text = "Middle Name" Then
            mnametxt.Text = ""
            mnametxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub mnametxt_Leave(sender As Object, e As EventArgs) Handles mnametxt.Leave
        If mnametxt.Text = "" Then
            mnametxt.Text = "Middle Name"
            mnametxt.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub contacttxt_Enter(sender As Object, e As EventArgs) Handles contacttxt.Enter
        If contacttxt.Text = "09##-###-####" Then
            contacttxt.Text = ""
            contacttxt.ForeColor = Color.Black

        End If
    End Sub

    Private Sub contacttxt_Leave(sender As Object, e As EventArgs) Handles contacttxt.Leave
        If contacttxt.Text = "" Then
            contacttxt.Text = "09##-###-####"
            contacttxt.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub usernametxt_Enter_1(sender As Object, e As EventArgs) Handles usernametxt.Enter

        If usernametxt.Text = "User_Name" Then
            usernametxt.Text = ""
            usernametxt.ForeColor = Color.Black
        End If

    End Sub

    Private Sub usernametxt_Leave_1(sender As Object, e As EventArgs) Handles usernametxt.Leave
        If usernametxt.Text = "" Then
            usernametxt.Text = "User_Name"
            usernametxt.ForeColor = Color.Silver
        End If
    End Sub

    Public Sub clear()
        fnametxt.Clear()
        mnametxt.Clear()
        lnametx.Clear()
        contacttxt.Clear()
        positiontxt.SelectedIndex = -1
        Id_numbertxt.Clear()
        gendertxt.SelectedIndex = -1
        usernametxt.Clear()
        passtext.Clear()
        confpasstxt.Clear()
    End Sub

    Private Sub clearbt_Click(sender As Object, e As EventArgs) Handles clearbt.Click
        clear()
    End Sub

    Private Sub Id_numbertxt_Enter(sender As Object, e As EventArgs)
        If Id_numbertxt.Text = "ID0000" Then
            Id_numbertxt.Text = ""
            Id_numbertxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Id_numbertxt_Leave(sender As Object, e As EventArgs)
        If Id_numbertxt.Text = "" Then
            Id_numbertxt.Text = "ID0000"
            Id_numbertxt.ForeColor = Color.Silver
        End If
    End Sub

    Private Function UsernameExists(username As String) As Boolean
        Dim exists As Boolean = False
        If String.IsNullOrEmpty(My.Settings.MDMSCon) Then
            MsgBox("Connection string is not set.", vbCritical)
            Return False
        End If
        Using con As New MySqlConnection(My.Settings.MDMSCon)
            Try
                con.Open()
                Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM users_tb WHERE Username = @Username", con)
                cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                exists = (count > 0)
            Catch ex As MySqlException
                MsgBox("MySQL Error: " & ex.Message, vbExclamation)
            Catch ex As Exception
                MsgBox("Error checking username: " & ex.Message, vbExclamation)
            End Try
        End Using

        Return exists
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstname As String = fnametxt.Text.Trim()
        Dim midname As String = mnametxt.Text.Trim()
        Dim lastname As String = lnametx.Text.Trim()
        Dim contactno As String = contacttxt.Text.Trim()
        Dim position As String = positiontxt.Text.Trim()
        Dim gender As String = gendertxt.Text.Trim()
        Dim username As String = usernametxt.Text.Trim()
        Dim password As String = passtext.Text.Trim()
        Dim conpassword As String = confpasstxt.Text.Trim()
        Dim IDno As String = Id_numbertxt.Text.Trim()

        Using con As New MySqlConnection(My.Settings.MDMSCon)
            For Each control As Control In Me.Controls
                If TypeOf control Is TextBox Then
                    If String.IsNullOrWhiteSpace(control.Text) Then
                        MsgBox("All fields are required!", vbExclamation)
                        Return
                    End If
                End If
            Next
            If UsernameExists(username) Then
                MsgBox("Username already exists. Please choose another one.", vbExclamation)
                usernametxt.Clear()
                usernametxt.Focus()
                passtext.Clear()
                confpasstxt.Clear()
                Return
            End If
            If String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(conpassword) Then
                MsgBox("Please fill in both password fields.", vbExclamation)
                Return
            ElseIf password <> conpassword Then
                MsgBox("Passwords do not match.", vbExclamation)
                passtext.Clear()
                confpasstxt.Clear()
                passtext.Focus()
                Return
            Else
                MsgBox("Password confirmed successfully!", vbInformation)
            End If
            Try
                con.Open()

                Dim cmd As New MySqlCommand("INSERT INTO `users_tb` (`First_name`, `Mid_name`, `Contact_number`, `Position`, `Gender`, `Username`, `Password`, `Last_name`, `ID_number`, `Confirm_password`) VALUES (@First_name, @Mid_name, @Contact_number, @Position, @Gender, @Username, @Password, @Last_name, @ID_number, @Confirm_password)", con)

                cmd.Parameters.AddWithValue("@First_name", fnametxt.Text)
                cmd.Parameters.AddWithValue("@Last_name", lnametx.Text)
                cmd.Parameters.AddWithValue("@Mid_name", mnametxt.Text)
                cmd.Parameters.AddWithValue("@Contact_number", contacttxt.Text)
                cmd.Parameters.AddWithValue("@Username", usernametxt.Text)
                cmd.Parameters.AddWithValue("@Position", positiontxt.Text)
                cmd.Parameters.AddWithValue("@Password", passtext.Text)
                cmd.Parameters.AddWithValue("@Gender", gendertxt.Text)
                cmd.Parameters.AddWithValue("@ID_number", Id_numbertxt.Text)
                cmd.Parameters.AddWithValue("@Confirm_password", confpasstxt.Text)

                Dim status As Integer = cmd.ExecuteNonQuery()

                If status > 0 Then
                    MsgBox("Successfully registered an account!", vbInformation)
                Else
                    MsgBox("Registration failed!", vbExclamation)
                End If

            Catch ex As MySqlException
                MsgBox("Database error: " & ex.Message, vbExclamation)
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, vbExclamation)
            End Try

        End Using

        clear()


    End Sub

    Private isPasswordVisible As Boolean = False
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles seebtn.Click
        If isPasswordVisible Then
            passtext.UseSystemPasswordChar = True
            confpasstxt.UseSystemPasswordChar = True
            seebtn.Text = "Show Password"
        Else
            passtext.UseSystemPasswordChar = False
            confpasstxt.UseSystemPasswordChar = False
            seebtn.Text = "Hide Password"
        End If

        isPasswordVisible = Not isPasswordVisible
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm.Show()
        clear()
        Me.Hide()
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        LoginForm.Show()
        Me.Hide()
        clear()
    End Sub

    Private Sub positiontxt_Leave(sender As Object, e As EventArgs) Handles positiontxt.Leave
        If positiontxt.Text = "" Then
            positiontxt.Text = "Admin"
            positiontxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub gendertxt_Leave_1(sender As Object, e As EventArgs) Handles gendertxt.Leave
        If gendertxt.Text = "" Then
            gendertxt.Text = "Male"
            gendertxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub UserRegisterFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Id_numbertxt_TextChanged(sender As Object, e As EventArgs) Handles Id_numbertxt.TextChanged

    End Sub
    Private Function GenerateNewID() As String
        Dim newID As Integer = 0
        Dim connStr As String = "Server=localhost;Database=mdms_login_db;User ID=root;Password=;"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT MAX(ID_number) FROM users_tb", conn)
                Dim result = cmd.ExecuteScalar()

                If result IsNot DBNull.Value Then
                    newID = Convert.ToInt32(result) + 1
                Else
                    newID = 1
                End If
            Catch ex As Exception
                MessageBox.Show("Error generating ID: " & ex.Message)

            End Try
        End Using

        Return newID.ToString("D6")

    End Function

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim newID As String = GenerateNewID()
        Id_numbertxt.Text = newID

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub usernametxt_TextChanged(sender As Object, e As EventArgs) Handles usernametxt.TextChanged

    End Sub
End Class