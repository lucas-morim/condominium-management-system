<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConPeriodoEncomenda
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConPeriodoEncomenda))
        Me.DgdEncomenda = New System.Windows.Forms.DataGridView()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdEncomenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgdEncomenda
        '
        Me.DgdEncomenda.AllowUserToAddRows = False
        Me.DgdEncomenda.AllowUserToDeleteRows = False
        Me.DgdEncomenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdEncomenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdEncomenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8, Me.Column9, Me.datRec, Me.horRec})
        Me.DgdEncomenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdEncomenda.Location = New System.Drawing.Point(12, 87)
        Me.DgdEncomenda.Margin = New System.Windows.Forms.Padding(1)
        Me.DgdEncomenda.Name = "DgdEncomenda"
        Me.DgdEncomenda.ReadOnly = True
        Me.DgdEncomenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdEncomenda.Size = New System.Drawing.Size(1183, 394)
        Me.DgdEncomenda.TabIndex = 3
        '
        'DtpIni
        '
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(445, 43)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(103, 27)
        Me.DtpIni.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(470, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Início"
        '
        'btnLoc
        '
        Me.btnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoc.Location = New System.Drawing.Point(825, 38)
        Me.btnLoc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(92, 32)
        Me.btnLoc.TabIndex = 2
        Me.btnLoc.Text = "Localizar"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(649, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Fim"
        '
        'DtpFim
        '
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(623, 43)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(103, 27)
        Me.DtpFim.TabIndex = 1
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "nommor"
        Me.Column3.HeaderText = "Nome do Morador"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 145
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "datent"
        Me.Column4.HeaderText = "Data Recebida"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 121
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "horent"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column5.HeaderText = "Hora da Recebida"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 141
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.DataPropertyName = "descenc"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column7.HeaderText = "Descrição"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 99
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "numapt"
        Me.Column8.HeaderText = "Número do Apartamento"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 184
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "bloapt"
        Me.Column9.HeaderText = "Bloco do Apartamento"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 169
        '
        'datRec
        '
        Me.datRec.DataPropertyName = "datrec"
        Me.datRec.HeaderText = "Data da Entrega"
        Me.datRec.Name = "datRec"
        Me.datRec.ReadOnly = True
        Me.datRec.Width = 130
        '
        'horRec
        '
        Me.horRec.DataPropertyName = "horrec"
        DataGridViewCellStyle3.Format = "t"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.horRec.DefaultCellStyle = DataGridViewCellStyle3
        Me.horRec.HeaderText = "Horário da Entrega"
        Me.horRec.Name = "horRec"
        Me.horRec.ReadOnly = True
        Me.horRec.Width = 147
        '
        'FrmConPeriodoEncomenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 530)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.DgdEncomenda)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConPeriodoEncomenda"
        Me.Text = "                                                                                 " & _
    "                                                             CONSULTA DE ENCOMEN" & _
    "DA POR PERÍODO"
        CType(Me.DgdEncomenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdEncomenda As System.Windows.Forms.DataGridView
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLoc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents horRec As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
