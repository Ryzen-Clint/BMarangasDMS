Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class AdminForm
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=mdms_login_db")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users_tb", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("First_name"), dr.Item("Mid_name"), dr.Item("Last_name"), dr.Item("Contact_number"), dr.Item("Position"), dr.Item("ID_number"), dr.Item("Gender"), dr.Item("Username"), dr.Item("Password"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        originalBounds = Me.Bounds
        Me.Bounds = originalBounds
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Normal
        'Label12.Visible = True
        'Label4.Visible = False
    End Sub

    Private isFullScreen As Boolean = True
    Private originalBounds As Rectangle

    Public Sub clear_()
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

    Private Sub closelbl_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        isFullScreen = False
        'Label12.Visible = False
        'Label4.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        fnametxt.Text = DataGridView1.CurrentRow.Cells(0).Value
        mnametxt.Text = DataGridView1.CurrentRow.Cells(1).Value
        lnametx.Text = DataGridView1.CurrentRow.Cells(2).Value
        contacttxt.Text = DataGridView1.CurrentRow.Cells(3).Value
        positiontxt.Text = DataGridView1.CurrentRow.Cells(4).Value
        Id_numbertxt.Text = DataGridView1.CurrentRow.Cells(5).Value
        gendertxt.Text = DataGridView1.CurrentRow.Cells(6).Value
        usernametxt.Text = DataGridView1.CurrentRow.Cells(7).Value
        passtext.Text = DataGridView1.CurrentRow.Cells(8).Value

        Button4.Enabled = False
        printbtn2.Enabled = False
        adduserbtn.Enabled = False
        editbtn.Enabled = True
        delbtn.Enabled = True
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

    Public Sub edit()
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

        If String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(conpassword) Then
            MsgBox("Please fill in both password fields.", vbExclamation)
            passtext.Clear()
            confpasstxt.Clear()
            Return
        ElseIf password <> conpassword Then
            MsgBox("Passwords do not match.", vbExclamation)
            passtext.Clear()
            confpasstxt.Clear()
            Return
        Else
            MsgBox("Password confirmed successfully!", vbInformation)
        End If
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `users_tb` SET `First_name`=@First_name,`Mid_name`=@Mid_name,`Contact_number`=@Contact_number,`Position`=@Position,`Gender`=@Gender,`Username`=@Username,`Password`=@Password,`Last_name`=@Last_name WHERE `ID_number`=@ID_number", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ID_number", Id_numbertxt.Text)
            cmd.Parameters.AddWithValue("@First_name", fnametxt.Text)
            cmd.Parameters.AddWithValue("@Last_name", lnametx.Text)
            cmd.Parameters.AddWithValue("@Mid_name", mnametxt.Text)
            cmd.Parameters.AddWithValue("@Contact_number", contacttxt.Text)
            cmd.Parameters.AddWithValue("@Username", usernametxt.Text)
            cmd.Parameters.AddWithValue("@Password", passtext.Text)
            cmd.Parameters.AddWithValue("@position", positiontxt.Text)
            cmd.Parameters.AddWithValue("@Gender", gendertxt.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Update Success", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            clear_()
            DGV_load()
            printbtn2.Enabled = True
            editbtn.Enabled = False
            delbtn.Enabled = False
            adduserbtn.Enabled = True
            Button4.Enabled = True
        End Try

    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        edit()
        Button4.Enabled = True
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
        searchtxt.Clear()
        LoadCombinedData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DGV_load()

        clear_()
        Button4.Enabled = True
        printbtn2.Enabled = True
        adduserbtn.Enabled = True
        usernametxt.ReadOnly = False
        editbtn.Enabled = False
        delbtn.Enabled = False
    End Sub


    Private isPasswordVisible As Boolean = False
    Private Sub seebtn_Click(sender As Object, e As EventArgs) Handles seebtn.Click
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

    Private Sub adduserbtn_Click(sender As Object, e As EventArgs) Handles adduserbtn.Click
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
            If String.IsNullOrWhiteSpace(firstname) OrElse String.IsNullOrWhiteSpace(lastname) OrElse
                String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) OrElse
                String.IsNullOrWhiteSpace(contactno) OrElse String.IsNullOrWhiteSpace(position) OrElse
                String.IsNullOrWhiteSpace(gender) OrElse String.IsNullOrWhiteSpace(IDno) Then
                MsgBox("All fields are required!", vbExclamation)
                Return
            End If

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
        DGV_load()
        clear_()
    End Sub

    Public Sub delete()
        If MsgBox("Are You Sure You Want To Delete This Data?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `users_tb` WHERE `ID_number`=@ID_number", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID_number", Id_numbertxt.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Successfully Deleted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Deletion Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            clear_()
            DGV_load()
        Else
            Return
        End If
    End Sub

    Private Sub delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        delete()
        DGV_load()
        clear_()
        Button4.Enabled = True
        printbtn2.Enabled = True
        adduserbtn.Enabled = True
        usernametxt.ReadOnly = False
        editbtn.Enabled = False
        delbtn.Enabled = False
    End Sub

    Public Sub LogHistory()
        DataGridView2.Rows.Clear() ' Clear existing rows

        Try
            conn.Open()
            ' Adjust the query to select appropriate fields
            Dim cmd As New MySqlCommand("SELECT ID_number, Username, Position, login_time, ip_address, Contact_number, Last_name, First_name FROM users_tb", conn)
            dr = cmd.ExecuteReader

            While dr.Read()
                ' Add data to DataGridView rows
                DataGridView2.Rows.Add(dr("ID_number"), dr("Username"), dr("Position"), dr("login_time"), dr("ip_address"), dr("Contact_number"), dr("Last_name"), dr("First_name"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadCombinedData()
        Dim query As String = "
            SELECT u.ID, u.ID_number, u.First_name, u.Last_name, u.Contact_number, u.Position, u.Gender, u.Username, l.login_time, l.ip_address FROM users_tb u LEFT JOIN login_history l ON u.ID = l.user_id"

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            DataGridView2.Rows.Clear()

            While reader.Read()
                DataGridView2.Rows.Add(reader("ID"), reader("ID_number"), reader("First_name"), reader("Last_name"), reader("Contact_number"), reader("Position"), reader("Gender"), reader("Username"), reader("login_time"), reader("ip_address")
                )
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadCombinedData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private currentPage As Integer = 1

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printFont As New Font("Arial", 10)
        Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
        Dim footerFont As New Font("Arial", 8)
        Dim title As String = "Login History"
        Dim currentDate As String = DateTime.Now.ToString("MMMM dd, yyyy")
        Dim xPos As Single = e.MarginBounds.Left
        Dim yPos As Single = e.MarginBounds.Top
        Dim rowHeight As Integer = 20
        Dim columnCount As Integer = DataGridView2.Columns.Count
        Dim pageNumber As String = "Page " & currentPage.ToString()

        e.Graphics.DrawString(title, headerFont, Brushes.Black, xPos, yPos)
        yPos += 30

        e.Graphics.DrawString("Printed Date: " & currentDate, printFont, Brushes.Black, xPos, yPos)
        yPos += 20

        For i As Integer = 0 To columnCount - 1
            e.Graphics.DrawString(DataGridView2.Columns(i).HeaderText, printFont, Brushes.Black, xPos, yPos)
            xPos += DataGridView2.Columns(i).Width
        Next

        yPos += rowHeight
        xPos = e.MarginBounds.Left

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.IsNewRow Then Continue For


            If yPos + rowHeight > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                currentPage += 1
                Return
            End If

            For i As Integer = 0 To columnCount - 1
                e.Graphics.DrawString(row.Cells(i).Value.ToString(), printFont, Brushes.Black, xPos, yPos)
                xPos += DataGridView2.Columns(i).Width
            Next

            yPos += rowHeight
            xPos = e.MarginBounds.Left
        Next

        e.Graphics.DrawString(pageNumber, footerFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString(pageNumber, footerFont).Width, e.MarginBounds.Bottom - footerFont.GetHeight(e.Graphics) - 10)

        If Not e.HasMorePages Then
            currentPage = 1
        End If
    End Sub

    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.DefaultPageSettings.Margins = New Printing.Margins(50, 50, 50, 50)

        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = PrintDocument1
        printPreviewDialog.ShowDialog()
    End Sub

    Private currentPage2 As Integer = 1

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim printFont As New Font("Arial", 10)
        Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
        Dim footerFont As New Font("Arial", 8)
        Dim title As String = "User's Account Information"
        Dim currentDate As String = DateTime.Now.ToString("MMMM dd, yyyy")
        Dim xPos As Single = e.MarginBounds.Left
        Dim yPos As Single = e.MarginBounds.Top
        Dim rowHeight As Integer = 20
        Dim columnCount As Integer = DataGridView1.Columns.Count
        Dim pageNumber As String = "Page " & currentPage2.ToString()

        ' Print Title
        e.Graphics.DrawString(title, headerFont, Brushes.Black, xPos, yPos)
        yPos += 30

        ' Print Current Date
        e.Graphics.DrawString("Printed Date: " & currentDate, printFont, Brushes.Black, xPos, yPos)
        yPos += 20

        ' Print header
        For i As Integer = 0 To columnCount - 1
            e.Graphics.DrawString(DataGridView1.Columns(i).HeaderText, printFont, Brushes.Black, xPos, yPos)
            xPos += DataGridView1.Columns(i).Width
        Next

        yPos += rowHeight
        xPos = e.MarginBounds.Left

        ' Print rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For
            For i As Integer = 0 To columnCount - 1
                e.Graphics.DrawString(row.Cells(i).Value.ToString(), printFont, Brushes.Black, xPos, yPos)
                xPos += DataGridView1.Columns(i).Width
            Next
            yPos += rowHeight
            xPos = e.MarginBounds.Left
        Next

        ' Print Footer
        e.Graphics.DrawString(pageNumber, footerFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString(pageNumber, footerFont).Width, e.MarginBounds.Bottom - footerFont.GetHeight(e.Graphics) - 10)

        ' Handle multiple pages
        If yPos > e.MarginBounds.Bottom Then
            e.HasMorePages = True
            currentPage2 += 1
        Else
            e.HasMorePages = False
            currentPage2 = 1
        End If
    End Sub

    Private Sub printbtn2_Click(sender As Object, e As EventArgs) Handles printbtn2.Click
        PrintDocument2.DefaultPageSettings.Landscape = True
        PrintDocument2.DefaultPageSettings.Margins = New Printing.Margins(50, 50, 50, 50)

        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = PrintDocument2
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub FilterButton_Click(sender As Object, e As EventArgs)
        Dim time As New MySqlCommand("SELECT * FROM login_history WHERE login_time BETWEEN @date1 AND @date2 ORDER BY login_time", conn)
        time.Parameters.AddWithValue("date1", DateTimePicker1.Value)
        time.Parameters.AddWithValue("date2", DateTimePicker2.Value)
        Dim dtime As New MySqlDataAdapter(time)
        Dim dt As New DataTable
        dt.Clear()
        dtime.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub searchtxt_TextChanged(sender As Object, e As EventArgs) Handles searchtxt.TextChanged
        searchbtn_Click(sender, e)
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        Dim searchTerm As String = searchtxt.Text.Trim().ToLower()

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For
            Dim lastName As String = row.Cells("PosDGV").Value.ToString().ToLower()
            Dim idNumber As String = row.Cells("bgy_id_no").Value.ToString().ToLower()

            If lastName.Contains(searchTerm) OrElse idNumber.Contains(searchTerm) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub

    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged
        Button1_Click(sender, e)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchTermDGV2 As String = searchtxt.Text.Trim().ToLower()

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.IsNewRow Then Continue For
            Dim lastNameDGV2 As String = row.Cells("lastnameDGV2").Value.ToString().ToLower()
            Dim positionDGV2 As String = row.Cells("_position").Value.ToString().ToLower()

            If lastNameDGV2.Contains(searchTermDGV2) OrElse positionDGV2.Contains(searchTermDGV2) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim newID As String = GenerateNewID()
        Id_numbertxt.Text = newID
        Button4.Enabled = False
    End Sub

    Private Sub usernametxt_TextChanged(sender As Object, e As EventArgs) Handles usernametxt.TextChanged

    End Sub
End Class