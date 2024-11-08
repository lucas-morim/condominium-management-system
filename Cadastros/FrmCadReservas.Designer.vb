<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadReservas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadReservas))
        Me.txtNomMor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQtdPar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodArea = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscMor = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnBuscArea = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQtdMax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCodMor = New System.Windows.Forms.TextBox()
        Me.txtCodRes = New System.Windows.Forms.TextBox()
        Me.DgdReserva = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCampo = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtHor = New System.Windows.Forms.ComboBox()
        CType(Me.DgdReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomMor
        '
        Me.txtNomMor.Enabled = False
        Me.txtNomMor.Location = New System.Drawing.Point(12, 114)
        Me.txtNomMor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomMor.Name = "txtNomMor"
        Me.txtNomMor.Size = New System.Drawing.Size(195, 27)
        Me.txtNomMor.TabIndex = 4
        Me.txtNomMor.Tag = "h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nome do Morador"
        '
        'txtQtdPar
        '
        Me.txtQtdPar.Enabled = False
        Me.txtQtdPar.Location = New System.Drawing.Point(259, 114)
        Me.txtQtdPar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQtdPar.Name = "txtQtdPar"
        Me.txtQtdPar.Size = New System.Drawing.Size(148, 27)
        Me.txtQtdPar.TabIndex = 6
        Me.txtQtdPar.Tag = "h"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Número Participantes"
        '
        'txtCodArea
        '
        Me.txtCodArea.Enabled = False
        Me.txtCodArea.Location = New System.Drawing.Point(200, 313)
        Me.txtCodArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodArea.Name = "txtCodArea"
        Me.txtCodArea.Size = New System.Drawing.Size(47, 27)
        Me.txtCodArea.TabIndex = 1
        Me.txtCodArea.Tag = "x"
        Me.txtCodArea.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Área"
        '
        'btnBuscMor
        '
        Me.btnBuscMor.Location = New System.Drawing.Point(213, 114)
        Me.btnBuscMor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscMor.Name = "btnBuscMor"
        Me.btnBuscMor.Size = New System.Drawing.Size(38, 27)
        Me.btnBuscMor.TabIndex = 5
        Me.btnBuscMor.Text = "..."
        Me.btnBuscMor.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(418, 14)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(97, 51)
        Me.btnNovo.TabIndex = 10
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnCad
        '
        Me.btnCad.Location = New System.Drawing.Point(418, 71)
        Me.btnCad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(97, 53)
        Me.btnCad.TabIndex = 11
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'btnAlt
        '
        Me.btnAlt.Location = New System.Drawing.Point(418, 129)
        Me.btnAlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(97, 51)
        Me.btnAlt.TabIndex = 12
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(418, 186)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(97, 50)
        Me.btnCan.TabIndex = 13
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(418, 241)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(97, 44)
        Me.btnSair.TabIndex = 14
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnBuscArea
        '
        Me.btnBuscArea.Location = New System.Drawing.Point(128, 46)
        Me.btnBuscArea.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscArea.Name = "btnBuscArea"
        Me.btnBuscArea.Size = New System.Drawing.Size(38, 27)
        Me.btnBuscArea.TabIndex = 1
        Me.btnBuscArea.Text = "..."
        Me.btnBuscArea.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(176, 47)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(75, 27)
        Me.txtValor.TabIndex = 2
        Me.txtValor.Tag = "h"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(172, 23)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Valor"
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(16, 319)
        Me.dtpData.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(97, 27)
        Me.dtpData.TabIndex = 8
        Me.dtpData.Tag = "h"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 292)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Data do evento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(286, 294)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 20)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Horário de início"
        '
        'txtQtdMax
        '
        Me.txtQtdMax.Enabled = False
        Me.txtQtdMax.Location = New System.Drawing.Point(259, 48)
        Me.txtQtdMax.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQtdMax.Name = "txtQtdMax"
        Me.txtQtdMax.Size = New System.Drawing.Size(148, 27)
        Me.txtQtdMax.TabIndex = 3
        Me.txtQtdMax.Tag = "h"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 20)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Quantidade Máxima"
        '
        'txtCon
        '
        Me.txtCon.Enabled = False
        Me.txtCon.Location = New System.Drawing.Point(14, 184)
        Me.txtCon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCon.Multiline = True
        Me.txtCon.Name = "txtCon"
        Me.txtCon.Size = New System.Drawing.Size(393, 101)
        Me.txtCon.TabIndex = 7
        Me.txtCon.Tag = "h"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 160)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(160, 20)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Nome dos Convidados"
        '
        'txtCodMor
        '
        Me.txtCodMor.Enabled = False
        Me.txtCodMor.Location = New System.Drawing.Point(435, 326)
        Me.txtCodMor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodMor.Name = "txtCodMor"
        Me.txtCodMor.Size = New System.Drawing.Size(64, 27)
        Me.txtCodMor.TabIndex = 76
        Me.txtCodMor.Tag = "x"
        Me.txtCodMor.Visible = False
        '
        'txtCodRes
        '
        Me.txtCodRes.Enabled = False
        Me.txtCodRes.Location = New System.Drawing.Point(435, 291)
        Me.txtCodRes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodRes.Name = "txtCodRes"
        Me.txtCodRes.Size = New System.Drawing.Size(64, 27)
        Me.txtCodRes.TabIndex = 77
        Me.txtCodRes.Tag = "x"
        Me.txtCodRes.Visible = False
        '
        'DgdReserva
        '
        Me.DgdReserva.AllowUserToAddRows = False
        Me.DgdReserva.AllowUserToDeleteRows = False
        Me.DgdReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdReserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DgdReserva.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdReserva.Location = New System.Drawing.Point(16, 359)
        Me.DgdReserva.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdReserva.Name = "DgdReserva"
        Me.DgdReserva.ReadOnly = True
        Me.DgdReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdReserva.Size = New System.Drawing.Size(499, 354)
        Me.DgdReserva.TabIndex = 78
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "nomarea"
        Me.Column1.HeaderText = "Área"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nomres"
        Me.Column2.HeaderText = "Morador"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 92
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "datres"
        Me.Column3.HeaderText = "Data da Reserva"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "horres"
        Me.Column4.HeaderText = "Horário da Reserva"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 147
        '
        'txtCampo
        '
        Me.txtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCampo.Location = New System.Drawing.Point(145, 313)
        Me.txtCampo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.Size = New System.Drawing.Size(49, 24)
        Me.txtCampo.TabIndex = 79
        Me.txtCampo.Tag = "x"
        Me.txtCampo.Visible = False
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(11, 48)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(2)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(113, 24)
        Me.txtArea.TabIndex = 0
        Me.txtArea.Tag = "h"
        '
        'txtHor
        '
        Me.txtHor.FormattingEnabled = True
        Me.txtHor.Items.AddRange(New Object() {"7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00"})
        Me.txtHor.Location = New System.Drawing.Point(286, 318)
        Me.txtHor.Name = "txtHor"
        Me.txtHor.Size = New System.Drawing.Size(121, 28)
        Me.txtHor.TabIndex = 9
        Me.txtHor.Tag = "h"
        '
        'FrmCadReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 729)
        Me.Controls.Add(Me.txtHor)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtCampo)
        Me.Controls.Add(Me.DgdReserva)
        Me.Controls.Add(Me.txtCodRes)
        Me.Controls.Add(Me.txtCodMor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCon)
        Me.Controls.Add(Me.txtQtdMax)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBuscArea)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAlt)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnBuscMor)
        Me.Controls.Add(Me.txtCodArea)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQtdPar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNomMor)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCadReservas"
        Me.Text = "                                                          CADASTRO DE RESERVAS"
        CType(Me.DgdReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNomMor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQtdPar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodArea As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscMor As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnCad As Button
    Friend WithEvents btnAlt As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnBuscArea As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtQtdMax As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCon As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCodMor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodRes As System.Windows.Forms.TextBox
    Friend WithEvents DgdReserva As System.Windows.Forms.DataGridView
    Friend WithEvents txtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents txtHor As System.Windows.Forms.ComboBox
End Class
