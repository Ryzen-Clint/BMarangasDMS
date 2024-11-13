Imports Google.Protobuf.Reflection
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports System.Runtime.InteropServices
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Clerk01_Cedulafrm
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=mdms_login_db")
    Dim inte As Integer
    Dim anIntArray As Integer() = New Integer() {}

    Public Sub Clear()
        txtid_no.Clear()
        txtfname.Clear()
        txtmidname.Clear()
        txtlname.Clear()
        txtaddress.Clear()
        txtcitizen.Clear()
        txtbdayplace.Clear()
        txttinno_.Clear()
        txtheight.Clear()
        txtweight.Clear()
        txtcert_no.Clear()
        txtrequest_date.Clear()
        txtcedula_or.Clear()
        txtSearch.Clear()
        PictureBox1.ImageLocation = String.Empty
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click, btnsearch2.Click
        Dim userID As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(userID) Then
            MessageBox.Show("Please enter a user ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionStr As String = "Server=localhost;Database=mdms_login_db;User ID=root;Password=;"
        Dim query As String = "SELECT `bgy_id_no`, `first_name`, `middle_name`, `last_name`, `address`, `citizenship`, `place_birth`, `tin_no`, `Birthdate_intxt`, 
                           `height`, `weight`, `cedula_certificate_no`, `cedula_date`, `cedula_or`, `cedula_image` 
                           FROM `cert_id_issuance` WHERE `bgy_id_no`=@bgy_id_no"

        Using connection As New MySqlConnection(connectionStr)
            Try
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@bgy_id_no", userID)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()

                            txtid_no.Text = reader("bgy_id_no").ToString()
                            txtfname.Text = reader("first_name").ToString()
                            txtmidname.Text = reader("middle_name").ToString()
                            txtlname.Text = reader("last_name").ToString()
                            txtaddress.Text = reader("address").ToString()
                            txtcitizen.Text = reader("citizenship").ToString()
                            txtbdayplace.Text = reader("place_birth").ToString()
                            txttinno_.Text = reader("tin_no").ToString()
                            txtheight.Text = reader("height").ToString()
                            txtweight.Text = reader("weight").ToString()
                            txtcert_no.Text = reader("cedula_certificate_no").ToString()
                            txtrequest_date.Text = reader("cedula_date").ToString()
                            txtcedula_or.Text = reader("cedula_or").ToString()

                            If Not IsDBNull(reader("cedula_image")) Then
                                Dim imageBytes As Byte() = CType(reader("cedula_image"), Byte())
                                Try
                                    Using ms As New MemoryStream(imageBytes)
                                        Dim img As Image = Image.FromStream(ms)

                                        If img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg) OrElse
                                       img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png) OrElse
                                       img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp) Then
                                            PictureBox1.Image = img
                                        Else
                                            MessageBox.Show("Unsupported image format.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            PictureBox1.Image = Nothing
                                        End If
                                    End Using
                                Catch ex As Exception
                                    MessageBox.Show("Error loading the image. The image may be invalid or corrupt.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    PictureBox1.Image = Nothing
                                End Try
                            Else
                                PictureBox1.Image = Nothing
                            End If
                        Else
                            MessageBox.Show("No user found with the given ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Clear()
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Public Sub DTG_load()

        DataGridView1.Rows.Clear()

        Try
            conn.Open()

            Dim com As New MySqlCommand("SELECT * FROM `cert_id_issuance`", conn)
            Dim dr1 As MySqlDataReader = com.ExecuteReader()
            While dr1.Read
                DataGridView1.Rows.Add(dr1.Item("cedula_or"), dr1.Item("cedula_certificate_no"), dr1.Item("cedula_date"), dr1.Item("first_name"), dr1.Item("middle_name"),
                                       dr1.Item("last_name"), dr1.Item("gender"), dr1.Item("Birthdate_intxt"), dr1.Item("height"), dr1.Item("weight"), dr1.Item("bgy_id_no"))
            End While
            dr1.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub


    Private Sub Clerk01_Cedulafrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTG_load()
    End Sub

    Private Function ValidateFields() As Boolean
        If String.IsNullOrEmpty(txtheight.Text.Trim()) Then
            MessageBox.Show("Height is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtheight.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtweight.Text.Trim()) Then
            MessageBox.Show("Weight is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtweight.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtcert_no.Text.Trim()) Then
            MessageBox.Show("Cedula Certificate Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcert_no.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtrequest_date.Text.Trim()) Then
            MessageBox.Show("Request Date is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtrequest_date.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtcedula_or.Text.Trim()) Then
            MessageBox.Show("Cedula OR Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcedula_or.Focus()
            Return False
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please upload a picture.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Public Sub edit()
        If Not ValidateFields() Then
            Return
        End If

        Dim bgyID As String = txtid_no.Text.Trim()
        Dim FirstN As String = txtfname.Text.Trim()
        Dim MidN As String = txtmidname.Text.Trim()
        Dim LastN As String = txtlname.Text.Trim()
        Dim Address As String = txtaddress.Text.Trim()
        Dim Citizen As String = txtcitizen.Text.Trim()
        Dim BDayPlace As String = txtbdayplace.Text.Trim()
        Dim TinNo As String = txttinno_.Text.Trim()
        Dim Height As String = txtheight.Text.Trim()
        Dim Weight As String = txtweight.Text.Trim()
        Dim CertNo As String = txtcert_no.Text.Trim()
        Dim ReqDate As String = txtrequest_date.Text.Trim()
        Dim CedulaOr As String = txtcedula_or.Text.Trim()

        Dim imageBytes As Object = DBNull.Value
        If PictureBox1.Image IsNot Nothing Then
            Try
                Using ms As New MemoryStream()
                    PictureBox1.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                    imageBytes = ms.ToArray()
                End Using
            Catch ex As ExternalException
                MessageBox.Show("Error saving the image. The image may be invalid or corrupt: Try to add another valid Image",
                        "Image Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        Else
            imageBytes = DBNull.Value
        End If
        Dim Ceduladate As DateTime
        If Not DateTime.TryParse(txtrequest_date.Text, Ceduladate) Then
            MsgBox("Please enter a valid birth date in MM/DD/YYYY format.", vbExclamation)
            txtrequest_date.Clear()
            Return
        Else
            Ceduladate = Ceduladate.ToString("MM/dd/yyyy")
            txtrequest_date.Text = Ceduladate
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `cert_id_issuance` SET `first_name`=@first_name, `middle_name`=@middle_name, `last_name`=@last_name, `address`=@address,
                                        `citizenship`=@citizenship, `place_birth`=@place_birth, `tin_no`=@tin_no, `height`=@height, `weight`=@weight,
                                        `cedula_certificate_no`=@cedula_certificate_no, `cedula_date`=@cedula_date, `cedula_or`=@cedula_or, 
                                        `cedula_image`=@cedula_image WHERE `bgy_id_no`=@bgy_id_no", conn)

            cmd.Parameters.AddWithValue("@bgy_id_no", bgyID)
            cmd.Parameters.AddWithValue("@first_name", FirstN)
            cmd.Parameters.AddWithValue("@middle_name", MidN)
            cmd.Parameters.AddWithValue("@last_name", LastN)
            cmd.Parameters.AddWithValue("@address", Address)
            cmd.Parameters.AddWithValue("@citizenship", Citizen)
            cmd.Parameters.AddWithValue("@place_birth", BDayPlace)
            cmd.Parameters.AddWithValue("@tin_no", TinNo)
            cmd.Parameters.AddWithValue("@height", Height)
            cmd.Parameters.AddWithValue("@weight", Weight)
            cmd.Parameters.AddWithValue("@cedula_certificate_no", CertNo)
            cmd.Parameters.AddWithValue("@cedula_date", ReqDate)
            cmd.Parameters.AddWithValue("@cedula_or", CedulaOr)


            If imageBytes IsNot DBNull.Value Then
                cmd.Parameters.AddWithValue("@cedula_image", imageBytes)
            Else
                cmd.Parameters.AddWithValue("@cedula_image", DBNull.Value)
            End If

            inte = cmd.ExecuteNonQuery()

            If inte > 0 Then
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
            Clear()
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        edit()
        DTG_load()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim currentDate As DateTime = DateTime.Now
        txtrequest_date.Text = currentDate.ToString("MM/dd/yyyy")
    End Sub

    Private Function ResizeImage(originalImage As Image, newWidth As Integer, newHeight As Integer) As Image
        Dim resizedImage As New Bitmap(newWidth, newHeight)
        Using g As Graphics = Graphics.FromImage(resizedImage)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(originalImage, 0, 0, newWidth, newHeight)
        End Using
        Return resizedImage
    End Function
    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim imageBytes As Object = DBNull.Value
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg"

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim filePath As String = openFileDialog.FileName

            Dim originalImage As Image = Image.FromFile(filePath)
            Dim resizedImage As Image = ResizeImage(originalImage, 470, 370)
            PictureBox1.Image = resizedImage

            Using ms As New MemoryStream()
                resizedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                imageBytes = ms.ToArray()
            End Using

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clear()
    End Sub

    Private Sub btnsearch2_Click(sender As Object, e As EventArgs) Handles btnsearch2.Click
        Dim searchTerm As String = txtsearch2.Text.Trim().ToLower()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For
            Dim lastName As String = row.Cells("last_name").Value.ToString().ToLower()
            Dim Cedula As String = row.Cells("cedula_or").Value.ToString().ToLower()
            Dim idNumber As String = row.Cells("bgy_id_no").Value.ToString().ToLower()

            If lastName.Contains(searchTerm) OrElse idNumber.Contains(searchTerm) OrElse Cedula.Contains(searchTerm) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next

    End Sub

    Private Sub txtsearch2_TextChanged(sender As Object, e As EventArgs) Handles txtsearch2.TextChanged
        btnsearch2_Click(sender, e)
    End Sub
End Class