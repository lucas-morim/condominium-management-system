<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadFornecedor))
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.grpLoc = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomCon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.mskCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.grpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAlt
        '
        Me.btnAlt.Location = New System.Drawing.Point(419, 184)
        Me.btnAlt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(107, 51)
        Me.btnAlt.TabIndex = 8
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = True
        '
        'grpLoc
        '
        Me.grpLoc.Controls.Add(Me.btnConfirmar)
        Me.grpLoc.Controls.Add(Me.Label4)
        Me.grpLoc.Controls.Add(Me.txtLoc)
        Me.grpLoc.Location = New System.Drawing.Point(13, 312)
        Me.grpLoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLoc.Name = "grpLoc"
        Me.grpLoc.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpLoc.Size = New System.Drawing.Size(365, 121)
        Me.grpLoc.TabIndex = 81
        Me.grpLoc.TabStop = False
        Me.grpLoc.Text = "Localizar"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(276, 59)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(81, 27)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Insira o Nome ou Apartamento"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(4, 59)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(271, 27)
        Me.txtLoc.TabIndex = 0
        '
        'btnLoc
        '
        Me.btnLoc.Location = New System.Drawing.Point(419, 129)
        Me.btnLoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(107, 51)
        Me.btnLoc.TabIndex = 7
        Me.btnLoc.Text = "Localizar"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(419, 371)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(107, 51)
        Me.btnSair.TabIndex = 10
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnCad
        '
        Me.btnCad.Location = New System.Drawing.Point(419, 74)
        Me.btnCad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(107, 51)
        Me.btnCad.TabIndex = 5
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNovo.Location = New System.Drawing.Point(419, 19)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(107, 51)
        Me.btnNovo.TabIndex = 5
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Telefone"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(13, 36)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(163, 27)
        Me.txtNom.TabIndex = 0
        Me.txtNom.Tag = "h"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(188, 11)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(42, 20)
        Me.lblRg.TabIndex = 73
        Me.lblRg.Text = "CNPJ"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(12, 14)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(132, 20)
        Me.lblCargo.TabIndex = 71
        Me.lblCargo.Text = "Nome da Empresa"
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(419, 239)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(107, 51)
        Me.btnCan.TabIndex = 9
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'mskTel
        '
        Me.mskTel.Location = New System.Drawing.Point(13, 92)
        Me.mskTel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mskTel.Mask = "(99) 00000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(163, 27)
        Me.mskTel.TabIndex = 2
        Me.mskTel.Tag = "h"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(11, 148)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(369, 135)
        Me.txtDesc.TabIndex = 4
        Me.txtDesc.Tag = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Descrição"
        '
        'txtNomCon
        '
        Me.txtNomCon.Location = New System.Drawing.Point(191, 92)
        Me.txtNomCon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNomCon.Name = "txtNomCon"
        Me.txtNomCon.Size = New System.Drawing.Size(188, 27)
        Me.txtNomCon.TabIndex = 3
        Me.txtNomCon.Tag = "h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Nome do Contato"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(437, 334)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(53, 27)
        Me.txtCod.TabIndex = 88
        Me.txtCod.Tag = "x"
        Me.txtCod.Visible = False
        '
        'mskCnpj
        '
        Me.mskCnpj.Location = New System.Drawing.Point(191, 34)
        Me.mskCnpj.Mask = "00,000,000/0000-00"
        Me.mskCnpj.Name = "mskCnpj"
        Me.mskCnpj.Size = New System.Drawing.Size(189, 27)
        Me.mskCnpj.TabIndex = 89
        Me.mskCnpj.Tag = "h"
        '
        'FrmCadFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 453)
        Me.Controls.Add(Me.mskCnpj)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.txtNomCon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAlt)
        Me.Controls.Add(Me.grpLoc)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mskTel)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblRg)
        Me.Controls.Add(Me.lblCargo)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCadFornecedor"
        Me.Text = "                                                          CADASTRO DE FORNECEDORE" & _
    "S"
        Me.grpLoc.ResumeLayout(False)
        Me.grpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAlt As Button
    Friend WithEvents grpLoc As GroupBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents btnLoc As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents btnCad As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblRg As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents btnCan As Button
    Friend WithEvents mskTel As MaskedTextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomCon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents mskCnpj As System.Windows.Forms.MaskedTextBox
End Class
