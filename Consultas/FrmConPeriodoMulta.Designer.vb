<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConPeriodoMulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConPeriodoMulta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.DgdMultas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLoc = New System.Windows.Forms.Button()
        CType(Me.DgdMultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Fim"
        '
        'DtpFim
        '
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(390, 40)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(103, 27)
        Me.DtpFim.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Início"
        '
        'DtpIni
        '
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(212, 40)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(103, 27)
        Me.DtpIni.TabIndex = 68
        '
        'DgdMultas
        '
        Me.DgdMultas.AllowUserToAddRows = False
        Me.DgdMultas.AllowUserToDeleteRows = False
        Me.DgdMultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdMultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DgdMultas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdMultas.Location = New System.Drawing.Point(10, 101)
        Me.DgdMultas.Margin = New System.Windows.Forms.Padding(1)
        Me.DgdMultas.Name = "DgdMultas"
        Me.DgdMultas.ReadOnly = True
        Me.DgdMultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdMultas.Size = New System.Drawing.Size(685, 394)
        Me.DgdMultas.TabIndex = 75
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "MorMul"
        Me.Column1.HeaderText = "Nome do Morador"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 145
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "AptMul"
        Me.Column2.HeaderText = "Apartamento"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 122
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "BloMul"
        Me.Column3.HeaderText = "Bloco"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 72
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ValMul"
        Me.Column4.HeaderText = "Valor"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 68
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "MotMul"
        Me.Column5.HeaderText = "Motivo"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 81
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "DtMul"
        Me.Column6.HeaderText = "Data"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 66
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "HrMul"
        Me.Column7.HeaderText = "Horário"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 85
        '
        'btnLoc
        '
        Me.btnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoc.Location = New System.Drawing.Point(603, 499)
        Me.btnLoc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(92, 32)
        Me.btnLoc.TabIndex = 76
        Me.btnLoc.Text = "Localizar"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'FrmConPeriodoMulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 536)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.DgdMultas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpIni)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmConPeriodoMulta"
        Me.Text = "                                                                                 " & _
    "   CONSULTA DE MULTAS POR PERÍODO"
        CType(Me.DgdMultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DgdMultas As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLoc As System.Windows.Forms.Button
End Class
