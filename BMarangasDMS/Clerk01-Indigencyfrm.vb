Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Pqc.Crypto
Public Class Clerk01_Indigencyfrm
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=mdms_login_db")
    Dim int As Integer

    Private Sub Clerk01_Indigencyfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTG_load()
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim userID As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(userID) Then
            MessageBox.Show("Please enter a user ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim connectionStr As String = "Server=localhost;Database=mdms_login_db;User ID=root;Password=;"
        Dim query As String = "SELECT `bgy_id_no`,`first_name`, `middle_name`, `last_name`, `Birthdate_intxt` FROM `cert_id_issuance` WHERE `bgy_id_no`=@bgy_id_no"

        Using connection As New MySqlConnection(connectionStr)
            Try
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@bgy_id_no", userID)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            txtBgyId.Text = reader("bgy_id_no").ToString()
                            txtfname.Text = reader("first_name").ToString()
                            txtmidname.Text = reader("middle_name").ToString()
                            txtlname.Text = reader("last_name").ToString()
                            txtbdate.Text = reader("Birthdate_intxt").ToString()

                            lblfullname.Text = txtfname.Text.ToUpper() & " " & txtmidname.Text.Substring(0, 1).ToUpper() & "." & " " & txtlname.Text.ToUpper
                            Button4.Enabled = True
                        Else
                            MessageBox.Show("No user found with the given ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtfname.Clear()
                            txtmidname.Clear()
                            txtlname.Clear()
                            txtbdate.Clear()
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            DTG_load()
        End Using
    End Sub

    Private WithEvents PrintDoc As New PrintDocument()
    Private WithEvents PrintPreview As New PrintPreviewDialog()

    Dim customPaperSize As New PaperSize("Long Band Paper", 850, 1300)

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If String.IsNullOrEmpty(txtfname.Text) OrElse String.IsNullOrEmpty(txtmidname.Text) OrElse
           String.IsNullOrEmpty(txtlname.Text) OrElse String.IsNullOrEmpty(txtbdate.Text) OrElse
           String.IsNullOrEmpty(txtage.Text) OrElse String.IsNullOrEmpty(txtrequestedby.Text) OrElse
           String.IsNullOrEmpty(txtday.Text) OrElse String.IsNullOrEmpty(txtmonth.Text) Then
            MessageBox.Show("Please fill in all required fields before printing.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        PrintDoc.DefaultPageSettings.PaperSize = customPaperSize
        PrintDoc.DefaultPageSettings.Landscape = False

        PrintPreview.Document = PrintDoc
        PrintPreview.ShowDialog()
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim graphics As Graphics = e.Graphics
        Dim printArea As New RectangleF(0, 0, e.PageBounds.Width, e.PageBounds.Height)
        Dim bmp As New Bitmap(Panel1.Width, Panel1.Height)
        Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))
        graphics.DrawImage(bmp, printArea)
        e.HasMorePages = False

    End Sub

    Private Sub LoadPrintLogs()

        Dim query As String = "
            SELECT P.print_id, U.ID, P.document_name, P.printed_on, P.pages_printed, P.status, U.Position, U.Username, U.Last_name FROM print_logs P LEFT JOIN users_tb U ON P.print_id = U.ID"

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            'DataGridView1.Rows.Clear()

            While reader.Read()
                'DataGridView1.Rows.Add(reader("print_id"), reader("ID"), reader("document_name"), reader("printed_on"), reader("pages_printed"), reader("status"), reader("Position"), reader("Username"), reader("Last_name")
                ')
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnCalculateAge_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim birthDateString As String = txtbdate.Text.Trim()
        Dim dateFormats As String() = {"MM/dd/yyyy", "M/d/yyyy"}
        ' Try to parse the birthdate string into a DateTime
        Dim birthDate As DateTime
        If Not DateTime.TryParseExact(birthDateString, dateFormats, Nothing, Globalization.DateTimeStyles.None, birthDate) Then
            MessageBox.Show("Please enter a valid birthdate in one of the following formats: MM/DD/YYYY or M/d/yyyy", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim age As Integer = CalculateAge(birthDate)

        lblAge.Text = age.ToString()
        txtage.Text = "Age: " & age.ToString()
    End Sub

    Private Function CalculateAge(birthDate As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthDate.Year

        If today.Month < birthDate.Month OrElse (today.Month = birthDate.Month AndAlso today.Day < birthDate.Day) Then
            age -= 1
        End If
        Return age
    End Function

    Private Sub txtrequestedby_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrequestedby.KeyPress
        lblrequest.Text = txtrequestedby.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtrequestedby.Text = lblfullname.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim currentDate As DateTime = DateTime.Now
        Dim currentDay As Integer = currentDate.Day
        Dim currentMonth As Integer = currentDate.Month

        txtday.Text = currentDay.ToString()

        Dim monthName As String = currentDate.ToString("MMMM")
        txtmonth.Text = Char.ToUpper(monthName(0)) & monthName.Substring(1)

        lblage_.Text = txtday.Text
        lblmonth.Text = txtmonth.Text
    End Sub

    Private Sub txtrequestedby_TextChanged(sender As Object, e As EventArgs) Handles txtrequestedby.TextChanged
        lblrequest.Text = txtrequestedby.Text
    End Sub


    Private Sub txtday_TextChanged(sender As Object, e As EventArgs) Handles txtday.TextChanged
        lblage_.Text = txtday.Text
    End Sub

    Private Sub txtmonth_TextChanged(sender As Object, e As EventArgs) Handles txtmonth.TextChanged
        lblmonth.Text = txtmonth.Text
    End Sub
    Private Sub SavePanelAsImage()
        Dim panelBitmap As New Bitmap(Panel1.Width, Panel1.Height)

        Panel1.DrawToBitmap(panelBitmap, New Rectangle(0, 0, Panel1.Width, Panel1.Height))

        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.DefaultExt = "png"
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp"
            saveFileDialog.FileName = "PanelImage.png"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Dim filePath As String = saveFileDialog.FileName

                    panelBitmap.Save(filePath, ImageFormat.Png)

                    MessageBox.Show("Certificate of Idigency Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error saving image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _clear()
    End Sub

    Public Sub _clear()
        txtBgyId.Clear()
        txtfname.Clear()
        txtmidname.Clear()
        txtlname.Clear()
        txtbdate.Clear()
        txtage.Clear()
        txtrequestedby.Clear()
        txtday.Clear()
        lblfullname.ResetText()
        lblAge.ResetText()
        txtmonth.Clear()
        txtSearch.Clear()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        SavePanelAsImage()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bgyID As String = txtBgyId.Text.Trim()
        Dim Fname As String = txtfname.Text.Trim()
        Dim Mname As String = txtmidname.Text.Trim()
        Dim Lname As String = txtlname.Text.Trim()
        Dim Bdatename As String = txtbdate.Text.Trim()
        Dim Age As String = lblAge.Text.Trim()
        Dim RDay As String = txtday.Text.Trim()
        Dim RMonth As String = txtmonth.Text.Trim()
        Dim RQBy As String = txtrequestedby.Text.Trim()


        If String.IsNullOrWhiteSpace(bgyID) OrElse String.IsNullOrWhiteSpace(Fname) OrElse
       String.IsNullOrWhiteSpace(Mname) OrElse String.IsNullOrWhiteSpace(Lname) OrElse
       String.IsNullOrWhiteSpace(Bdatename) OrElse String.IsNullOrWhiteSpace(Age) OrElse
       String.IsNullOrWhiteSpace(RDay) OrElse String.IsNullOrWhiteSpace(RMonth) OrElse String.IsNullOrWhiteSpace(RQBy) Then
            MsgBox("All fields are required!", vbExclamation)
            Return
        End If

        Using con As New MySqlConnection(My.Settings.MDMSCon)
            Try
                con.Open()

                Dim cmd As New MySqlCommand("INSERT INTO `cert_indigent`(`bgy_id_no`, `First_name`, `Mid_name`, `Last_name`, `Birthdate`, `Age`, `Rested_by`, `Day`, 
                                            `Month`) VALUES (@bgy_id_no,@First_name,@Mid_name,@Last_name,@Birthdate,@Age,@Rested_by,@Day,@Month)", con)

                cmd.Parameters.AddWithValue("@bgy_id_no", bgyID)
                cmd.Parameters.AddWithValue("@First_name", Fname)
                cmd.Parameters.AddWithValue("@Mid_name", Mname)
                cmd.Parameters.AddWithValue("@Last_name", Lname)
                cmd.Parameters.AddWithValue("@Birthdate", Bdatename)
                cmd.Parameters.AddWithValue("@Age", Age)
                cmd.Parameters.AddWithValue("@Month", RDay)
                cmd.Parameters.AddWithValue("@Day", RMonth)
                cmd.Parameters.AddWithValue("@Rested_by", RQBy)

                Dim status As Integer = cmd.ExecuteNonQuery()
                If status > 0 Then
                    MsgBox("Successfully registered an account!", vbInformation)
                Else
                    MsgBox("Registration failed!", vbExclamation)
                End If
                btnprint.Enabled = True
            Catch ex As MySqlException
                MsgBox("Database error: " & ex.Message, vbExclamation)
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, vbExclamation)
            End Try
        End Using
        DTG_load()

    End Sub

    Public Sub DTG_load()

        DataGridView2.Rows.Clear()

        Try
            conn.Open()

            Dim com As New MySqlCommand("SELECT * FROM `cert_indigent`", conn)
            Dim dr1 As MySqlDataReader = com.ExecuteReader()
            While dr1.Read
                DataGridView2.Rows.Add(dr1.Item("bgy_id_no"), dr1.Item("First_name"), dr1.Item("Mid_name"), dr1.Item("Last_name"), dr1.Item("Birthdate"),
                                       dr1.Item("Age"), dr1.Item("Rested_by"), dr1.Item("Day"), dr1.Item("Month"))
            End While
            dr1.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        btnprint.Enabled = False
        DTG_load()
        _clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button5_Click(sender, e)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim searchTerm As String = TextBox1.Text.Trim().ToLower()

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.IsNewRow Then Continue For
            Dim lastName As String = row.Cells("Lastname").Value.ToString().ToLower()
            Dim idNumber As String = row.Cells("bgy_id_no").Value.ToString().ToLower()

            If lastName.Contains(searchTerm) OrElse idNumber.Contains(searchTerm) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub txtbdate_TextChanged(sender As Object, e As EventArgs) Handles txtbdate.TextChanged

    End Sub
End Class