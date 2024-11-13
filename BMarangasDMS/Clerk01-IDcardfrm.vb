Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO

Public Class Clerk01_IDcardfrm
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=mdms_login_db")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Public Sub DTG_load()

        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `cert_id_issuance`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("bgy_id_no"), dr.Item("first_name"), dr.Item("middle_name"), dr.Item("last_name"), dr.Item("gender"), dr.Item("Birthdate_intxt"), dr.Item("address"), dr.Item("contact_number"), dr.Item("citizenship"), dr.Item("place_birth"), dr.Item("civil_status"), dr.Item("image"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub Clerk01_IDcardfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        DTG_load()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            IdNo_txt.Text = selectedRow.Cells(0).Value.ToString()
            Fnametxt.Text = selectedRow.Cells(1).Value.ToString()
            Mnametxt.Text = selectedRow.Cells(2).Value.ToString()
            Lnametxt.Text = selectedRow.Cells(3).Value.ToString()
            Gendertxt.Text = selectedRow.Cells(4).Value.ToString()
            Bdaytxt.Text = selectedRow.Cells(5).Value.ToString()
            Addresstxt.Text = selectedRow.Cells(6).Value.ToString()
            ContactNo_txt.Text = selectedRow.Cells(7).Value.ToString()
            Cvlstattxt.Text = selectedRow.Cells(10).Value.ToString()

            Dim imageData As Object = selectedRow.Cells(11).Value

            If imageData IsNot DBNull.Value AndAlso imageData IsNot Nothing Then
                Try
                    Dim imageBytes As Byte() = CType(imageData, Byte())

                    If imageBytes.Length > 0 Then
                        Using ms As New MemoryStream(imageBytes)
                            Dim img As Image = Image.FromStream(ms)
                            PictureBox1.Image = img
                        End Using
                    Else
                        PictureBox1.Image = Nothing
                    End If
                Catch ex As Exception
                    MessageBox.Show("Invalid image format or corrupted image data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    PictureBox1.Image = Nothing
                End Try
            Else
                PictureBox1.Image = Nothing
            End If
            namelbl.Text = Lnametxt.Text.ToUpper() & ", " & Fnametxt.Text.ToUpper() & " " & Mnametxt.Text.Substring(0, 1).ToUpper() & "."
            bdaylbl.Text = Bdaytxt.Text
            civilstatlbl.Text = Cvlstattxt.Text.ToUpper()
            genderlbl.Text = Gendertxt.Text.ToUpper()
            bgyIDlbl.Text = "BID-2024-" & IdNo_txt.Text.ToUpper()
            contactnolbl.Text = ContactNo_txt.Text.ToUpper()
            addresslbl.Text = Addresstxt.Text.ToUpper()
        End If

    End Sub

    Public Sub Clear_()
        IdNo_txt.Clear()
        Fnametxt.Clear()
        Mnametxt.Clear()
        Lnametxt.Clear()
        Gendertxt.Clear()
        Bdaytxt.Clear()
        Addresstxt.Clear()
        ContactNo_txt.Clear()
        Cvlstattxt.Clear()
        namelbl.Text = ""
        bdaylbl.Text = ""
        civilstatlbl.Text = ""
        genderlbl.Text = ""
        bgyIDlbl.Text = ""
        contactnolbl.Text = ""
        addresslbl.Text = ""
        PictureBox1.ImageLocation = String.Empty
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DTG_load()
        Clear_()
    End Sub

    Dim printDoc As New PrintDocument()
    Dim printPreviewDialog As New PrintPreviewDialog()

    ' Create a List to hold the panels that you want to print
    Dim panels As New List(Of Panel)()
    Dim currentPanelIndex As Integer = 0 ' Track the current panel being printed
    Dim yOffset As Integer = 0 ' Vertical offset for stacking panels

    ' Add panels to the list (make sure these panels are initialized)
    Private Sub AddPanelsToList()
        panels.Clear() ' Clear any previous panels from the list
        panels.Add(Panel1) ' Make sure Panel1 exists and is initialized
        panels.Add(Panel6) ' Ensure Panel2 exists and is initialized
    End Sub

    ' Set up PrintPage event handler
    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        ' Add panels to the list
        AddPanelsToList() ' This ensures the panels are added to the list when printing

        ' If there are panels to print
        If currentPanelIndex < panels.Count Then
            ' Get the current panel
            Dim panel As Panel = panels(currentPanelIndex)

            ' Capture the content of the current panel into a Bitmap
            Dim bmp As New Bitmap(panel.Width, panel.Height)
            panel.DrawToBitmap(bmp, New Rectangle(0, 0, panel.Width, panel.Height))

            ' Draw the captured Bitmap on the print page, applying vertical offset
            e.Graphics.DrawImage(bmp, 0, yOffset)

            ' Update the vertical offset for the next panel
            yOffset += panel.Height

            ' Check if the next panel will fit on the page
            If yOffset + panels(currentPanelIndex + 1).Height > e.PageBounds.Height Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If

            ' Move to the next panel for the next page (if more panels are left)
            currentPanelIndex += 1
        Else
            ' If no more panels to print, reset for next print
            currentPanelIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Assign the PrintDocument to the PrintPreviewDialog
        printPreviewDialog.Document = printDoc

        ' Show the print preview dialog
        printPreviewDialog.ShowDialog()
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

                    MessageBox.Show("Bgy ID Card Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error saving image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub printbtn2_Click(sender As Object, e As EventArgs) Handles printbtn2.Click, Button4.Click
        SavePanelAsImage()
        Clear_()
        txtSearch.Clear()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Searchbtn_Click(sender, e)
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()

        For Each row As DataGridViewRow In DataGridView1.Rows
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

End Class