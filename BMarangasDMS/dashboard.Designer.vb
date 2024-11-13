<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUserPosition = New System.Windows.Forms.Label()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Regpanel = New System.Windows.Forms.Panel()
        Me.Adminbtn = New System.Windows.Forms.Button()
        Me.Clerk1btn = New System.Windows.Forms.Button()
        Me.Clerk2btn = New System.Windows.Forms.Button()
        Me.Clerk3btn = New System.Windows.Forms.Button()
        Me.Clerk4btn = New System.Windows.Forms.Button()
        Me.logoutfrm = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblUserPosition)
        Me.Panel1.Controls.Add(Me.lblCurrentUser)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(148, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 67)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(1024, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Position:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUserPosition
        '
        Me.lblUserPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserPosition.AutoSize = True
        Me.lblUserPosition.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserPosition.ForeColor = System.Drawing.Color.Navy
        Me.lblUserPosition.Location = New System.Drawing.Point(1095, 23)
        Me.lblUserPosition.Name = "lblUserPosition"
        Me.lblUserPosition.Size = New System.Drawing.Size(61, 20)
        Me.lblUserPosition.TabIndex = 8
        Me.lblUserPosition.Text = "Position"
        Me.lblUserPosition.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUser.ForeColor = System.Drawing.Color.Navy
        Me.lblCurrentUser.Location = New System.Drawing.Point(1024, 2)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(94, 20)
        Me.lblCurrentUser.TabIndex = 8
        Me.lblCurrentUser.Text = "Current User"
        Me.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(1024, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Time "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(3, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(688, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Marangas Barangay Hall Data Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 0
        '
        'Regpanel
        '
        Me.Regpanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Regpanel.AutoScroll = True
        Me.Regpanel.BackColor = System.Drawing.Color.Azure
        Me.Regpanel.Location = New System.Drawing.Point(148, 64)
        Me.Regpanel.Name = "Regpanel"
        Me.Regpanel.Size = New System.Drawing.Size(1271, 662)
        Me.Regpanel.TabIndex = 0
        '
        'Adminbtn
        '
        Me.Adminbtn.BackColor = System.Drawing.Color.Transparent
        Me.Adminbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Adminbtn.Enabled = False
        Me.Adminbtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Adminbtn.FlatAppearance.BorderSize = 0
        Me.Adminbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Adminbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Adminbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Adminbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adminbtn.ForeColor = System.Drawing.Color.Azure
        Me.Adminbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Adminbtn.Location = New System.Drawing.Point(-4, 64)
        Me.Adminbtn.Name = "Adminbtn"
        Me.Adminbtn.Size = New System.Drawing.Size(152, 60)
        Me.Adminbtn.TabIndex = 63
        Me.Adminbtn.Text = "Admin"
        Me.Adminbtn.UseVisualStyleBackColor = False
        '
        'Clerk1btn
        '
        Me.Clerk1btn.BackColor = System.Drawing.Color.Transparent
        Me.Clerk1btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clerk1btn.Enabled = False
        Me.Clerk1btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Clerk1btn.FlatAppearance.BorderSize = 0
        Me.Clerk1btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clerk1btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clerk1btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Clerk1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clerk1btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clerk1btn.ForeColor = System.Drawing.Color.Azure
        Me.Clerk1btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Clerk1btn.Location = New System.Drawing.Point(-4, 181)
        Me.Clerk1btn.Name = "Clerk1btn"
        Me.Clerk1btn.Size = New System.Drawing.Size(152, 60)
        Me.Clerk1btn.TabIndex = 63
        Me.Clerk1btn.Text = "Certificate Issuance"
        Me.Clerk1btn.UseVisualStyleBackColor = False
        '
        'Clerk2btn
        '
        Me.Clerk2btn.BackColor = System.Drawing.Color.Transparent
        Me.Clerk2btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clerk2btn.Enabled = False
        Me.Clerk2btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Clerk2btn.FlatAppearance.BorderSize = 0
        Me.Clerk2btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clerk2btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clerk2btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Clerk2btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clerk2btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clerk2btn.ForeColor = System.Drawing.Color.Azure
        Me.Clerk2btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Clerk2btn.Location = New System.Drawing.Point(-4, 240)
        Me.Clerk2btn.Name = "Clerk2btn"
        Me.Clerk2btn.Size = New System.Drawing.Size(152, 60)
        Me.Clerk2btn.TabIndex = 63
        Me.Clerk2btn.Text = "Health Worker"
        Me.Clerk2btn.UseVisualStyleBackColor = False
        '
        'Clerk3btn
        '
        Me.Clerk3btn.BackColor = System.Drawing.Color.Transparent
        Me.Clerk3btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clerk3btn.Enabled = False
        Me.Clerk3btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Clerk3btn.FlatAppearance.BorderSize = 0
        Me.Clerk3btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clerk3btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clerk3btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Clerk3btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clerk3btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clerk3btn.ForeColor = System.Drawing.Color.Azure
        Me.Clerk3btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Clerk3btn.Location = New System.Drawing.Point(-4, 299)
        Me.Clerk3btn.Name = "Clerk3btn"
        Me.Clerk3btn.Size = New System.Drawing.Size(152, 60)
        Me.Clerk3btn.TabIndex = 63
        Me.Clerk3btn.Text = "VAWC/BCPC"
        Me.Clerk3btn.UseVisualStyleBackColor = False
        '
        'Clerk4btn
        '
        Me.Clerk4btn.BackColor = System.Drawing.Color.Transparent
        Me.Clerk4btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clerk4btn.Enabled = False
        Me.Clerk4btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Clerk4btn.FlatAppearance.BorderSize = 0
        Me.Clerk4btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clerk4btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Clerk4btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Clerk4btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clerk4btn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clerk4btn.ForeColor = System.Drawing.Color.Azure
        Me.Clerk4btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Clerk4btn.Location = New System.Drawing.Point(-4, 358)
        Me.Clerk4btn.Name = "Clerk4btn"
        Me.Clerk4btn.Size = New System.Drawing.Size(152, 60)
        Me.Clerk4btn.TabIndex = 63
        Me.Clerk4btn.Text = "Katarugang Pambarangay"
        Me.Clerk4btn.UseVisualStyleBackColor = False
        '
        'logoutfrm
        '
        Me.logoutfrm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.logoutfrm.BackColor = System.Drawing.Color.Transparent
        Me.logoutfrm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutfrm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.logoutfrm.FlatAppearance.BorderSize = 0
        Me.logoutfrm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.logoutfrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.logoutfrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoutfrm.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutfrm.ForeColor = System.Drawing.Color.Red
        Me.logoutfrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutfrm.Location = New System.Drawing.Point(-5, 658)
        Me.logoutfrm.Name = "logoutfrm"
        Me.logoutfrm.Size = New System.Drawing.Size(152, 60)
        Me.logoutfrm.TabIndex = 63
        Me.logoutfrm.Text = "Log Out"
        Me.logoutfrm.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.BackgroundImage = Global.BMarangasDMS.My.Resources.Resources.logo_50px
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(-4, -3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 67)
        Me.Button4.TabIndex = 61
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Azure
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(-4, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 60)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Secretary"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1389, 719)
        Me.Controls.Add(Me.logoutfrm)
        Me.Controls.Add(Me.Clerk4btn)
        Me.Controls.Add(Me.Clerk3btn)
        Me.Controls.Add(Me.Clerk2btn)
        Me.Controls.Add(Me.Clerk1btn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Adminbtn)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Regpanel)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(1360, 766)
        Me.Name = "dashboard"
        Me.Text = "MBHDMS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Regpanel As Panel
    Friend WithEvents Adminbtn As Button
    Friend WithEvents Clerk1btn As Button
    Friend WithEvents Clerk2btn As Button
    Friend WithEvents Clerk3btn As Button
    Friend WithEvents Clerk4btn As Button
    Friend WithEvents logoutfrm As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCurrentUser As Label
    Friend WithEvents lblUserPosition As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
