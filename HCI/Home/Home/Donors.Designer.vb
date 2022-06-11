<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donors
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
        Me.components = New System.ComponentModel.Container()
        Dim DonorNameLabel As System.Windows.Forms.Label
        Dim GanderLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim AdressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim BloodGroupLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donors))
        Me.BttnDelete = New System.Windows.Forms.Button()
        Me.PatinetsTableAdapter = New BBMS.bloadbakDataSetTableAdapters.PatinetsTableAdapter()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BttnEdite = New System.Windows.Forms.Button()
        Me.PatinetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloadbakDataSet = New BBMS.bloadbakDataSet()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableAdapterManager = New BBMS.bloadbakDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DonorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonorsTableAdapter = New BBMS.bloadbakDataSetTableAdapters.DonorsTableAdapter()
        Me.DonorNameTextBox = New System.Windows.Forms.TextBox()
        Me.GanderTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.BloodGroupTextBox = New System.Windows.Forms.TextBox()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GanderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonorNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GanderDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodGroupDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        DonorNameLabel = New System.Windows.Forms.Label()
        GanderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        AdressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        BloodGroupLabel = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.PatinetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloadbakDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DonorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BttnDelete
        '
        Me.BttnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BttnDelete.ForeColor = System.Drawing.Color.White
        Me.BttnDelete.Location = New System.Drawing.Point(491, 134)
        Me.BttnDelete.Name = "BttnDelete"
        Me.BttnDelete.Size = New System.Drawing.Size(75, 26)
        Me.BttnDelete.TabIndex = 35
        Me.BttnDelete.Text = "Delete"
        Me.BttnDelete.UseVisualStyleBackColor = False
        '
        'PatinetsTableAdapter
        '
        Me.PatinetsTableAdapter.ClearBeforeFill = True
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(DonorNameLabel)
        Me.Panel5.Controls.Add(Me.DonorNameTextBox)
        Me.Panel5.Controls.Add(GanderLabel)
        Me.Panel5.Controls.Add(Me.GanderTextBox)
        Me.Panel5.Controls.Add(AgeLabel)
        Me.Panel5.Controls.Add(Me.AgeTextBox)
        Me.Panel5.Controls.Add(AdressLabel)
        Me.Panel5.Controls.Add(Me.AdressTextBox)
        Me.Panel5.Controls.Add(PhoneLabel)
        Me.Panel5.Controls.Add(Me.PhoneTextBox)
        Me.Panel5.Controls.Add(BloodGroupLabel)
        Me.Panel5.Controls.Add(Me.BloodGroupTextBox)
        Me.Panel5.Controls.Add(Me.BttnDelete)
        Me.Panel5.Controls.Add(Me.BttnEdite)
        Me.Panel5.Controls.Add(Me.BtnAdd)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Enabled = False
        Me.Panel5.Location = New System.Drawing.Point(11, 105)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(864, 205)
        Me.Panel5.TabIndex = 42
        '
        'BttnEdite
        '
        Me.BttnEdite.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BttnEdite.ForeColor = System.Drawing.Color.White
        Me.BttnEdite.Location = New System.Drawing.Point(410, 134)
        Me.BttnEdite.Name = "BttnEdite"
        Me.BttnEdite.Size = New System.Drawing.Size(75, 26)
        Me.BttnEdite.TabIndex = 34
        Me.BttnEdite.Text = "Save"
        Me.BttnEdite.UseVisualStyleBackColor = False
        '
        'PatinetsBindingSource
        '
        Me.PatinetsBindingSource.DataMember = "Patinets"
        Me.PatinetsBindingSource.DataSource = Me.BloadbakDataSet
        '
        'BloadbakDataSet
        '
        Me.BloadbakDataSet.DataSetName = "bloadbakDataSet"
        Me.BloadbakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(329, 134)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 26)
        Me.BtnAdd.TabIndex = 33
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tajawal ExtraBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(390, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 29)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Donors list"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DataGridView2)
        Me.Panel7.Controls.Add(Me.DataGridView1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(11, 105)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(864, 381)
        Me.Panel7.TabIndex = 43
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DonorNameDataGridViewTextBoxColumn, Me.GanderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AdressDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.BloodGroupDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DonorsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(864, 381)
        Me.DataGridView1.TabIndex = 0
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DonorsTableAdapter = Nothing
        Me.TableAdapterManager.PatinetsTableAdapter = Me.PatinetsTableAdapter
        Me.TableAdapterManager.UpdateOrder = BBMS.bloadbakDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(11, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 105)
        Me.Panel1.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(888, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(110, 70)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(4, 29)
        Me.Panel6.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("29LT Bukra Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(764, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Dashbord"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("29LT Bukra Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(267, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Patinets"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("29LT Bukra Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(116, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Donors"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("29LT Bukra Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(574, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Blood Trasfer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("29LT Bukra Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(429, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Donate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tajawal ExtraBold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(186, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(580, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Blood Bank System Managemet"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(875, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 486)
        Me.Panel3.TabIndex = 41
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 170)
        Me.Panel4.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 486)
        Me.Panel2.TabIndex = 40
        '
        'DonorsBindingSource
        '
        Me.DonorsBindingSource.DataMember = "Donors"
        Me.DonorsBindingSource.DataSource = Me.BloadbakDataSet
        '
        'DonorsTableAdapter
        '
        Me.DonorsTableAdapter.ClearBeforeFill = True
        '
        'DonorNameLabel
        '
        DonorNameLabel.AutoSize = True
        DonorNameLabel.Location = New System.Drawing.Point(111, 23)
        DonorNameLabel.Name = "DonorNameLabel"
        DonorNameLabel.Size = New System.Drawing.Size(79, 18)
        DonorNameLabel.TabIndex = 39
        DonorNameLabel.Text = "Donor Name:"
        '
        'DonorNameTextBox
        '
        Me.DonorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorsBindingSource, "DonorName", True))
        Me.DonorNameTextBox.Location = New System.Drawing.Point(196, 20)
        Me.DonorNameTextBox.Name = "DonorNameTextBox"
        Me.DonorNameTextBox.Size = New System.Drawing.Size(211, 25)
        Me.DonorNameTextBox.TabIndex = 40
        '
        'GanderLabel
        '
        GanderLabel.AutoSize = True
        GanderLabel.Location = New System.Drawing.Point(111, 54)
        GanderLabel.Name = "GanderLabel"
        GanderLabel.Size = New System.Drawing.Size(50, 18)
        GanderLabel.TabIndex = 41
        GanderLabel.Text = "Gander:"
        '
        'GanderTextBox
        '
        Me.GanderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorsBindingSource, "Gander", True))
        Me.GanderTextBox.Location = New System.Drawing.Point(196, 51)
        Me.GanderTextBox.Name = "GanderTextBox"
        Me.GanderTextBox.Size = New System.Drawing.Size(211, 25)
        Me.GanderTextBox.TabIndex = 42
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(111, 85)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(32, 18)
        AgeLabel.TabIndex = 43
        AgeLabel.Text = "Age:"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(196, 82)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(211, 25)
        Me.AgeTextBox.TabIndex = 44
        '
        'AdressLabel
        '
        AdressLabel.AutoSize = True
        AdressLabel.Location = New System.Drawing.Point(426, 20)
        AdressLabel.Name = "AdressLabel"
        AdressLabel.Size = New System.Drawing.Size(47, 18)
        AdressLabel.TabIndex = 45
        AdressLabel.Text = "Adress:"
        '
        'AdressTextBox
        '
        Me.AdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorsBindingSource, "Adress", True))
        Me.AdressTextBox.Location = New System.Drawing.Point(511, 17)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(230, 25)
        Me.AdressTextBox.TabIndex = 46
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(426, 51)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(44, 18)
        PhoneLabel.TabIndex = 47
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorsBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(511, 48)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(230, 25)
        Me.PhoneTextBox.TabIndex = 48
        '
        'BloodGroupLabel
        '
        BloodGroupLabel.AutoSize = True
        BloodGroupLabel.Location = New System.Drawing.Point(426, 82)
        BloodGroupLabel.Name = "BloodGroupLabel"
        BloodGroupLabel.Size = New System.Drawing.Size(75, 18)
        BloodGroupLabel.TabIndex = 49
        BloodGroupLabel.Text = "Blood Group:"
        '
        'BloodGroupTextBox
        '
        Me.BloodGroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorsBindingSource, "BloodGroup", True))
        Me.BloodGroupTextBox.Location = New System.Drawing.Point(511, 79)
        Me.BloodGroupTextBox.Name = "BloodGroupTextBox"
        Me.BloodGroupTextBox.Size = New System.Drawing.Size(230, 25)
        Me.BloodGroupTextBox.TabIndex = 50
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DonorNameDataGridViewTextBoxColumn
        '
        Me.DonorNameDataGridViewTextBoxColumn.DataPropertyName = "DonorName"
        Me.DonorNameDataGridViewTextBoxColumn.HeaderText = "DonorName"
        Me.DonorNameDataGridViewTextBoxColumn.Name = "DonorNameDataGridViewTextBoxColumn"
        '
        'GanderDataGridViewTextBoxColumn
        '
        Me.GanderDataGridViewTextBoxColumn.DataPropertyName = "Gander"
        Me.GanderDataGridViewTextBoxColumn.HeaderText = "Gander"
        Me.GanderDataGridViewTextBoxColumn.Name = "GanderDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'AdressDataGridViewTextBoxColumn
        '
        Me.AdressDataGridViewTextBoxColumn.DataPropertyName = "Adress"
        Me.AdressDataGridViewTextBoxColumn.HeaderText = "Adress"
        Me.AdressDataGridViewTextBoxColumn.Name = "AdressDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'BloodGroupDataGridViewTextBoxColumn
        '
        Me.BloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn.Name = "BloodGroupDataGridViewTextBoxColumn"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.DonorNameDataGridViewTextBoxColumn1, Me.GanderDataGridViewTextBoxColumn1, Me.AgeDataGridViewTextBoxColumn1, Me.AdressDataGridViewTextBoxColumn1, Me.PhoneDataGridViewTextBoxColumn1, Me.BloodGroupDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.DonorsBindingSource
        Me.DataGridView2.GridColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(82, 219)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(721, 150)
        Me.DataGridView2.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'DonorNameDataGridViewTextBoxColumn1
        '
        Me.DonorNameDataGridViewTextBoxColumn1.DataPropertyName = "DonorName"
        Me.DonorNameDataGridViewTextBoxColumn1.HeaderText = "DonorName"
        Me.DonorNameDataGridViewTextBoxColumn1.Name = "DonorNameDataGridViewTextBoxColumn1"
        '
        'GanderDataGridViewTextBoxColumn1
        '
        Me.GanderDataGridViewTextBoxColumn1.DataPropertyName = "Gander"
        Me.GanderDataGridViewTextBoxColumn1.HeaderText = "Gander"
        Me.GanderDataGridViewTextBoxColumn1.Name = "GanderDataGridViewTextBoxColumn1"
        '
        'AgeDataGridViewTextBoxColumn1
        '
        Me.AgeDataGridViewTextBoxColumn1.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn1.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn1.Name = "AgeDataGridViewTextBoxColumn1"
        '
        'AdressDataGridViewTextBoxColumn1
        '
        Me.AdressDataGridViewTextBoxColumn1.DataPropertyName = "Adress"
        Me.AdressDataGridViewTextBoxColumn1.HeaderText = "Adress"
        Me.AdressDataGridViewTextBoxColumn1.Name = "AdressDataGridViewTextBoxColumn1"
        '
        'PhoneDataGridViewTextBoxColumn1
        '
        Me.PhoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn1.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn1.Name = "PhoneDataGridViewTextBoxColumn1"
        '
        'BloodGroupDataGridViewTextBoxColumn1
        '
        Me.BloodGroupDataGridViewTextBoxColumn1.DataPropertyName = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn1.HeaderText = "BloodGroup"
        Me.BloodGroupDataGridViewTextBoxColumn1.Name = "BloodGroupDataGridViewTextBoxColumn1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(812, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'Donors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(885, 486)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Tajawal ExtraBold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Donors"
        Me.Text = "Donors"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PatinetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloadbakDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DonorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BttnDelete As System.Windows.Forms.Button
    Friend WithEvents PatinetsTableAdapter As BBMS.bloadbakDataSetTableAdapters.PatinetsTableAdapter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BttnEdite As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PatinetsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BloadbakDataSet As BBMS.bloadbakDataSet
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TableAdapterManager As BBMS.bloadbakDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DonorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DonorsTableAdapter As BBMS.bloadbakDataSetTableAdapters.DonorsTableAdapter
    Friend WithEvents DonorNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GanderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodGroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonorNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GanderDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdressDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodGroupDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonorNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GanderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
