Imports Google.Protobuf.Reflection
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports Org.BouncyCastle.Pqc.Crypto
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Clerk01_residencyfrm
    Private imageBytes As Byte() = Nothing
    Dim int As Integer
    Dim connStr As New MySqlConnection("Server=localhost;Database=mdms_login_db;User ID=root;Password=;")
    Dim anIntArray As Integer() = New Integer() {}

    Private Function ResizeImage(originalImage As Image, newWidth As Integer, newHeight As Integer) As Image
        Dim resizedImage As New Bitmap(newWidth, newHeight)
        Using g As Graphics = Graphics.FromImage(resizedImage)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(originalImage, 0, 0, newWidth, newHeight)
        End Using
        Return resizedImage
    End Function

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg"

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim filePath As String = openFileDialog.FileName

            Dim originalImage As Image = Image.FromFile(filePath)
            Dim resizedImage As Image = ResizeImage(originalImage, 300, 300)
            picImage.Image = resizedImage

            Using ms As New MemoryStream()
                resizedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                imageBytes = ms.ToArray()
            End Using

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        DTG_load()
        Transtypetxt.SelectedIndex = 0


    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtBirthDate_Enter(sender As Object, e As EventArgs) Handles txtBirthDate.Enter
        If txtBirthDate.Text = "MM/DD/YYYY" Then
            txtBirthDate.Text = ""
            txtBirthDate.ForeColor = Color.Black
        End If
    End Sub

    Public Sub Clear_()
        bgyIDtxt.Clear()
        Firstnametxt4.Clear()
        midnametxt.Clear()
        Lstnametx.Clear()
        gendertxt.SelectedIndex = -1
        txtBirthDate.Clear()
        Addtxt.Clear()
        ConNotxt.Clear()
        Citizntxt.Clear()
        PlaceBDaytxt.Clear()
        Civlstattxt.SelectedIndex = -1
        Tintxt.Clear()
        picImage.ImageLocation = String.Empty
        picImage.Image = Nothing
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim idno As String = bgyIDtxt.Text.Trim()
        Dim fname As String = Firstnametxt4.Text.Trim()
        Dim mname As String = midnametxt.Text.Trim()
        Dim lname As String = Lstnametx.Text.Trim()
        Dim address As String = Addtxt.Text.Trim()
        Dim contact As String = ConNotxt.Text.Trim()
        Dim bday As String = txtBirthDate.Text.Trim()
        Dim bdayplace As String = PlaceBDaytxt.Text.Trim()
        Dim citizen As String = Citizntxt.Text.Trim()
        Dim tin As String = Tintxt.Text.Trim()
        Dim trans As String = Transtypetxt.Text.Trim()
        Dim cvlstat As String = Civlstattxt.Text.Trim()
        Dim gender As String = gendertxt.Text.Trim()

        If String.IsNullOrWhiteSpace(idno) OrElse String.IsNullOrWhiteSpace(fname) OrElse
       String.IsNullOrWhiteSpace(mname) OrElse String.IsNullOrWhiteSpace(lname) OrElse
       String.IsNullOrWhiteSpace(address) OrElse String.IsNullOrWhiteSpace(contact) OrElse
       String.IsNullOrWhiteSpace(bday) OrElse String.IsNullOrWhiteSpace(bdayplace) OrElse
       String.IsNullOrWhiteSpace(citizen) OrElse
       String.IsNullOrWhiteSpace(trans) OrElse String.IsNullOrWhiteSpace(cvlstat) OrElse
       String.IsNullOrWhiteSpace(gender) Then
            MsgBox("All fields are required!", vbExclamation)
            Return
        End If

        Dim connStr As String = "Server=localhost;Database=mdms_login_db;User ID=root;Password=;"
        Dim inputDate As String = txtBirthDate.Text

        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Console.WriteLine("Connection successful!")

                Dim birthDate As DateTime
                If Not DateTime.TryParse(txtBirthDate.Text, birthDate) Then
                    MsgBox("Please enter a valid birth date in MM/DD/YYYY format.", vbExclamation)
                    txtBirthDate.Clear()
                    Return
                Else
                    birthDate = birthDate.ToString("MM/dd/yyyy")
                    txtBirthDate.Text = birthDate
                End If

                Dim imageBytes As Byte() = Nothing
                If picImage.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        picImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        imageBytes = ms.ToArray()
                    End Using
                Else
                    MsgBox("Image Format Required is JPEG!", vbExclamation)
                    Return
                End If

                Dim cmd As New MySqlCommand("INSERT INTO cert_id_issuance (bgy_id_no, first_name, middle_name, last_name, gender, Birthdate_intxt, address, contact_number, 
                                            citizenship, place_birth, civil_status, tin_no, image, type_of_trans) 
                                            VALUES (@bgy_id_no, @first_name, @middle_name, @last_name, @gender, @Birthdate_intxt, @address, 
                                            @contact_number, @citizenship, @place_birth, @civil_status, @tin_no, @image, @type_of_trans)", conn)

                cmd.Parameters.AddWithValue("@bgy_id_no", bgyIDtxt.Text)
                cmd.Parameters.AddWithValue("@first_name", Firstnametxt4.Text)
                cmd.Parameters.AddWithValue("@middle_name", midnametxt.Text)
                cmd.Parameters.AddWithValue("@last_name", Lstnametx.Text)
                cmd.Parameters.AddWithValue("@gender", gendertxt.Text)
                cmd.Parameters.AddWithValue("@Birthdate_intxt", txtBirthDate.Text)
                cmd.Parameters.AddWithValue("@address", Addtxt.Text)
                cmd.Parameters.AddWithValue("@contact_number", ConNotxt.Text)
                cmd.Parameters.AddWithValue("@citizenship", Citizntxt.Text)
                cmd.Parameters.AddWithValue("@place_birth", PlaceBDaytxt.Text)
                cmd.Parameters.AddWithValue("@civil_status", Civlstattxt.Text)
                cmd.Parameters.AddWithValue("@tin_no", Tintxt.Text)
                cmd.Parameters.AddWithValue("@type_of_trans", Transtypetxt.Text)
                cmd.Parameters.AddWithValue("@image", imageBytes)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                MsgBox("Registration Successful", vbOK)

                Clear_()
                lblStatus.ResetText()
            Catch ex As Exception
                MsgBox("ID Picture is Required!", vbExclamation)
            Finally
                conn.Close()
            End Try
        End Using
        DTG_load()
        Button2.Enabled = True
        Editbtn.Enabled = True
    End Sub


    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub printbtn2_Click(sender As Object, e As EventArgs) Handles printbtn2.Click
        Clear_()
        Button2.Enabled = True
        txtSearch.Clear()
    End Sub

    Private Sub Delbtn_Click(sender As Object, e As EventArgs) Handles Delbtn.Click
        If MsgBox("Are You Sure You Want To Delete This Data?", MsgBoxStyle.Question + vbYesNo) = vbYes Then

            Try
                connStr.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `cert_id_issuance` WHERE `bgy_id_no`=@bgy_id_no", connStr)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@bgy_id_no", bgyIDtxt.Text)
                int = cmd.ExecuteNonQuery
                If int > 0 Then
                    MessageBox.Show("Record Successfully Deleted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Deletion Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connStr.Close()
            End Try


        Else
            Return
        End If

        DTG_load()
        Clear_()
        Delbtn.Enabled = False
        Editbtn.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Function GenerateNewID() As String
        Dim newID As Integer = 0
        Dim connStr As String = "Server=localhost;Database=mdms_login_db;User ID=root;Password=;"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT MAX(bgy_id_no) FROM cert_id_issuance", conn)
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

        Return newID.ToString("D8")

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newID As String = GenerateNewID()
        Editbtn.Enabled = False
        bgyIDtxt.Text = newID
        Button2.Enabled = False
    End Sub

    Private Sub Transtypetxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Transtypetxt.SelectedIndexChanged

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For
            Dim lastName As String = row.Cells("Lastname_res").Value.ToString().ToLower()
            Dim idNumber As String = row.Cells("Bgyid_res").Value.ToString().ToLower()

            If lastName.Contains(searchTerm) OrElse idNumber.Contains(searchTerm) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next

    End Sub


    Public Sub edit_new()
        Dim bgyID As String = bgyIDtxt.Text.Trim()
        Dim FirstN As String = Firstnametxt4.Text.Trim()
        Dim MidN As String = midnametxt.Text.Trim()
        Dim LastN As String = Lstnametx.Text.Trim()
        Dim Gend As String = gendertxt.Text.Trim()
        Dim BDay As String = txtBirthDate.Text.Trim()
        Dim Address As String = Addtxt.Text.Trim()
        Dim ContN As String = ConNotxt.Text.Trim()
        Dim Citi As String = Citizntxt.Text.Trim()
        Dim Bpace As String = PlaceBDaytxt.Text.Trim()
        Dim CivilS As String = Civlstattxt.Text.Trim()
        Dim TIN As String = Tintxt.Text.Trim()

        Try
            connStr.Open()
            Dim cmd As New MySqlCommand("UPDATE `cert_id_issuance` SET `first_name`=@first_name,`middle_name`=@middle_name,`last_name`=@last_name,`gender`=@gender,
                                            `address`=@address,`contact_number`=@contact_number,`citizenship`=@citizenship,`place_birth`=@place_birth,`civil_status`=@civil_status,
                                            `tin_no`=@tin_no,`image`=@image, `Birthdate_intxt`=@Birthdate_intxt WHERE `bgy_id_no`=@bgy_id_no", connStr)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@bgy_id_no", bgyID)
            cmd.Parameters.AddWithValue("@first_name", FirstN)
            cmd.Parameters.AddWithValue("@middle_name", MidN)
            cmd.Parameters.AddWithValue("@last_name", LastN)
            cmd.Parameters.AddWithValue("@gender", Gend)
            cmd.Parameters.AddWithValue("@address", Address)
            cmd.Parameters.AddWithValue("@contact_number", ContN)
            cmd.Parameters.AddWithValue("@citizenship", Citi)
            cmd.Parameters.AddWithValue("@place_birth", Bpace)
            cmd.Parameters.AddWithValue("@civil_status", CivilS)
            cmd.Parameters.AddWithValue("@tin_no", TIN)
            cmd.Parameters.AddWithValue("@Birthdate_intxt", BDay)

            Dim imageBytes As Object = DBNull.Value
            If picImage.Image IsNot Nothing Then
                Try
                    Using ms As New MemoryStream()
                        picImage.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                        imageBytes = ms.ToArray()
                    End Using
                Catch ex As ExternalException
                    MessageBox.Show("You need to update the Image!",
                        "Image Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            Else
                imageBytes = DBNull.Value
            End If
            Dim Ceduladate As DateTime
            If Not DateTime.TryParse(txtBirthDate.Text, Ceduladate) Then
                MsgBox("Please enter a valid birth date in MM/DD/YYYY format.", vbExclamation)
                txtBirthDate.Clear()
                Return
            Else
                Ceduladate = Ceduladate.ToString("MM/dd/yyyy")
                txtBirthDate.Text = Ceduladate
            End If

            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                cmd.Parameters.AddWithValue("@image", imageBytes)
            Else
                cmd.Parameters.AddWithValue("@image", DBNull.Value)
            End If

            Dim int As Integer = cmd.ExecuteNonQuery()

            If int > 0 Then
                MessageBox.Show("Record Update Success", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connStr.Close()
            Clear_()


            Editbtn.Enabled = False
            btnSave.Enabled = True
            'Delbtn.Enabled = False
        End Try


    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        edit_new()
        DTG_load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = True
        btnSave.Enabled = True
        'Delbtn.Enabled = False
        Editbtn.Enabled = False
        DTG_load()
        Clear_()
    End Sub

    Public Sub DTG_load()

        DataGridView1.Rows.Clear()

        Try
            connStr.Open()

            Dim com As New MySqlCommand("SELECT * FROM `cert_id_issuance`", connStr)
            Dim dr1 As MySqlDataReader = com.ExecuteReader()
            While dr1.Read
                DataGridView1.Rows.Add(dr1.Item("bgy_id_no"), dr1.Item("first_name"), dr1.Item("middle_name"), dr1.Item("last_name"), dr1.Item("gender"), dr1.Item("Birthdate_intxt"), dr1.Item("address"), dr1.Item("contact_number"), dr1.Item("citizenship"), dr1.Item("place_birth"), dr1.Item("civil_status"), dr1.Item("tin_no"), dr1.Item("image"))
            End While
            dr1.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connStr.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            bgyIDtxt.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            Firstnametxt4.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            midnametxt.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            Lstnametx.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            gendertxt.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
            txtBirthDate.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
            Addtxt.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
            ConNotxt.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
            Citizntxt.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
            PlaceBDaytxt.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
            Civlstattxt.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
            Tintxt.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()

            Dim imageData As Object = selectedRow.Cells(12).Value

            If imageData IsNot DBNull.Value Then
                Try
                    Dim imageBytes As Byte() = CType(imageData, Byte())

                    If imageBytes.Length > 0 Then
                        Using ms As New MemoryStream(imageBytes)
                            Dim img As Image = Image.FromStream(ms)
                            picImage.Image = img
                        End Using
                    Else
                        picImage.Image = Nothing
                    End If
                Catch ex As Exception
                    MessageBox.Show("Invalid image format or corrupted image data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    picImage.Image = Nothing
                End Try
            End If
        End If
        Button2.Enabled = False
        'Delbtn.Enabled = True
        btnSave.Enabled = False
        Editbtn.Enabled = True
    End Sub

    Private Sub txtBirthDate_TextChanged(sender As Object, e As EventArgs) Handles txtBirthDate.TextChanged

    End Sub
End Class
