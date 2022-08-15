<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patinets
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
        Dim PatinetsNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim AdressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim BloodGroupLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(patinets))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BttnDelete = New System.Windows.Forms.Button()
        Me.BttnEdite = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PatinetsNameTextBox = New System.Windows.Forms.TextBox()
        Me.PatinetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloadbakDataSet = New BBMS.bloadbakDataSet()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.BloodGroupTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatinetsNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatinetsTableAdapter = New BBMS.bloadbakDataSetTableAdapters.PatinetsTableAdapter()
        Me.TableAdapterManager = New BBMS.bloadbakDataSetTableAdapters.TableAdapterManager()
        PatinetsNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        AdressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        BloodGroupLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PatinetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloadbakDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatinetsNameLabel
        '
        PatinetsNameLabel.AutoSize = True
        PatinetsNameLabel.Location = New System.Drawing.Point(53, 38)
        PatinetsNameLabel.Name = "PatinetsNameLabel"
        PatinetsNameLabel.Size = New System.Drawing.Size(97, 19)
        PatinetsNameLabel.TabIndex = 39
        PatinetsNameLabel.Text = "patinets Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(334, 38)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(55, 19)
        GenderLabel.TabIndex = 41
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(588, 38)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(35, 19)
        AgeLabel.TabIndex = 43
        AgeLabel.Text = "Age:"
        '
        'AdressLabel
        '
        AdressLabel.AutoSize = True
        AdressLabel.Location = New System.Drawing.Point(53, 102)
        AdressLabel.Name = "AdressLabel"
        AdressLabel.Size = New System.Drawing.Size(53, 19)
        AdressLabel.TabIndex = 45
        AdressLabel.Text = "Adress:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(334, 102)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(48, 19)
        PhoneLabel.TabIndex = 47
        PhoneLabel.Text = "Phone:"
        '
        'BloodGroupLabel
        '
        BloodGroupLabel.AutoSize = True
        BloodGroupLabel.Location = New System.Drawing.Point(588, 102)
        BloodGroupLabel.Name = "BloodGroupLabel"
        BloodGroupLabel.Size = New System.Drawing.Size(82, 19)
        BloodGroupLabel.TabIndex = 49
        BloodGroupLabel.Text = "Blood Group:"
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
        Me.Panel3.Location = New System.Drawing.Point(930, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 442)
        Me.Panel3.TabIndex = 28
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
        Me.Panel2.Location = New System.Drawing.Point(0, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 442)
        Me.Panel2.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 105)
        Me.Panel1.TabIndex = 26
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
        Me.Panel6.Location = New System.Drawing.Point(263, 70)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(4, 29)
        Me.Panel6.TabIndex = 24
        '
        'BttnDelete
        '
        Me.BttnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BttnDelete.ForeColor = System.Drawing.Color.White
        Me.BttnDelete.Location = New System.Drawing.Point(511, 157)
        Me.BttnDelete.Name = "BttnDelete"
        Me.BttnDelete.Size = New System.Drawing.Size(75, 26)
        Me.BttnDelete.TabIndex = 35
        Me.BttnDelete.Text = "Delete"
        Me.BttnDelete.UseVisualStyleBackColor = False
        '
        'BttnEdite
        '
        Me.BttnEdite.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BttnEdite.ForeColor = System.Drawing.Color.White
        Me.BttnEdite.Location = New System.Drawing.Point(430, 157)
        Me.BttnEdite.Name = "BttnEdite"
        Me.BttnEdite.Size = New System.Drawing.Size(75, 26)
        Me.BttnEdite.TabIndex = 34
        Me.BttnEdite.Text = "Save"
        Me.BttnEdite.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(349, 157)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 26)
        Me.BtnAdd.TabIndex = 33
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(PatinetsNameLabel)
        Me.Panel5.Controls.Add(Me.BttnDelete)
        Me.Panel5.Controls.Add(Me.BttnEdite)
        Me.Panel5.Controls.Add(Me.PatinetsNameTextBox)
        Me.Panel5.Controls.Add(Me.BtnAdd)
        Me.Panel5.Controls.Add(GenderLabel)
        Me.Panel5.Controls.Add(Me.GenderTextBox)
        Me.Panel5.Controls.Add(AgeLabel)
        Me.Panel5.Controls.Add(Me.AgeTextBox)
        Me.Panel5.Controls.Add(AdressLabel)
        Me.Panel5.Controls.Add(Me.AdressTextBox)
        Me.Panel5.Controls.Add(PhoneLabel)
        Me.Panel5.Controls.Add(Me.PhoneTextBox)
        Me.Panel5.Controls.Add(BloodGroupLabel)
        Me.Panel5.Controls.Add(Me.BloodGroupTextBox)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(11, 105)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(919, 222)
        Me.Panel5.TabIndex = 36
        '
        'PatinetsNameTextBox
        '
        Me.PatinetsNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatinetsBindingSource, "patinetsName", True))
        Me.PatinetsNameTextBox.Location = New System.Drawing.Point(156, 34)
        Me.PatinetsNameTextBox.Name = "PatinetsNameTextBox"
        Me.PatinetsNameTextBox.Size = New System.Drawing.Size(149, 27)
        Me.PatinetsNameTextBox.TabIndex = 40
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
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatinetsBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(395, 34)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(142, 27)
        Me.GenderTextBox.TabIndex = 42
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatinetsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(676, 34)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(163, 27)
        Me.AgeTextBox.TabIndex = 44
        '
        'AdressTextBox
        '
        Me.AdressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatinetsBindingSource, "Adress", True))
        Me.AdressTextBox.Location = New System.Drawing.Point(156, 98)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(149, 27)
        Me.AdressTextBox.TabIndex = 46
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatinetsBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(395, 98)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(142, 27)
        Me.PhoneTextBox.TabIndex = 48
        '
        'BloodGroupTextBox
        '
        Me.BloodGroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatinetsBindingSource, "BloodGroup", True))
        Me.BloodGroupTextBox.Location = New System.Drawing.Point(676, 98)
        Me.BloodGroupTextBox.Name = "BloodGroupTextBox"
        Me.BloodGroupTextBox.Size = New System.Drawing.Size(163, 27)
        Me.BloodGroupTextBox.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tajawal ExtraBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(390, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 29)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Patinets list"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DataGridView1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(11, 327)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(919, 220)
        Me.Panel7.TabIndex = 38
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PatinetsNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AdressDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.BloodGroupDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatinetsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(919, 220)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'PatinetsNameDataGridViewTextBoxColumn
        '
        Me.PatinetsNameDataGridViewTextBoxColumn.DataPropertyName = "patinetsName"
        Me.PatinetsNameDataGridViewTextBoxColumn.HeaderText = "patinetsName"
        Me.PatinetsNameDataGridViewTextBoxColumn.Name = "PatinetsNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
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
        'PatinetsTableAdapter
        '
        Me.PatinetsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DonorsTableAdapter = Nothing
        Me.TableAdapterManager.PatinetsTableAdapter = Me.PatinetsTableAdapter
        Me.TableAdapterManager.UpdateOrder = BBMS.bloadbakDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'patinets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 547)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tajawal ExtraBold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "patinets"
        Me.Text = "patinets"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PatinetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloadbakDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BttnDelete As System.Windows.Forms.Button
    Friend WithEvents BttnEdite As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BloadbakDataSet As BBMS.bloadbakDataSet
    Friend WithEvents PatinetsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatinetsTableAdapter As BBMS.bloadbakDataSetTableAdapters.PatinetsTableAdapter
    Friend WithEvents TableAdapterManager As BBMS.bloadbakDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatinetsNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodGroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatinetsNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodGroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
