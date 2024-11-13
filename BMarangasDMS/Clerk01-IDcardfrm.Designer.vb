<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clerk01_IDcardfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bgy_id_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.contactnolbl = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.genderlbl = New System.Windows.Forms.Label()
        Me.civilstatlbl = New System.Windows.Forms.Label()
        Me.addresslbl = New System.Windows.Forms.Label()
        Me.bgyIDlbl = New System.Windows.Forms.Label()
        Me.bdaylbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Bdaytxt = New System.Windows.Forms.TextBox()
        Me.Lnametxt = New System.Windows.Forms.TextBox()
        Me.Mnametxt = New System.Windows.Forms.TextBox()
        Me.IdNo_txt = New System.Windows.Forms.TextBox()
        Me.Fnametxt = New System.Windows.Forms.TextBox()
        Me.printbtn2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Addresstxt = New System.Windows.Forms.TextBox()
        Me.ContactNo_txt = New System.Windows.Forms.TextBox()
        Me.Gendertxt = New System.Windows.Forms.TextBox()
        Me.Cvlstattxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(162, 106)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(212, 16)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "Lastname, Firstname Middlename:"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.Location = New System.Drawing.Point(162, 157)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(82, 16)
        Me.lblMiddleName.TabIndex = 1
        Me.lblMiddleName.Text = "Date of Birth:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.BMarangasDMS.My.Resources.Resources.adminlock5
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(18, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 142)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bgy_id_no, Me.Column2, Me.Column3, Me.Lastname, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1377, 124)
        Me.DataGridView1.TabIndex = 5
        '
        'bgy_id_no
        '
        Me.bgy_id_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.bgy_id_no.HeaderText = "Bgy ID Number"
        Me.bgy_id_no.MinimumWidth = 127
        Me.bgy_id_no.Name = "bgy_id_no"
        Me.bgy_id_no.ReadOnly = True
        Me.bgy_id_no.Width = 127
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Firstname"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 95
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Middlename"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 111
        '
        'Lastname
        '
        Me.Lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.MinimumWidth = 6
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        Me.Lastname.Width = 95
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Gender"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 81
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Birth Date (MM/DD/YYYY)"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 191
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Address"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Contact Number"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 132
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Citizenship"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Place of Birth"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 114
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "Civil Status"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 101
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column12.HeaderText = "ID Picture"
        Me.Column12.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column12.Visible = False
        Me.Column12.Width = 125
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.contactnolbl)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.namelbl)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Controls.Add(Me.genderlbl)
        Me.Panel1.Controls.Add(Me.civilstatlbl)
        Me.Panel1.Controls.Add(Me.addresslbl)
        Me.Panel1.Controls.Add(Me.bgyIDlbl)
        Me.Panel1.Controls.Add(Me.bdaylbl)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblMiddleName)
        Me.Panel1.Location = New System.Drawing.Point(93, 291)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 341)
        Me.Panel1.TabIndex = 6
        '
        'contactnolbl
        '
        Me.contactnolbl.AutoSize = True
        Me.contactnolbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactnolbl.Location = New System.Drawing.Point(379, 223)
        Me.contactnolbl.Name = "contactnolbl"
        Me.contactnolbl.Size = New System.Drawing.Size(107, 17)
        Me.contactnolbl.TabIndex = 9
        Me.contactnolbl.Text = "09999999999"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(379, 205)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 16)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Contact Number:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Location = New System.Drawing.Point(18, 257)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(142, 39)
        Me.Panel2.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Location = New System.Drawing.Point(-2, 318)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(570, 21)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(570, 104)
        Me.Panel3.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightBlue
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Location = New System.Drawing.Point(0, 74)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(570, 30)
        Me.Panel5.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(129, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(287, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "BARANGAY IDENTIFICATION"
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelbl.Location = New System.Drawing.Point(162, 124)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(309, 21)
        Me.namelbl.TabIndex = 0
        Me.namelbl.Text = "Lastname, Firstname Middlename"
        '
        'genderlbl
        '
        Me.genderlbl.AutoSize = True
        Me.genderlbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderlbl.Location = New System.Drawing.Point(432, 175)
        Me.genderlbl.Name = "genderlbl"
        Me.genderlbl.Size = New System.Drawing.Size(48, 20)
        Me.genderlbl.TabIndex = 1
        Me.genderlbl.Text = "Male"
        '
        'civilstatlbl
        '
        Me.civilstatlbl.AutoSize = True
        Me.civilstatlbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.civilstatlbl.Location = New System.Drawing.Point(312, 175)
        Me.civilstatlbl.Name = "civilstatlbl"
        Me.civilstatlbl.Size = New System.Drawing.Size(61, 20)
        Me.civilstatlbl.TabIndex = 1
        Me.civilstatlbl.Text = "Single"
        '
        'addresslbl
        '
        Me.addresslbl.AutoSize = True
        Me.addresslbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addresslbl.Location = New System.Drawing.Point(162, 271)
        Me.addresslbl.Name = "addresslbl"
        Me.addresslbl.Size = New System.Drawing.Size(69, 17)
        Me.addresslbl.TabIndex = 1
        Me.addresslbl.Text = "Address"
        '
        'bgyIDlbl
        '
        Me.bgyIDlbl.AutoSize = True
        Me.bgyIDlbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgyIDlbl.Location = New System.Drawing.Point(163, 223)
        Me.bgyIDlbl.Name = "bgyIDlbl"
        Me.bgyIDlbl.Size = New System.Drawing.Size(144, 17)
        Me.bgyIDlbl.TabIndex = 1
        Me.bgyIDlbl.Text = "BID-2024-0000000"
        '
        'bdaylbl
        '
        Me.bdaylbl.AutoSize = True
        Me.bdaylbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdaylbl.Location = New System.Drawing.Point(162, 175)
        Me.bdaylbl.Name = "bdaylbl"
        Me.bdaylbl.Size = New System.Drawing.Size(117, 20)
        Me.bdaylbl.TabIndex = 1
        Me.bdaylbl.Text = "MM/DD/YYYY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(432, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Civil Status:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(57, 299)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Signature:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(162, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(163, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Bgy ID number:"
        '
        'Bdaytxt
        '
        Me.Bdaytxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Bdaytxt.BackColor = System.Drawing.Color.Azure
        Me.Bdaytxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bdaytxt.Location = New System.Drawing.Point(669, 416)
        Me.Bdaytxt.Name = "Bdaytxt"
        Me.Bdaytxt.ReadOnly = True
        Me.Bdaytxt.Size = New System.Drawing.Size(100, 22)
        Me.Bdaytxt.TabIndex = 5
        Me.Bdaytxt.Visible = False
        '
        'Lnametxt
        '
        Me.Lnametxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lnametxt.BackColor = System.Drawing.Color.Azure
        Me.Lnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lnametxt.Location = New System.Drawing.Point(669, 332)
        Me.Lnametxt.Name = "Lnametxt"
        Me.Lnametxt.ReadOnly = True
        Me.Lnametxt.Size = New System.Drawing.Size(100, 22)
        Me.Lnametxt.TabIndex = 5
        Me.Lnametxt.Visible = False
        '
        'Mnametxt
        '
        Me.Mnametxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Mnametxt.BackColor = System.Drawing.Color.Azure
        Me.Mnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mnametxt.Location = New System.Drawing.Point(669, 388)
        Me.Mnametxt.Name = "Mnametxt"
        Me.Mnametxt.ReadOnly = True
        Me.Mnametxt.Size = New System.Drawing.Size(100, 22)
        Me.Mnametxt.TabIndex = 5
        Me.Mnametxt.Visible = False
        '
        'IdNo_txt
        '
        Me.IdNo_txt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IdNo_txt.BackColor = System.Drawing.Color.Azure
        Me.IdNo_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdNo_txt.Location = New System.Drawing.Point(669, 498)
        Me.IdNo_txt.Name = "IdNo_txt"
        Me.IdNo_txt.ReadOnly = True
        Me.IdNo_txt.Size = New System.Drawing.Size(100, 22)
        Me.IdNo_txt.TabIndex = 5
        Me.IdNo_txt.Visible = False
        '
        'Fnametxt
        '
        Me.Fnametxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Fnametxt.BackColor = System.Drawing.Color.Azure
        Me.Fnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fnametxt.Location = New System.Drawing.Point(669, 360)
        Me.Fnametxt.Name = "Fnametxt"
        Me.Fnametxt.ReadOnly = True
        Me.Fnametxt.Size = New System.Drawing.Size(100, 22)
        Me.Fnametxt.TabIndex = 5
        Me.Fnametxt.Visible = False
        '
        'printbtn2
        '
        Me.printbtn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.printbtn2.BackColor = System.Drawing.Color.Navy
        Me.printbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.printbtn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.printbtn2.FlatAppearance.BorderSize = 0
        Me.printbtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.printbtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.printbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printbtn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printbtn2.ForeColor = System.Drawing.Color.White
        Me.printbtn2.Location = New System.Drawing.Point(545, 637)
        Me.printbtn2.MaximumSize = New System.Drawing.Size(118, 48)
        Me.printbtn2.Name = "printbtn2"
        Me.printbtn2.Size = New System.Drawing.Size(118, 48)
        Me.printbtn2.TabIndex = 61
        Me.printbtn2.Text = "Save"
        Me.printbtn2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(12, 225)
        Me.Button3.MaximumSize = New System.Drawing.Size(118, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 48)
        Me.Button3.TabIndex = 62
        Me.Button3.Text = "Refresh"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(93, 42)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(190, 30)
        Me.txtSearch.TabIndex = 100
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
        Me.Searchbtn.Location = New System.Drawing.Point(12, 45)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(75, 26)
        Me.Searchbtn.TabIndex = 99
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
        Me.Label8.Size = New System.Drawing.Size(180, 17)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "ID Picture Generator"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Location = New System.Drawing.Point(786, 291)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(570, 341)
        Me.Panel6.TabIndex = 11
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Navy
        Me.Panel8.Location = New System.Drawing.Point(-2, 318)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(570, 21)
        Me.Panel8.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Navy
        Me.Panel9.Location = New System.Drawing.Point(-1, -1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(570, 30)
        Me.Panel9.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 23)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "MDMS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Back of your ID"
        '
        'Addresstxt
        '
        Me.Addresstxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Addresstxt.BackColor = System.Drawing.Color.Azure
        Me.Addresstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Addresstxt.Location = New System.Drawing.Point(669, 556)
        Me.Addresstxt.Name = "Addresstxt"
        Me.Addresstxt.ReadOnly = True
        Me.Addresstxt.Size = New System.Drawing.Size(100, 22)
        Me.Addresstxt.TabIndex = 108
        Me.Addresstxt.Visible = False
        '
        'ContactNo_txt
        '
        Me.ContactNo_txt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ContactNo_txt.BackColor = System.Drawing.Color.Azure
        Me.ContactNo_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactNo_txt.Location = New System.Drawing.Point(669, 528)
        Me.ContactNo_txt.Name = "ContactNo_txt"
        Me.ContactNo_txt.ReadOnly = True
        Me.ContactNo_txt.Size = New System.Drawing.Size(100, 22)
        Me.ContactNo_txt.TabIndex = 109
        Me.ContactNo_txt.Visible = False
        '
        'Gendertxt
        '
        Me.Gendertxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Gendertxt.BackColor = System.Drawing.Color.Azure
        Me.Gendertxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Gendertxt.Location = New System.Drawing.Point(669, 470)
        Me.Gendertxt.Name = "Gendertxt"
        Me.Gendertxt.ReadOnly = True
        Me.Gendertxt.Size = New System.Drawing.Size(100, 22)
        Me.Gendertxt.TabIndex = 110
        Me.Gendertxt.Visible = False
        '
        'Cvlstattxt
        '
        Me.Cvlstattxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cvlstattxt.BackColor = System.Drawing.Color.Azure
        Me.Cvlstattxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cvlstattxt.Location = New System.Drawing.Point(669, 442)
        Me.Cvlstattxt.Name = "Cvlstattxt"
        Me.Cvlstattxt.ReadOnly = True
        Me.Cvlstattxt.Size = New System.Drawing.Size(100, 22)
        Me.Cvlstattxt.TabIndex = 111
        Me.Cvlstattxt.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(136, 225)
        Me.Button1.MaximumSize = New System.Drawing.Size(118, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 48)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(321, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Front ID"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1047, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Back ID"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Navy
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1238, 637)
        Me.Button4.MaximumSize = New System.Drawing.Size(118, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 48)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Search for ID no. or Lastname"
        '
        'Clerk01_IDcardfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1424, 718)
        Me.Controls.Add(Me.Addresstxt)
        Me.Controls.Add(Me.ContactNo_txt)
        Me.Controls.Add(Me.Gendertxt)
        Me.Controls.Add(Me.Cvlstattxt)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Bdaytxt)
        Me.Controls.Add(Me.Searchbtn)
        Me.Controls.Add(Me.Lnametxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.printbtn2)
        Me.Controls.Add(Me.Mnametxt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Fnametxt)
        Me.Controls.Add(Me.IdNo_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clerk01_IDcardfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clerk01_IDcardfrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents printbtn2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Searchbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Fnametxt As TextBox
    Friend WithEvents Mnametxt As TextBox
    Friend WithEvents IdNo_txt As TextBox
    Friend WithEvents Bdaytxt As TextBox
    Friend WithEvents Lnametxt As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents namelbl As Label
    Friend WithEvents genderlbl As Label
    Friend WithEvents civilstatlbl As Label
    Friend WithEvents bgyIDlbl As Label
    Friend WithEvents bdaylbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents addresslbl As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents contactnolbl As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Addresstxt As TextBox
    Friend WithEvents ContactNo_txt As TextBox
    Friend WithEvents Gendertxt As TextBox
    Friend WithEvents Cvlstattxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents bgy_id_no As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewImageColumn
    Friend WithEvents Label4 As Label
End Class
