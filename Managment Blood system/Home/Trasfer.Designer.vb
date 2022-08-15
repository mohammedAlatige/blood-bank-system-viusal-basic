<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trasfer
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
        Dim GanderLabel As System.Windows.Forms.Label
        Dim BloodGroupLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trasfer))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.GanderTextBox = New System.Windows.Forms.TextBox()
        Me.DonorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloadbakDataSet = New BBMS.bloadbakDataSet()
        Me.BloodGroupTextBox = New System.Windows.Forms.TextBox()
        Me.DonorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DonorNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DonorNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DonorsTableAdapter = New BBMS.bloadbakDataSetTableAdapters.DonorsTableAdapter()
        Me.TableAdapterManager = New BBMS.bloadbakDataSetTableAdapters.TableAdapterManager()
        GanderLabel = New System.Windows.Forms.Label()
        BloodGroupLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.DonorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloadbakDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GanderLabel
        '
        GanderLabel.AutoSize = True
        GanderLabel.Location = New System.Drawing.Point(326, 100)
        GanderLabel.Name = "GanderLabel"
        GanderLabel.Size = New System.Drawing.Size(54, 19)
        GanderLabel.TabIndex = 44
        GanderLabel.Text = "Gander:"
        '
        'BloodGroupLabel
        '
        BloodGroupLabel.AutoSize = True
        BloodGroupLabel.Location = New System.Drawing.Point(591, 100)
        BloodGroupLabel.Name = "BloodGroupLabel"
        BloodGroupLabel.Size = New System.Drawing.Size(82, 19)
        BloodGroupLabel.TabIndex = 52
        BloodGroupLabel.Text = "Blood Group:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(558, 70)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 29)
        Me.Panel6.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("29LT Bukra Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(746, 74)
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
        Me.Label4.Location = New System.Drawing.Point(564, 74)
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
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(937, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(14, 565)
        Me.Panel3.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(14, 565)
        Me.Panel2.TabIndex = 29
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
        Me.Panel1.Size = New System.Drawing.Size(951, 105)
        Me.Panel1.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(905, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 27)
        Me.TextBox1.TabIndex = 27
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(GanderLabel)
        Me.Panel5.Controls.Add(Me.BtnAdd)
        Me.Panel5.Controls.Add(Me.GanderTextBox)
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Controls.Add(Me.BloodGroupTextBox)
        Me.Panel5.Controls.Add(BloodGroupLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(14, 105)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(923, 195)
        Me.Panel5.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("29LT Bukra Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(397, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 19)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Blood Transfer"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(386, 152)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(170, 26)
        Me.BtnAdd.TabIndex = 37
        Me.BtnAdd.Text = "Transfer"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GanderTextBox
        '
        Me.GanderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorsBindingSource, "Gander", True))
        Me.GanderTextBox.Location = New System.Drawing.Point(386, 97)
        Me.GanderTextBox.Name = "GanderTextBox"
        Me.GanderTextBox.Size = New System.Drawing.Size(172, 27)
        Me.GanderTextBox.TabIndex = 45
        '
        'DonorsBindingSource
        '
        Me.DonorsBindingSource.DataMember = "Donors"
        Me.DonorsBindingSource.DataSource = Me.BloadbakDataSet
        '
        'BloadbakDataSet
        '
        Me.BloadbakDataSet.DataSetName = "bloadbakDataSet"
        Me.BloadbakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BloodGroupTextBox
        '
        Me.BloodGroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonorsBindingSource, "BloodGroup", True))
        Me.BloodGroupTextBox.Location = New System.Drawing.Point(682, 97)
        Me.BloodGroupTextBox.Name = "BloodGroupTextBox"
        Me.BloodGroupTextBox.Size = New System.Drawing.Size(160, 27)
        Me.BloodGroupTextBox.TabIndex = 53
        '
        'DonorsDataGridView
        '
        Me.DonorsDataGridView.AutoGenerateColumns = False
        Me.DonorsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DonorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DonorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DonorsDataGridView.DataSource = Me.DonorsBindingSource
        Me.DonorsDataGridView.GridColor = System.Drawing.Color.White
        Me.DonorsDataGridView.Location = New System.Drawing.Point(62, 328)
        Me.DonorsDataGridView.Name = "DonorsDataGridView"
        Me.DonorsDataGridView.Size = New System.Drawing.Size(825, 256)
        Me.DonorsDataGridView.TabIndex = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DonorName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DonorName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gander"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gander"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Adress"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Adress"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "BloodGroup"
        Me.DataGridViewTextBoxColumn7.HeaderText = "BloodGroup"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonorNameToolStripLabel, Me.DonorNameToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(14, 300)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(923, 25)
        Me.FillByToolStrip.TabIndex = 54
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'DonorNameToolStripLabel
        '
        Me.DonorNameToolStripLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DonorNameToolStripLabel.ForeColor = System.Drawing.Color.White
        Me.DonorNameToolStripLabel.Name = "DonorNameToolStripLabel"
        Me.DonorNameToolStripLabel.Size = New System.Drawing.Size(75, 22)
        Me.DonorNameToolStripLabel.Text = "DonorName:"
        '
        'DonorNameToolStripTextBox
        '
        Me.DonorNameToolStripTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DonorNameToolStripTextBox.Name = "DonorNameToolStripTextBox"
        Me.DonorNameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.ForeColor = System.Drawing.Color.White
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'DonorsTableAdapter
        '
        Me.DonorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DonorsTableAdapter = Me.DonorsTableAdapter
        Me.TableAdapterManager.PatinetsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BBMS.bloadbakDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Trasfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(951, 670)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DonorsDataGridView)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tajawal ExtraBold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Trasfer"
        Me.Text = "Trasfer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DonorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloadbakDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BloadbakDataSet As BBMS.bloadbakDataSet
    Friend WithEvents DonorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DonorsTableAdapter As BBMS.bloadbakDataSetTableAdapters.DonorsTableAdapter
    Friend WithEvents TableAdapterManager As BBMS.bloadbakDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DonorsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GanderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodGroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents DonorNameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DonorNameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
