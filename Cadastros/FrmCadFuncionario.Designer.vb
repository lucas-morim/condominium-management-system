<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadFuncionario))
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.txtCid = New System.Windows.Forms.TextBox()
        Me.txtEst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCom = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.dtpDtAdm = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChkAtivo = New System.Windows.Forms.CheckBox()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnSaiR = New System.Windows.Forms.Button()
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.grpLoc = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.CboCar = New System.Windows.Forms.ComboBox()
        Me.txtsal = New System.Windows.Forms.TextBox()
        Me.LblNomCar = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.mskRg = New System.Windows.Forms.MaskedTextBox()
        Me.grpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(7, 16)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(50, 20)
        Me.lblNome.TabIndex = 11
        Me.lblNome.Text = "Nome"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(186, 12)
        Me.lblCargo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(49, 20)
        Me.lblCargo.TabIndex = 12
        Me.lblCargo.Text = "Cargo"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(10, 38)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(163, 27)
        Me.txtNom.TabIndex = 0
        Me.txtNom.Tag = "h"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(186, 77)
        Me.lblRg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(28, 20)
        Me.lblRg.TabIndex = 17
        Me.lblRg.Text = "RG"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(7, 77)
        Me.lblTelefone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(65, 20)
        Me.lblTelefone.TabIndex = 16
        Me.lblTelefone.Text = "Telefone"
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(11, 159)
        Me.txtEnd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(163, 27)
        Me.txtEnd.TabIndex = 5
        Me.txtEnd.Tag = "h"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(8, 137)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(71, 20)
        Me.lblEndereco.TabIndex = 21
        Me.lblEndereco.Text = "Endereço"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(364, 77)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(34, 20)
        Me.lblCep.TabIndex = 20
        Me.lblCep.Text = "CEP"
        '
        'txtCid
        '
        Me.txtCid.Location = New System.Drawing.Point(188, 159)
        Me.txtCid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCid.Name = "txtCid"
        Me.txtCid.Size = New System.Drawing.Size(163, 27)
        Me.txtCid.TabIndex = 6
        Me.txtCid.Tag = "h"
        '
        'txtEst
        '
        Me.txtEst.Location = New System.Drawing.Point(366, 159)
        Me.txtEst.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEst.Name = "txtEst"
        Me.txtEst.Size = New System.Drawing.Size(163, 27)
        Me.txtEst.TabIndex = 7
        Me.txtEst.Tag = "h"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 137)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Cidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(364, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Estado"
        '
        'txtBai
        '
        Me.txtBai.Location = New System.Drawing.Point(11, 226)
        Me.txtBai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBai.Name = "txtBai"
        Me.txtBai.Size = New System.Drawing.Size(163, 27)
        Me.txtBai.TabIndex = 8
        Me.txtBai.Tag = "h"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 270)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Salário"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 203)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Bairro"
        '
        'txtCom
        '
        Me.txtCom.Location = New System.Drawing.Point(366, 226)
        Me.txtCom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCom.Name = "txtCom"
        Me.txtCom.Size = New System.Drawing.Size(163, 27)
        Me.txtCom.TabIndex = 10
        Me.txtCom.Tag = "x"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(188, 226)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(163, 27)
        Me.txtNum.TabIndex = 9
        Me.txtNum.Tag = "h"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(364, 203)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Complemento"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(186, 203)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(63, 20)
        Me.lblNumero.TabIndex = 24
        Me.lblNumero.Text = "Número"
        '
        'dtpDtAdm
        '
        Me.dtpDtAdm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDtAdm.Location = New System.Drawing.Point(188, 292)
        Me.dtpDtAdm.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDtAdm.Name = "dtpDtAdm"
        Me.dtpDtAdm.Size = New System.Drawing.Size(118, 27)
        Me.dtpDtAdm.TabIndex = 12
        Me.dtpDtAdm.Tag = "h"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 270)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Data de Admissão"
        '
        'ChkAtivo
        '
        Me.ChkAtivo.AutoSize = True
        Me.ChkAtivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAtivo.Location = New System.Drawing.Point(561, 30)
        Me.ChkAtivo.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkAtivo.Name = "ChkAtivo"
        Me.ChkAtivo.Size = New System.Drawing.Size(79, 29)
        Me.ChkAtivo.TabIndex = 13
        Me.ChkAtivo.Tag = "x"
        Me.ChkAtivo.Text = "Ativo"
        Me.ChkAtivo.UseVisualStyleBackColor = True
        '
        'btnCad
        '
        Me.btnCad.Location = New System.Drawing.Point(545, 128)
        Me.btnCad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(107, 50)
        Me.btnCad.TabIndex = 14
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'mskTel
        '
        Me.mskTel.Location = New System.Drawing.Point(10, 99)
        Me.mskTel.Margin = New System.Windows.Forms.Padding(2)
        Me.mskTel.Mask = "(99) 00000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(163, 27)
        Me.mskTel.TabIndex = 2
        Me.mskTel.Tag = "h"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(366, 99)
        Me.txtCep.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(163, 27)
        Me.txtCep.TabIndex = 4
        Me.txtCep.Tag = "h"
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(544, 67)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(107, 50)
        Me.btnNovo.TabIndex = 16
        Me.btnNovo.Text = "Novo "
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnSaiR
        '
        Me.btnSaiR.Location = New System.Drawing.Point(545, 392)
        Me.btnSaiR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaiR.Name = "btnSaiR"
        Me.btnSaiR.Size = New System.Drawing.Size(107, 50)
        Me.btnSaiR.TabIndex = 21
        Me.btnSaiR.Text = "Sair"
        Me.btnSaiR.UseVisualStyleBackColor = True
        '
        'btnAlt
        '
        Me.btnAlt.Location = New System.Drawing.Point(544, 256)
        Me.btnAlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(107, 50)
        Me.btnAlt.TabIndex = 19
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = True
        '
        'grpLoc
        '
        Me.grpLoc.Controls.Add(Me.btnConfirmar)
        Me.grpLoc.Controls.Add(Me.Label9)
        Me.grpLoc.Controls.Add(Me.txtLoc)
        Me.grpLoc.Location = New System.Drawing.Point(10, 344)
        Me.grpLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.grpLoc.Name = "grpLoc"
        Me.grpLoc.Padding = New System.Windows.Forms.Padding(2)
        Me.grpLoc.Size = New System.Drawing.Size(383, 108)
        Me.grpLoc.TabIndex = 56
        Me.grpLoc.TabStop = False
        Me.grpLoc.Text = "Localizar"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(284, 59)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(81, 27)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 29)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(278, 20)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Insira o Nome ou Código do Funcionário"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(4, 59)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(270, 27)
        Me.txtLoc.TabIndex = 0
        '
        'btnLoc
        '
        Me.btnLoc.Location = New System.Drawing.Point(545, 189)
        Me.btnLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(107, 50)
        Me.btnLoc.TabIndex = 18
        Me.btnLoc.Text = "Localizar"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(545, 326)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(107, 50)
        Me.btnCan.TabIndex = 20
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'CboCar
        '
        Me.CboCar.FormattingEnabled = True
        Me.CboCar.Location = New System.Drawing.Point(188, 36)
        Me.CboCar.Margin = New System.Windows.Forms.Padding(2)
        Me.CboCar.Name = "CboCar"
        Me.CboCar.Size = New System.Drawing.Size(163, 28)
        Me.CboCar.TabIndex = 1
        Me.CboCar.Tag = "h"
        '
        'txtsal
        '
        Me.txtsal.Location = New System.Drawing.Point(10, 292)
        Me.txtsal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsal.Name = "txtsal"
        Me.txtsal.Size = New System.Drawing.Size(163, 27)
        Me.txtsal.TabIndex = 11
        Me.txtsal.Tag = "h"
        '
        'LblNomCar
        '
        Me.LblNomCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNomCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomCar.Location = New System.Drawing.Point(366, 36)
        Me.LblNomCar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNomCar.Name = "LblNomCar"
        Me.LblNomCar.Size = New System.Drawing.Size(163, 29)
        Me.LblNomCar.TabIndex = 2
        Me.LblNomCar.Tag = "c"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(413, 403)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(116, 27)
        Me.txtCod.TabIndex = 9
        Me.txtCod.Tag = "x"
        Me.txtCod.Visible = False
        '
        'mskRg
        '
        Me.mskRg.Location = New System.Drawing.Point(188, 100)
        Me.mskRg.Mask = "00,000,000-0"
        Me.mskRg.Name = "mskRg"
        Me.mskRg.Size = New System.Drawing.Size(163, 27)
        Me.mskRg.TabIndex = 3
        Me.mskRg.Tag = "h"
        '
        'FrmCadFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 466)
        Me.Controls.Add(Me.mskRg)
        Me.Controls.Add(Me.LblNomCar)
        Me.Controls.Add(Me.txtsal)
        Me.Controls.Add(Me.CboCar)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.grpLoc)
        Me.Controls.Add(Me.btnAlt)
        Me.Controls.Add(Me.btnSaiR)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.mskTel)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.ChkAtivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpDtAdm)
        Me.Controls.Add(Me.txtCid)
        Me.Controls.Add(Me.txtEst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCom)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.lblRg)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblNome)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCadFuncionario"
        Me.Text = "                                                                                 " & _
    "   CADASTRO DE FUNCIONÁRIOS"
        Me.grpLoc.ResumeLayout(False)
        Me.grpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblRg As System.Windows.Forms.Label
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents txtCid As System.Windows.Forms.TextBox
    Friend WithEvents txtEst As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBai As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCom As System.Windows.Forms.TextBox
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents dtpDtAdm As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChkAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents btnCad As System.Windows.Forms.Button
    Friend WithEvents mskTel As MaskedTextBox
    Friend WithEvents txtCep As TextBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSaiR As Button
    Friend WithEvents btnAlt As Button
    Friend WithEvents grpLoc As GroupBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents btnLoc As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents CboCar As ComboBox
    Friend WithEvents txtsal As System.Windows.Forms.TextBox
    Friend WithEvents LblNomCar As Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents mskRg As System.Windows.Forms.MaskedTextBox
End Class
