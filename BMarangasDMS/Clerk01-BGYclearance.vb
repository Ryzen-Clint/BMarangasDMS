Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Clerk01_BGYclearance
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=mdms_login_db")
    Dim int As Integer
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bgyID As String = txtbgyID.Text.Trim()
        Dim Fname As String = txtfname.Text.Trim()
        Dim Mname As String = txtmidname.Text.Trim()
        Dim Lname As String = txtlname.Text.Trim()
        Dim address As String = txtaddress.Text.Trim()
        Dim Busname As String = TextBox1.Text.Trim()
        Dim Loc As String = TextBox2.Text.Trim()
        Dim Rdate As String = Reqdate.Text.Trim()
        Dim taxcert As String = TextBox3.Text.Trim()
        Dim issued As String = TextBox4.Text.Trim()
        Dim OR_no As String = TextBox5.Text.Trim()

        If String.IsNullOrWhiteSpace(bgyID) OrElse String.IsNullOrWhiteSpace(Fname) OrElse
       String.IsNullOrWhiteSpace(Mname) OrElse String.IsNullOrWhiteSpace(Lname) OrElse
       String.IsNullOrWhiteSpace(address) OrElse String.IsNullOrWhiteSpace(Busname) OrElse
       String.IsNullOrWhiteSpace(Loc) OrElse String.IsNullOrWhiteSpace(Rdate) OrElse String.IsNullOrWhiteSpace(taxcert) OrElse String.IsNullOrWhiteSpace(issued) OrElse String.IsNullOrWhiteSpace(OR_no) Then
            MsgBox("All fields are required!", vbExclamation)
            Return
        End If

        Dim Ceduladate As DateTime
        If Not DateTime.TryParse(Reqdate.Text, Ceduladate) Then
            MsgBox("Please enter a valid birth date in MM/DD/YYYY format.", vbExclamation)
            Reqdate.Clear()
            Return
        Else
            Ceduladate = Ceduladate.ToString("MM/dd/yyyy")
            Reqdate.Text = Ceduladate
        End If

        Dim regulate As String = If(CheckBox1.Checked, "Yes", "No")
        Dim banned As String = If(CheckBox2.Checked, "Yes", "No")
        Dim permit As String = If(CheckBox3.Checked, "Yes", "No")

        Dim query As String = "INSERT INTO `cert_bgy_clearance` (`bgy_id_no`, `First_name`, `Mid_name`, `Last_name`, `address`, `bus_name`, `bus_loc`, `req_date`,
                               `cedul_taxcert_no`, `cedul_date`, `cedul_OR_no`, `regulation_enforced`, `banned_activites`, `mayors_permt_appld`) 
                               VALUES (@bgy_id_no, @First_name, @Mid_name, @Last_name, @address, @bus_name, @bus_loc, @req_date,
                                       @cedul_taxcert_no, @cedul_date, @cedul_OR_no, @regulation_enforced, @banned_activites, @mayors_permt_appld)"

        Using con As New MySqlConnection(My.Settings.MDMSCon)
            Try
                con.Open()
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@bgy_id_no", bgyID)
                    cmd.Parameters.AddWithValue("@First_name", Fname)
                    cmd.Parameters.AddWithValue("@Mid_name", Mname)
                    cmd.Parameters.AddWithValue("@Last_name", Lname)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.Parameters.AddWithValue("@bus_name", Busname)
                    cmd.Parameters.AddWithValue("@bus_loc", Loc)
                    cmd.Parameters.AddWithValue("@req_date", Rdate)
                    cmd.Parameters.AddWithValue("@cedul_taxcert_no", taxcert)
                    cmd.Parameters.AddWithValue("@cedul_date", issued)
                    cmd.Parameters.AddWithValue("@cedul_OR_no", OR_no)
                    cmd.Parameters.AddWithValue("@regulation_enforced", regulate)
                    cmd.Parameters.AddWithValue("@banned_activites", banned)
                    cmd.Parameters.AddWithValue("@mayors_permt_appld", permit)

                    Dim status As Integer = cmd.ExecuteNonQuery()
                    If status > 0 Then
                        MsgBox("Successfully registered an account!", vbInformation)
                        btnprint.Enabled = True
                    Else
                        MsgBox("Registration failed!", vbExclamation)
                    End If
                    btnprint.Enabled = True
                End Using
            Catch ex As MySqlException
                MsgBox("Database error: " & ex.Message, vbExclamation)
            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message, vbExclamation)
            End Try

        End Using
        DTG_load()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        btnprint.Enabled = False
        DTG_load()
        Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim userID As String = TextBox6.Text.Trim()

        If String.IsNullOrEmpty(userID) Then
            MessageBox.Show("Please enter a user ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim connectionStr As String = "Server=localhost;Database=mdms_login_db;User ID=root;Password=;"
        Dim query As String = "SELECT `bgy_id_no`,`first_name`, `middle_name`, `last_name`, `address`, `cedula_certificate_no`, `cedula_date`, `cedula_or`
                                FROM `cert_id_issuance` WHERE `bgy_id_no`=@bgy_id_no"

        Using connection As New MySqlConnection(connectionStr)
            Try
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@bgy_id_no", userID)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            txtbgyID.Text = reader("bgy_id_no").ToString()
                            txtfname.Text = reader("first_name").ToString()
                            txtmidname.Text = reader("middle_name").ToString()
                            txtlname.Text = reader("last_name").ToString()
                            txtaddress.Text = reader("address").ToString()
                            TextBox3.Text = reader("cedula_certificate_no").ToString()
                            TextBox4.Text = reader("cedula_date").ToString()
                            TextBox5.Text = reader("cedula_or").ToString()

                            lbl_bus_name.Text = TextBox1.Text.ToUpper()
                            lbl_loc.Text = TextBox2.Text.ToUpper()
                            lbl_manager.Text = txtfname.Text.ToUpper() & " " & txtmidname.Text.Substring(0, 1).ToUpper() & "." & " " & txtlname.Text.ToUpper
                            lbl_address.Text = txtaddress.Text.ToUpper()
                            lbl_tax.Text = TextBox3.Text.ToUpper()
                            lbl_issued_on.Text = TextBox4.Text.ToUpper()
                            lbl_OR_No.Text = TextBox5.Text.ToUpper()
                            Button4.Enabled = True
                        Else
                            MessageBox.Show("No user found with the given ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtfname.Clear()
                            txtmidname.Clear()
                            txtlname.Clear()
                            txtaddress.Clear()
                            TextBox3.Clear()
                            TextBox4.Clear()
                            TextBox5.Clear()
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            DTG_load()
        End Using
    End Sub
    Public Sub Clear()
        txtbgyID.Clear()
        txtfname.Clear()
        txtmidname.Clear()
        txtlname.Clear()
        txtaddress.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        Reqdate.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        lbl_address.ResetText()
        lbl_bus_name.ResetText()
        lbl_date.ResetText()
        lbl_issued_on.ResetText()
        lbl_loc.ResetText()
        lbl_manager.ResetText()
        lbl_OR_No.ResetText()
        lbl_tax.ResetText()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        SavePanelAsImage()
    End Sub

    Private WithEvents PrintDoc As New PrintDocument()
    Private WithEvents PrintPreview As New PrintPreviewDialog()

    Dim customPaperSize As New PaperSize("Long Band Paper", 850, 1300)

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        If String.IsNullOrEmpty(txtbgyID.Text) OrElse String.IsNullOrEmpty(txtfname.Text) OrElse
           String.IsNullOrEmpty(txtmidname.Text) OrElse String.IsNullOrEmpty(txtlname.Text) OrElse
           String.IsNullOrEmpty(txtaddress.Text) OrElse String.IsNullOrEmpty(TextBox1.Text) OrElse
           String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrEmpty(Reqdate.Text) OrElse
           String.IsNullOrEmpty(TextBox3.Text) OrElse String.IsNullOrEmpty(TextBox4.Text) OrElse String.IsNullOrEmpty(TextBox5.Text) Then
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lbl_bus_name.Text = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        lbl_loc.Text = TextBox2.Text
    End Sub

    Private Sub Reqdate_TextChanged(sender As Object, e As EventArgs) Handles Reqdate.TextChanged
        lbl_date.Text = Reqdate.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim currentDate As DateTime = DateTime.Now
        Reqdate.Text = currentDate.ToString("MM/dd/yyyy")
    End Sub

    Private Sub Clerk01_BGYclearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTG_load()
    End Sub

    Public Sub DTG_load()
        DataGridView2.Rows.Clear()

        Try
            conn.Open()

            Dim com As New MySqlCommand("SELECT * FROM `cert_bgy_clearance`", conn)
            Dim dr1 As MySqlDataReader = com.ExecuteReader()
            While dr1.Read
                DataGridView2.Rows.Add(dr1.Item("bgy_id_no"), dr1.Item("bus_name"), dr1.Item("bus_loc"), dr1.Item("First_name"), dr1.Item("Mid_name"),
                                       dr1.Item("Last_name"), dr1.Item("address"), dr1.Item("regulation_enforced"), dr1.Item("banned_activites"),
                                       dr1.Item("mayors_permt_appld"), dr1.Item("cedul_taxcert_no"), dr1.Item("cedul_date"), dr1.Item("cedul_OR_no"), dr1.Item("req_date"))
            End While
            dr1.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.IsNewRow Then Continue For
            Dim lastName As String = row.Cells("last_name").Value.ToString().ToLower()
            Dim Cedula As String = row.Cells("bus_name").Value.ToString().ToLower()
            Dim idNumber As String = row.Cells("bgy_id_no").Value.ToString().ToLower()

            If lastName.Contains(searchTerm) OrElse idNumber.Contains(searchTerm) OrElse Cedula.Contains(searchTerm) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Searchbtn_Click(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clear()
    End Sub
End Class