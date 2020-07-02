<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_mW2dBm = New System.Windows.Forms.Button()
        Me.lbl_mW2dBm = New System.Windows.Forms.Label()
        Me.ud_mW2dBm = New System.Windows.Forms.NumericUpDown()
        Me.ud_dBm2mW = New System.Windows.Forms.NumericUpDown()
        Me.btn_dBm2mW = New System.Windows.Forms.Button()
        Me.lbl_dBm2mW = New System.Windows.Forms.Label()
        Me.BoxOfConversions = New System.Windows.Forms.GroupBox()
        CType(Me.ud_mW2dBm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ud_dBm2mW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BoxOfConversions.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_mW2dBm
        '
        Me.btn_mW2dBm.Location = New System.Drawing.Point(6, 19)
        Me.btn_mW2dBm.Name = "btn_mW2dBm"
        Me.btn_mW2dBm.Size = New System.Drawing.Size(75, 23)
        Me.btn_mW2dBm.TabIndex = 0
        Me.btn_mW2dBm.Text = "mW -> dBm"
        Me.btn_mW2dBm.UseVisualStyleBackColor = True
        '
        'lbl_mW2dBm
        '
        Me.lbl_mW2dBm.AutoSize = True
        Me.lbl_mW2dBm.Location = New System.Drawing.Point(213, 24)
        Me.lbl_mW2dBm.Name = "lbl_mW2dBm"
        Me.lbl_mW2dBm.Size = New System.Drawing.Size(13, 13)
        Me.lbl_mW2dBm.TabIndex = 1
        Me.lbl_mW2dBm.Text = "0"
        '
        'ud_mW2dBm
        '
        Me.ud_mW2dBm.DecimalPlaces = 6
        Me.ud_mW2dBm.Increment = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.ud_mW2dBm.Location = New System.Drawing.Point(87, 22)
        Me.ud_mW2dBm.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.ud_mW2dBm.Minimum = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.ud_mW2dBm.Name = "ud_mW2dBm"
        Me.ud_mW2dBm.Size = New System.Drawing.Size(120, 20)
        Me.ud_mW2dBm.TabIndex = 2
        Me.ud_mW2dBm.Value = New Decimal(New Integer() {1, 0, 0, 393216})
        '
        'ud_dBm2mW
        '
        Me.ud_dBm2mW.DecimalPlaces = 2
        Me.ud_dBm2mW.Location = New System.Drawing.Point(87, 51)
        Me.ud_dBm2mW.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.ud_dBm2mW.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.ud_dBm2mW.Name = "ud_dBm2mW"
        Me.ud_dBm2mW.Size = New System.Drawing.Size(120, 20)
        Me.ud_dBm2mW.TabIndex = 3
        '
        'btn_dBm2mW
        '
        Me.btn_dBm2mW.Location = New System.Drawing.Point(6, 48)
        Me.btn_dBm2mW.Name = "btn_dBm2mW"
        Me.btn_dBm2mW.Size = New System.Drawing.Size(75, 23)
        Me.btn_dBm2mW.TabIndex = 4
        Me.btn_dBm2mW.Text = "dBm -> mW"
        Me.btn_dBm2mW.UseVisualStyleBackColor = True
        '
        'lbl_dBm2mW
        '
        Me.lbl_dBm2mW.AutoSize = True
        Me.lbl_dBm2mW.Location = New System.Drawing.Point(213, 53)
        Me.lbl_dBm2mW.Name = "lbl_dBm2mW"
        Me.lbl_dBm2mW.Size = New System.Drawing.Size(13, 13)
        Me.lbl_dBm2mW.TabIndex = 5
        Me.lbl_dBm2mW.Text = "0"
        '
        'BoxOfConversions
        '
        Me.BoxOfConversions.Controls.Add(Me.btn_mW2dBm)
        Me.BoxOfConversions.Controls.Add(Me.lbl_dBm2mW)
        Me.BoxOfConversions.Controls.Add(Me.lbl_mW2dBm)
        Me.BoxOfConversions.Controls.Add(Me.btn_dBm2mW)
        Me.BoxOfConversions.Controls.Add(Me.ud_mW2dBm)
        Me.BoxOfConversions.Controls.Add(Me.ud_dBm2mW)
        Me.BoxOfConversions.Location = New System.Drawing.Point(82, 66)
        Me.BoxOfConversions.Name = "BoxOfConversions"
        Me.BoxOfConversions.Size = New System.Drawing.Size(301, 86)
        Me.BoxOfConversions.TabIndex = 6
        Me.BoxOfConversions.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 218)
        Me.Controls.Add(Me.BoxOfConversions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(320, 150)
        Me.Name = "Form1"
        Me.Text = "Power Conversion"
        CType(Me.ud_mW2dBm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ud_dBm2mW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BoxOfConversions.ResumeLayout(False)
        Me.BoxOfConversions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_mW2dBm As Button
    Friend WithEvents lbl_mW2dBm As Label
    Friend WithEvents ud_mW2dBm As NumericUpDown
    Friend WithEvents ud_dBm2mW As NumericUpDown
    Friend WithEvents btn_dBm2mW As Button
    Friend WithEvents lbl_dBm2mW As Label
    Friend WithEvents BoxOfConversions As GroupBox
End Class
