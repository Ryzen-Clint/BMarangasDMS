Imports Google.Protobuf.Reflection
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports Org.BouncyCastle.Pqc.Crypto
Public Class dashboard
    Private currentUser As String
    Private userPosition As String

    Public Sub SetCurrentUser(username As String, position As String)
        currentUser = username
        lblCurrentUser.Text = "Welcome: " & currentUser
        userPosition = position
        lblUserPosition.Text = userPosition

        DisableButtons()
    End Sub

    Private Sub DisableButtons()
        If userPosition.ToLower() = "admin" Then
            Adminbtn.Enabled = True
            Button1.Enabled = True
            Clerk1btn.Enabled = True
            Clerk2btn.Enabled = True
            Clerk3btn.Enabled = True
            Clerk4btn.Enabled = True
            Clerk01_residencyfrm.Delbtn.Enabled = True
            Clerk01_residencyfrm.Editbtn.Enabled = True
        ElseIf userPosition.ToLower() = "secretary" Then
            Button1.Enabled = True
            Clerk1btn.Enabled = True
            Clerk2btn.Enabled = True
            Clerk3btn.Enabled = True
            Clerk4btn.Enabled = True
            Clerk01_residencyfrm.Delbtn.Enabled = True
            Clerk01_residencyfrm.Editbtn.Enabled = True
        ElseIf userPosition.ToLower() = "clerk 01" Then
            Clerk1btn.Enabled = True
        ElseIf userPosition.ToLower() = "clerk 02" Then
            Clerk2btn.Enabled = True
        ElseIf userPosition.ToLower() = "clerk 03" Then
            Clerk3btn.Enabled = True
        ElseIf userPosition.ToLower() = "clerk 04" Then
            Clerk4btn.Enabled = True
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles logoutfrm.Click
        Regpanel.Controls.Clear()
        AdminForm.Close()
        Clerk01frm.Close()
        Me.Close()
        LoginForm.Show()
    End Sub

    Sub switchpanel(ByVal panel As Form)
        Regpanel.Controls.Clear()
        panel.TopLevel = False
        Regpanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Adminbtn_Click(sender As Object, e As EventArgs) Handles Adminbtn.Click
        switchpanel(AdminForm)
        AdminForm.WindowState = FormWindowState.Maximized

        Regpanel.ResetBindings()
    End Sub

    Private Sub Clerk1btn_Click(sender As Object, e As EventArgs) Handles Clerk1btn.Click
        switchpanel(Clerk01frm)
        Clerk01frm.WindowState = FormWindowState.Maximized
        Clerk01frm.Panel1.Visible = False
        Clerk01frm.Label1.Visible = False
        Clerk01frm.Label5.Visible = False
        Clerk01frm.Label7.Visible = False
        Clerk01frm.Label6.Visible = False
        Clerk01frm.logoutfrm.Visible = False
        Regpanel.ResetBindings()
    End Sub

    Private Sub timeTimer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateTime()
    End Sub

    Private Sub UpdateTime()

        Label3.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        UpdateTime()

    End Sub


    Private Sub Clerk2btn_Click(sender As Object, e As EventArgs) Handles Clerk2btn.Click
        switchpanel(Clerk02frm)
        Clerk02frm.WindowState = FormWindowState.Maximized
        Clerk02frm.Panel1.Visible = False
        Clerk02frm.Label1.Visible = False
        Clerk02frm.Label5.Visible = False
        Clerk02frm.Label7.Visible = False
        Clerk02frm.Label6.Visible = False
        Clerk02frm.logoutfrm.Visible = False
        Regpanel.ResetBindings()
    End Sub

    Private Sub Clerk3btn_Click(sender As Object, e As EventArgs) Handles Clerk3btn.Click
        switchpanel(Clerk03frm)
        Clerk03frm.WindowState = FormWindowState.Maximized
        Clerk03frm.Panel1.Visible = False
        Clerk03frm.Label1.Visible = False
        Clerk03frm.Label5.Visible = False
        Clerk03frm.Label7.Visible = False
        Clerk03frm.Label6.Visible = False
        Clerk03frm.logoutfrm.Visible = False
        Regpanel.ResetBindings()
    End Sub

    Private Sub Clerk4btn_Click(sender As Object, e As EventArgs) Handles Clerk4btn.Click
        switchpanel(Clerk04frm)
        Clerk04frm.WindowState = FormWindowState.Maximized
        Clerk04frm.Panel1.Visible = False
        Clerk04frm.Label1.Visible = False
        Clerk04frm.Label5.Visible = False
        Clerk04frm.Label7.Visible = False
        Clerk04frm.Label6.Visible = False
        Clerk04frm.logoutfrm.Visible = False
        Regpanel.ResetBindings()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblUserPosition_Click(sender As Object, e As EventArgs) Handles lblUserPosition.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchpanel(Secretaryfrm)
        Secretaryfrm.WindowState = FormWindowState.Maximized

        Regpanel.ResetBindings()
    End Sub
End Class