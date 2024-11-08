<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEncomenda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEncomenda))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DgdEncomenda = New System.Windows.Forms.DataGridView()
        Me.ClmEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCampo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgdEncomenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(827, 29)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 49)
        Me.btnAdd.TabIndex = 50
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DgdEncomenda
        '
        Me.DgdEncomenda.AllowUserToAddRows = False
        Me.DgdEncomenda.AllowUserToDeleteRows = False
        Me.DgdEncomenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdEncomenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmEnt, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8, Me.Column9, Me.Column1, Me.Column6, Me.Column10})
        Me.DgdEncomenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdEncomenda.Location = New System.Drawing.Point(16, 96)
        Me.DgdEncomenda.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.DgdEncomenda.Name = "DgdEncomenda"
        Me.DgdEncomenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgdEncomenda.Size = New System.Drawing.Size(872, 367)
        Me.DgdEncomenda.TabIndex = 53
        '
        'ClmEnt
        '
        Me.ClmEnt.DataPropertyName = "codenc"
        Me.ClmEnt.HeaderText = "Código"
        Me.ClmEnt.Name = "ClmEnt"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "codmor"
        Me.Column2.HeaderText = "Código de Morador"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "nommor"
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "datent"
        Me.Column4.HeaderText = "Data de Entrega"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "horent"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column5.HeaderText = "Hora da Entrega"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.DataPropertyName = "descenc"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column7.HeaderText = "Descrição"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 99
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "numapt"
        Me.Column8.HeaderText = "Número do Apartamento"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 110
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "bloapt"
        Me.Column9.HeaderText = "Bloco do Apartamento"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 110
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "etgenc"
        Me.Column1.HeaderText = "Entregue"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Visible = False
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "datRec"
        Me.Column6.HeaderText = "DataRec"
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "horRec"
        Me.Column10.HeaderText = "HoraRec"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        '
        'txtCampo
        '
        Me.txtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCampo.Location = New System.Drawing.Point(16, 43)
        Me.txtCampo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.Size = New System.Drawing.Size(276, 24)
        Me.txtCampo.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 18)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Pesquisa por Nome ou Número de Apartamento "
        '
        'FrmEncomenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(900, 477)
        Me.Controls.Add(Me.txtCampo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdEncomenda)
        Me.Controls.Add(Me.btnAdd)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmEncomenda"
        Me.Text = "                                                                                 " & _
    "                                      REGISTRO DE ENCOMENDAS"
        CType(Me.DgdEncomenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents DgdEncomenda As DataGridView
    Friend WithEvents txtCampo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClmEnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
