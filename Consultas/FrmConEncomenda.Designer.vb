<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConEncomenda
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
        Me.txtCampo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgdEncomenda = New System.Windows.Forms.DataGridView()
        Me.ClmEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSair = New System.Windows.Forms.Button()
        CType(Me.DgdEncomenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCampo
        '
        Me.txtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCampo.Location = New System.Drawing.Point(11, 35)
        Me.txtCampo.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.Size = New System.Drawing.Size(336, 29)
        Me.txtCampo.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Pesquisa por Nome ou Número de Apartamento "
        '
        'DgdEncomenda
        '
        Me.DgdEncomenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdEncomenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmEnt, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8, Me.Column9})
        Me.DgdEncomenda.Location = New System.Drawing.Point(11, 76)
        Me.DgdEncomenda.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.DgdEncomenda.Name = "DgdEncomenda"
        Me.DgdEncomenda.Size = New System.Drawing.Size(872, 258)
        Me.DgdEncomenda.TabIndex = 58
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
        Me.Column4.DataPropertyName = "datenc"
        Me.Column4.HeaderText = "Data de Entrega"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "horenc"
        Me.Column5.HeaderText = "Hora da Entrega"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.DataPropertyName = "descenc"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column7.HeaderText = "Descrição"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 128
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "numapt"
        Me.Column8.HeaderText = "Número do Apartamento"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "bloapt"
        Me.Column9.HeaderText = "Bloco do Apartamento"
        Me.Column9.Name = "Column9"
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(408, 348)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(125, 57)
        Me.btnSair.TabIndex = 57
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'FrmConEncomenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 418)
        Me.Controls.Add(Me.txtCampo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdEncomenda)
        Me.Controls.Add(Me.btnSair)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FrmConEncomenda"
        Me.Text = "FrmConEncomenda"
        CType(Me.DgdEncomenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgdEncomenda As System.Windows.Forms.DataGridView
    Friend WithEvents ClmEnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
