<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clerk01_Indigencyfrm
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtmidname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtbdate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblage_ = New System.Windows.Forms.Label()
        Me.lblmonth = New System.Windows.Forms.Label()
        Me.lblrequest = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtrequestedby = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtday = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtmonth = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.bgy_id_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtBgyId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(96, 43)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(190, 30)
        Me.txtSearch.TabIndex = 102
        '
        'Searchbtn
        '
        Me.Searchbtn.BackColor = System.Drawing.Color.Navy
        Me.Searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Searchbtn.FlatAppearance.BorderSize = 0
        Me.Searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Searchbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Searchbtn.ForeColor = System.Drawing.Color.AliceBlue
        Me.Searchbtn.Location = New System.Drawing.Point(15, 46)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(75, 26)
        Me.Searchbtn.TabIndex = 101
        Me.Searchbtn.Text = "Search"
        Me.Searchbtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 17)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Indigency"
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprint.Enabled = False
        Me.btnprint.FlatAppearance.BorderSize = 0
        Me.btnprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.Azure
        Me.btnprint.Location = New System.Drawing.Point(349, 205)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 47)
        Me.btnprint.TabIndex = 108
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.Black
        Me.txtfname.Location = New System.Drawing.Point(121, 152)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.ReadOnly = True
        Me.txtfname.Size = New System.Drawing.Size(212, 30)
        Me.txtfname.TabIndex = 102
        '
        'txtmidname
        '
        Me.txtmidname.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmidname.ForeColor = System.Drawing.Color.Black
        Me.txtmidname.Location = New System.Drawing.Point(121, 188)
        Me.txtmidname.Name = "txtmidname"
        Me.txtmidname.ReadOnly = True
        Me.txtmidname.Size = New System.Drawing.Size(212, 30)
        Me.txtmidname.TabIndex = 102
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.ForeColor = System.Drawing.Color.Black
        Me.txtlname.Location = New System.Drawing.Point(121, 224)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.ReadOnly = True
        Me.txtlname.Size = New System.Drawing.Size(212, 30)
        Me.txtlname.TabIndex = 102
        '
        'txtbdate
        '
        Me.txtbdate.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbdate.ForeColor = System.Drawing.Color.Black
        Me.txtbdate.Location = New System.Drawing.Point(121, 260)
        Me.txtbdate.Name = "txtbdate"
        Me.txtbdate.ReadOnly = True
        Me.txtbdate.Size = New System.Drawing.Size(212, 30)
        Me.txtbdate.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Midlename"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Lastname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Current Age"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.BMarangasDMS.My.Resources.Resources.indigency
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblage_)
        Me.Panel1.Controls.Add(Me.lblmonth)
        Me.Panel1.Controls.Add(Me.lblrequest)
        Me.Panel1.Controls.Add(Me.lblAge)
        Me.Panel1.Controls.Add(Me.lblfullname)
        Me.Panel1.Location = New System.Drawing.Point(428, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 907)
        Me.Panel1.TabIndex = 111
        '
        'lblage_
        '
        Me.lblage_.AutoSize = True
        Me.lblage_.BackColor = System.Drawing.Color.Transparent
        Me.lblage_.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage_.Location = New System.Drawing.Point(357, 396)
        Me.lblage_.Name = "lblage_"
        Me.lblage_.Size = New System.Drawing.Size(0, 15)
        Me.lblage_.TabIndex = 1
        '
        'lblmonth
        '
        Me.lblmonth.AutoSize = True
        Me.lblmonth.BackColor = System.Drawing.Color.Transparent
        Me.lblmonth.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonth.Location = New System.Drawing.Point(447, 395)
        Me.lblmonth.Name = "lblmonth"
        Me.lblmonth.Size = New System.Drawing.Size(0, 15)
        Me.lblmonth.TabIndex = 1
        '
        'lblrequest
        '
        Me.lblrequest.AutoSize = True
        Me.lblrequest.BackColor = System.Drawing.Color.Transparent
        Me.lblrequest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrequest.Location = New System.Drawing.Point(216, 369)
        Me.lblrequest.Name = "lblrequest"
        Me.lblrequest.Size = New System.Drawing.Size(0, 15)
        Me.lblrequest.TabIndex = 1
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(236, 313)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(0, 15)
        Me.lblAge.TabIndex = 0
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.BackColor = System.Drawing.Color.Transparent
        Me.lblfullname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.Location = New System.Drawing.Point(431, 297)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(0, 15)
        Me.lblfullname.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Firstname"
        '
        'txtrequestedby
        '
        Me.txtrequestedby.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrequestedby.ForeColor = System.Drawing.Color.Black
        Me.txtrequestedby.Location = New System.Drawing.Point(154, 332)
        Me.txtrequestedby.Name = "txtrequestedby"
        Me.txtrequestedby.Size = New System.Drawing.Size(179, 30)
        Me.txtrequestedby.TabIndex = 102
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Requested by"
        '
        'txtday
        '
        Me.txtday.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtday.ForeColor = System.Drawing.Color.Black
        Me.txtday.Location = New System.Drawing.Point(154, 367)
        Me.txtday.Name = "txtday"
        Me.txtday.Size = New System.Drawing.Size(58, 30)
        Me.txtday.TabIndex = 102
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 32)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Requested Day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Month" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtmonth
        '
        Me.txtmonth.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonth.ForeColor = System.Drawing.Color.Black
        Me.txtmonth.Location = New System.Drawing.Point(218, 367)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.Size = New System.Drawing.Size(115, 30)
        Me.txtmonth.TabIndex = 102
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(218, 296)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(115, 30)
        Me.txtage.TabIndex = 102
        '
        'btncalc
        '
        Me.btncalc.BackColor = System.Drawing.Color.Navy
        Me.btncalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncalc.FlatAppearance.BorderSize = 0
        Me.btncalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.btncalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btncalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalc.ForeColor = System.Drawing.Color.AliceBlue
        Me.btncalc.Location = New System.Drawing.Point(121, 299)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(91, 26)
        Me.btncalc.TabIndex = 101
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 268)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 16)
        Me.Label13.TabIndex = 110
        Me.Label13.Text = "Birthdate"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.BackgroundImage = Global.BMarangasDMS.My.Resources.Resources.logo_40px
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button1.Location = New System.Drawing.Point(121, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 26)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Navy
        Me.Button2.BackgroundImage = Global.BMarangasDMS.My.Resources.Resources.logo_40px
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button2.Location = New System.Drawing.Point(121, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 26)
        Me.Button2.TabIndex = 101
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Azure
        Me.Button3.Location = New System.Drawing.Point(349, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 47)
        Me.Button3.TabIndex = 108
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Arial Unicode MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Azure
        Me.btnsave.Location = New System.Drawing.Point(349, 152)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 47)
        Me.btnsave.TabIndex = 108
        Me.btnsave.Text = "Save As Picture"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Azure
        Me.Button4.Location = New System.Drawing.Point(349, 46)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 47)
        Me.Button4.TabIndex = 108
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Search for BGY ID"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView2.ColumnHeadersHeight = 29
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bgy_id_no, Me.Column3, Me.Column4, Me.Lastname, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column8})
        Me.DataGridView2.Location = New System.Drawing.Point(1087, 138)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(298, 369)
        Me.DataGridView2.TabIndex = 144
        '
        'bgy_id_no
        '
        Me.bgy_id_no.HeaderText = "Barangay ID No."
        Me.bgy_id_no.MinimumWidth = 6
        Me.bgy_id_no.Name = "bgy_id_no"
        Me.bgy_id_no.ReadOnly = True
        Me.bgy_id_no.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Firstaname"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Middlename"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Lastname
        '
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.MinimumWidth = 6
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        Me.Lastname.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Birth Date"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Age"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Requested By"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "Requested (Month)"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Requested (Day)"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1084, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(189, 15)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = "Bgy Indigency Transactions:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(1114, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 30)
        Me.TextBox1.TabIndex = 142
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Navy
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button5.Location = New System.Drawing.Point(1310, 80)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 26)
        Me.Button5.TabIndex = 141
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1111, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(185, 16)
        Me.Label17.TabIndex = 165
        Me.Label17.Text = "Search for ID No. or Lastname"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Azure
        Me.Button6.Location = New System.Drawing.Point(349, 258)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 47)
        Me.Button6.TabIndex = 108
        Me.Button6.Text = "Reload"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'txtBgyId
        '
        Me.txtBgyId.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBgyId.ForeColor = System.Drawing.Color.Black
        Me.txtBgyId.Location = New System.Drawing.Point(121, 116)
        Me.txtBgyId.Name = "txtBgyId"
        Me.txtBgyId.ReadOnly = True
        Me.txtBgyId.Size = New System.Drawing.Size(212, 30)
        Me.txtBgyId.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Bgy ID Number"
        '
        'Clerk01_Indigencyfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1424, 992)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmonth)
        Me.Controls.Add(Me.txtday)
        Me.Controls.Add(Me.txtrequestedby)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtbdate)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtmidname)
        Me.Controls.Add(Me.txtBgyId)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.Searchbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clerk01_Indigencyfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clerk01_Indigencyfrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Searchbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnprint As Button
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtmidname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtbdate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblfullname As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtrequestedby As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtday As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtmonth As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents btncalc As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents lblrequest As Label
    Friend WithEvents lblage_ As Label
    Friend WithEvents lblmonth As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents txtBgyId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bgy_id_no As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
