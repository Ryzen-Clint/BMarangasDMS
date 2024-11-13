Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Secretaryfrm
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=mdms_login_db")

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchQuery As String = txtSearch.Text.Trim()

        If String.IsNullOrWhiteSpace(searchQuery) Then
            MessageBox.Show("Please enter a valid barangay ID number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query1 As String = "SELECT COUNT(*) FROM cert_bgy_clearance WHERE bgy_id_no = @bgy_id_no"
        Dim query2 As String = "
            SELECT COUNT(*) AS RowCount, 
                   GROUP_CONCAT(DISTINCT CONCAT(cedula_or, ' (', cedula_date, ')') ORDER BY cedula_or) AS CedulaOrAndDate
            FROM cert_id_issuance 
            WHERE bgy_id_no = @bgy_id_no"
        Dim query3 As String = "SELECT COUNT(*) FROM cert_indigent WHERE bgy_id_no = @bgy_id_no"

        Try
            conn.Open()

            Using cmd As New MySqlCommand(query1, conn)
                cmd.Parameters.AddWithValue("@bgy_id_no", searchQuery)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Label1.Text = "Barangay Clearance: " & count.ToString() & " Transaction/s made"
            End Using

            Using cmd As New MySqlCommand(query2, conn)
                cmd.Parameters.AddWithValue("@bgy_id_no", searchQuery)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim rowCount As Integer = Convert.ToInt32(reader("RowCount"))
                        Dim cedulaOrAndDate As String = If(reader("CedulaOrAndDate") Is DBNull.Value, " ", reader("CedulaOrAndDate").ToString())
                        Label2.Text = "Registered ID Number: " & rowCount.ToString() & " , Cedula OR Number (Issuance Date): " & cedulaOrAndDate
                    End If
                End Using
            End Using

            Using cmd As New MySqlCommand(query3, conn)
                cmd.Parameters.AddWithValue("@bgy_id_no", searchQuery)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Label3.Text = "Certificate of Indigency: " & count.ToString() & " Transaction/s made"
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub Secretaryfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
