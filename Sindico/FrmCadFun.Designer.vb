<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFun
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
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.txtCar = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRg = New System.Windows.Forms.TextBox()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.mskSal = New System.Windows.Forms.MaskedTextBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(23, 105)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(66, 24)
        Me.lblNome.TabIndex = 11
        Me.lblNome.Text = "Nome"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(290, 102)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(66, 24)
        Me.lblCargo.TabIndex = 12
        Me.lblCargo.Text = "Cargo"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(27, 132)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(243, 29)
        Me.txtNom.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(349, 31)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cadastro de Funcionários"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(23, 174)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(39, 24)
        Me.lblRg.TabIndex = 17
        Me.lblRg.Text = "RG"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(560, 105)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(93, 24)
        Me.lblTelefone.TabIndex = 16
        Me.lblTelefone.Text = "Telefone"
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(564, 201)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(243, 29)
        Me.txtEnd.TabIndex = 5
        Me.txtEnd.Tag = "h"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(560, 174)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(102, 24)
        Me.lblEndereco.TabIndex = 21
        Me.lblEndereco.Text = "Endereço"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(290, 174)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(51, 24)
        Me.lblCep.TabIndex = 20
        Me.lblCep.Text = "CEP"
        '
        'txtCid
        '
        Me.txtCid.Location = New System.Drawing.Point(27, 275)
        Me.txtCid.Name = "txtCid"
        Me.txtCid.Size = New System.Drawing.Size(243, 29)
        Me.txtCid.TabIndex = 6
        Me.txtCid.Tag = "h"
        '
        'txtEst
        '
        Me.txtEst.Location = New System.Drawing.Point(294, 275)
        Me.txtEst.Name = "txtEst"
        Me.txtEst.Size = New System.Drawing.Size(243, 29)
        Me.txtEst.TabIndex = 7
        Me.txtEst.Tag = "h"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Cidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Estado"
        '
        'txtBai
        '
        Me.txtBai.Location = New System.Drawing.Point(564, 275)
        Me.txtBai.Name = "txtBai"
        Me.txtBai.Size = New System.Drawing.Size(243, 29)
        Me.txtBai.TabIndex = 8
        Me.txtBai.Tag = "h"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(560, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 24)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Salário"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(560, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 24)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Bairro"
        '
        'txtCom
        '
        Me.txtCom.Location = New System.Drawing.Point(294, 344)
        Me.txtCom.Name = "txtCom"
        Me.txtCom.Size = New System.Drawing.Size(243, 29)
        Me.txtCom.TabIndex = 10
        Me.txtCom.Tag = ""
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(27, 344)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(243, 29)
        Me.txtNum.TabIndex = 9
        Me.txtNum.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 24)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Complemento"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(23, 317)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(85, 24)
        Me.lblNumero.TabIndex = 24
        Me.lblNumero.Text = "Número"
        '
        'dtpDtAdm
        '
        Me.dtpDtAdm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDtAdm.Location = New System.Drawing.Point(27, 438)
        Me.dtpDtAdm.Name = "dtpDtAdm"
        Me.dtpDtAdm.Size = New System.Drawing.Size(174, 29)
        Me.dtpDtAdm.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 24)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Data de Admissão"
        '
        'ChkAtivo
        '
        Me.ChkAtivo.AutoSize = True
        Me.ChkAtivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAtivo.Location = New System.Drawing.Point(839, 32)
        Me.ChkAtivo.Name = "ChkAtivo"
        Me.ChkAtivo.Size = New System.Drawing.Size(89, 33)
        Me.ChkAtivo.TabIndex = 37
        Me.ChkAtivo.Tag = "x"
        Me.ChkAtivo.Text = "Ativo"
        Me.ChkAtivo.UseVisualStyleBackColor = True
        '
        'btnCad
        '
        Me.btnCad.Location = New System.Drawing.Point(338, 420)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(145, 47)
        Me.btnCad.TabIndex = 12
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'txtCar
        '
        Me.txtCar.Location = New System.Drawing.Point(294, 132)
        Me.txtCar.Name = "txtCar"
        Me.txtCar.Size = New System.Drawing.Size(243, 29)
        Me.txtCar.TabIndex = 1
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(564, 428)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(243, 29)
        Me.txtCod.TabIndex = 45
        Me.txtCod.Tag = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(560, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 24)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Código"
        '
        'txtRg
        '
        Me.txtRg.Location = New System.Drawing.Point(27, 201)
        Me.txtRg.Name = "txtRg"
        Me.txtRg.Size = New System.Drawing.Size(243, 29)
        Me.txtRg.TabIndex = 3
        '
        'mskTel
        '
        Me.mskTel.Location = New System.Drawing.Point(564, 132)
        Me.mskTel.Mask = "(99) 00000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(243, 29)
        Me.mskTel.TabIndex = 2
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(294, 201)
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(243, 29)
        Me.txtCep.TabIndex = 4
        '
        'mskSal
        '
        Me.mskSal.Location = New System.Drawing.Point(564, 344)
        Me.mskSal.Name = "mskSal"
        Me.mskSal.Size = New System.Drawing.Size(243, 29)
        Me.mskSal.TabIndex = 11
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(821, 132)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(142, 56)
        Me.btnNovo.TabIndex = 47
        Me.btnNovo.Text = "Novo Cadastro"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(821, 275)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(142, 53)
        Me.btnSair.TabIndex = 48
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(821, 201)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(142, 56)
        Me.btnAlterar.TabIndex = 49
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'FrmCadFun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 497)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.mskSal)
        Me.Controls.Add(Me.mskTel)
        Me.Controls.Add(Me.txtRg)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCar)
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
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblNome)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmCadFun"
        Me.Text = "FrmCadFunc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents txtCar As System.Windows.Forms.TextBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRg As System.Windows.Forms.TextBox
    Friend WithEvents mskTel As MaskedTextBox
    Friend WithEvents txtCep As TextBox
    Friend WithEvents mskSal As MaskedTextBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnAlterar As Button
End Class
