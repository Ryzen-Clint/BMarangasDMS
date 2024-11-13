Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class Clerk01frm
    Private currentUser As String
    Private userPosition As String

    Public Sub SetCurrentUser1(username As String, position As String)
        currentUser = username
        userPosition = position
        Label12.Text = currentUser
    End Sub

    Private Sub closelbl_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Me.Close()
    End Sub

    Private isFullScreen As Boolean = True
    Private originalBounds As Rectangle

    Private Sub Label12_Click(sender As Object, e As EventArgs)
        Me.FormBorderStyle = FormBorderStyle.None

        Me.WindowState = FormWindowState.Maximized

        isFullScreen = False

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        originalBounds = Me.Bounds
        Me.Bounds = originalBounds
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub logoutfrm_Click(sender As Object, e As EventArgs) Handles logoutfrm.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        isFullScreen = False
        Label5.Visible = False
        Label6.Visible = True
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        originalBounds = Me.Bounds
        Me.Bounds = originalBounds
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Normal
        Label5.Visible = True
        Label6.Visible = False
    End Sub

    Private Sub Regpanel_Paint(sender As Object, e As PaintEventArgs) Handles Regpanel.Paint

    End Sub

    Private Sub Clerk01frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub switchpanel(ByVal panel As Form)
        clerkpanel.Controls.Clear()
        panel.TopLevel = False
        clerkpanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Adminbtn_Click(sender As Object, e As EventArgs) Handles residencybtn.Click
        switchpanel(Clerk01_residencyfrm)
        Clerk01_residencyfrm.WindowState = FormWindowState.Maximized

        clerkpanel.ResetBindings()
    End Sub

    Private Sub idbtn_Click(sender As Object, e As EventArgs) Handles idbtn.Click
        switchpanel(Clerk01_IDcardfrm)
        Clerk01_IDcardfrm.WindowState = FormWindowState.Maximized

        clerkpanel.ResetBindings()
    End Sub

    Private Sub indigencybtn_Click(sender As Object, e As EventArgs) Handles indigencybtn.Click
        switchpanel(Clerk01_Indigencyfrm)
        Clerk01_Indigencyfrm.WindowState = FormWindowState.Maximized

        clerkpanel.ResetBindings()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub bgyclearancebtn_Click(sender As Object, e As EventArgs) Handles bgyclearancebtn.Click
        switchpanel(Clerk01_BGYclearance)
        Clerk01_BGYclearance.WindowState = FormWindowState.Maximized

        clerkpanel.ResetBindings()
    End Sub

    Private Sub cedulabtn_Click(sender As Object, e As EventArgs) Handles cedulabtn.Click
        switchpanel(Clerk01_Cedulafrm)
        Clerk01_Cedulafrm.WindowState = FormWindowState.Maximized

        clerkpanel.ResetBindings()
    End Sub

    Private Sub jobseekerbtn_Click(sender As Object, e As EventArgs) Handles jobseekerbtn.Click
        switchpanel(Clerk01_Jobseekfrm)
        Clerk01_Jobseekfrm.WindowState = FormWindowState.Maximized

        clerkpanel.ResetBindings()
    End Sub

    Private Sub animaltrans_Click(sender As Object, e As EventArgs) Handles animaltrans.Click
        switchpanel(Clerk01_Animaltransfrm)
        Clerk01_Animaltransfrm.WindowState = FormWindowState.Maximized

        clerkpanel.ResetBindings()
    End Sub

    Private Sub microfinancebtn_Click(sender As Object, e As EventArgs) Handles microfinancebtn.Click
        switchpanel(Clerk01_Microfrm)
        Clerk01_Microfrm.WindowState = FormWindowState.Maximized

        clerkpanel.ResetBindings()
    End Sub
End Class