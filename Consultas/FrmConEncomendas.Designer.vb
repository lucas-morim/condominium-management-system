<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConEncomendas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConEncomendas))
        Me.DgdEncomenda = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCampo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgdEncomenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgdEncomenda
        '
        Me.DgdEncomenda.AllowUserToAddRows = False
        Me.DgdEncomenda.AllowUserToDeleteRows = False
        Me.DgdEncomenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdEncomenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdEncomenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8, Me.Column9, Me.datRec, Me.horRec, Me.Column1, Me.Column2, Me.Column6})
        Me.DgdEncomenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdEncomenda.Location = New System.Drawing.Point(12, 87)
        Me.DgdEncomenda.Margin = New System.Windows.Forms.Padding(1)
        Me.DgdEncomenda.Name = "DgdEncomenda"
        Me.DgdEncomenda.ReadOnly = True
        Me.DgdEncomenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdEncomenda.Size = New System.Drawing.Size(1036, 394)
        Me.DgdEncomenda.TabIndex = 71
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
        Me.horRec.HeaderText = "Horário da Entrega"
        Me.horRec.Name = "horRec"
        Me.horRec.ReadOnly = True
        Me.horRec.Width = 147
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codenc"
        Me.Column1.HeaderText = "codEnc"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "codmor"
        Me.Column2.HeaderText = "codMor"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "etgenc"
        Me.Column6.HeaderText = "etgEnc"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'txtCampo
        '
        Me.txtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCampo.Location = New System.Drawing.Point(12, 40)
        Me.txtCampo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.Size = New System.Drawing.Size(403, 24)
        Me.txtCampo.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 18)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Pesquisa por Nome do Morador"
        '
        'FrmConEncomendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 494)
        Me.Controls.Add(Me.txtCampo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdEncomenda)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConEncomendas"
        Me.Text = "                                                                                 " & _
    "                                                            CONSULTA DE ENCOMEND" & _
    "AS"
        CType(Me.DgdEncomenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdEncomenda As DataGridView
    Friend WithEvents txtCampo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents datRec As DataGridViewTextBoxColumn
    Friend WithEvents horRec As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
