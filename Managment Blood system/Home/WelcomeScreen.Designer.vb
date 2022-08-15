<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcomeScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Myprogers = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.proLable = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tajawal", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(92, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blood Bank Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(178, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Myprogers
        '
        Me.Myprogers.Location = New System.Drawing.Point(9, 244)
        Me.Myprogers.Name = "Myprogers"
        Me.Myprogers.Size = New System.Drawing.Size(227, 11)
        Me.Myprogers.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tajawal", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Looding Moduels .."
        '
        'proLable
        '
        Me.proLable.AutoSize = True
        Me.proLable.BackColor = System.Drawing.Color.Transparent
        Me.proLable.Font = New System.Drawing.Font("Tajawal", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proLable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.proLable.Location = New System.Drawing.Point(150, 219)
        Me.proLable.Name = "proLable"
        Me.proLable.Size = New System.Drawing.Size(22, 22)
        Me.proLable.TabIndex = 4
        Me.proLable.Text = "%"
        '
        'Timer1
        '
        '
        'welcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(4.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(568, 267)
        Me.Controls.Add(Me.proLable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Myprogers)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tajawal", 6.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "welcomeScreen"
        Me.Text = "welcomeScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Myprogers As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents proLable As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
