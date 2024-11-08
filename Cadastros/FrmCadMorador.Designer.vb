<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadMorador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadMorador))
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboApt = New System.Windows.Forms.ComboBox()
        Me.CboBlo = New System.Windows.Forms.ComboBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.mskTelEmer = New System.Windows.Forms.MaskedTextBox()
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.grpLoc = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.mskRg = New System.Windows.Forms.MaskedTextBox()
        Me.mskCpf = New System.Windows.Forms.MaskedTextBox()
        Me.grpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(10, 32)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(163, 27)
        Me.txtNom.TabIndex = 0
        Me.txtNom.Tag = "h"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Telefone de Emergência"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "CPF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 128)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 20)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Bloco"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(186, 127)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(97, 20)
        Me.lblNumero.TabIndex = 47
        Me.lblNumero.Text = "Apartamento"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(8, 64)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(28, 20)
        Me.lblCep.TabIndex = 46
        Me.lblCep.Text = "RG"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(186, 8)
        Me.lblRg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(65, 20)
        Me.lblRg.TabIndex = 45
        Me.lblRg.Text = "Telefone"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(8, 8)
        Me.lblCargo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(50, 20)
        Me.lblCargo.TabIndex = 43
        Me.lblCargo.Text = "Nome"
        '
        'mskTel
        '
        Me.mskTel.Location = New System.Drawing.Point(188, 32)
        Me.mskTel.Margin = New System.Windows.Forms.Padding(2)
        Me.mskTel.Mask = "(99) 00000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(163, 27)
        Me.mskTel.TabIndex = 1
        Me.mskTel.Tag = "h"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(363, 32)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(163, 27)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.Tag = "h"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Email"
        '
        'CboApt
        '
        Me.CboApt.FormattingEnabled = True
        Me.CboApt.Location = New System.Drawing.Point(188, 150)
        Me.CboApt.Margin = New System.Windows.Forms.Padding(2)
        Me.CboApt.Name = "CboApt"
        Me.CboApt.Size = New System.Drawing.Size(163, 28)
        Me.CboApt.TabIndex = 7
        Me.CboApt.Tag = "h"
        '
        'CboBlo
        '
        Me.CboBlo.FormattingEnabled = True
        Me.CboBlo.Location = New System.Drawing.Point(12, 150)
        Me.CboBlo.Margin = New System.Windows.Forms.Padding(2)
        Me.CboBlo.Name = "CboBlo"
        Me.CboBlo.Size = New System.Drawing.Size(163, 28)
        Me.CboBlo.TabIndex = 6
        Me.CboBlo.Tag = "h"
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(554, 9)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(107, 50)
        Me.btnNovo.TabIndex = 8
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnCad
        '
        Me.btnCad.Location = New System.Drawing.Point(554, 63)
        Me.btnCad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(107, 50)
        Me.btnCad.TabIndex = 8
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(554, 291)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(107, 50)
        Me.btnSair.TabIndex = 13
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'mskTelEmer
        '
        Me.mskTelEmer.Location = New System.Drawing.Point(363, 87)
        Me.mskTelEmer.Margin = New System.Windows.Forms.Padding(2)
        Me.mskTelEmer.Mask = "(99) 00000-0000"
        Me.mskTelEmer.Name = "mskTelEmer"
        Me.mskTelEmer.Size = New System.Drawing.Size(163, 27)
        Me.mskTelEmer.TabIndex = 5
        Me.mskTelEmer.Tag = "h"
        '
        'btnLoc
        '
        Me.btnLoc.Location = New System.Drawing.Point(554, 119)
        Me.btnLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(107, 50)
        Me.btnLoc.TabIndex = 10
        Me.btnLoc.Text = "Localizar"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'grpLoc
        '
        Me.grpLoc.Controls.Add(Me.btnConfirmar)
        Me.grpLoc.Controls.Add(Me.Label4)
        Me.grpLoc.Controls.Add(Me.txtLoc)
        Me.grpLoc.Location = New System.Drawing.Point(11, 233)
        Me.grpLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.grpLoc.Name = "grpLoc"
        Me.grpLoc.Padding = New System.Windows.Forms.Padding(2)
        Me.grpLoc.Size = New System.Drawing.Size(383, 108)
        Me.grpLoc.TabIndex = 55
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Insira o Nome ou Apartamento"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(4, 59)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(270, 27)
        Me.txtLoc.TabIndex = 0
        '
        'btnAlt
        '
        Me.btnAlt.Location = New System.Drawing.Point(554, 177)
        Me.btnAlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(107, 50)
        Me.btnAlt.TabIndex = 11
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(554, 233)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(107, 50)
        Me.btnCan.TabIndex = 12
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(428, 262)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(73, 27)
        Me.txtCod.TabIndex = 0
        Me.txtCod.Tag = "x"
        Me.txtCod.Visible = False
        '
        'mskRg
        '
        Me.mskRg.Location = New System.Drawing.Point(10, 87)
        Me.mskRg.Mask = "00,000,000-0"
        Me.mskRg.Name = "mskRg"
        Me.mskRg.Size = New System.Drawing.Size(163, 27)
        Me.mskRg.TabIndex = 66
        Me.mskRg.Tag = "h"
        '
        'mskCpf
        '
        Me.mskCpf.Location = New System.Drawing.Point(188, 87)
        Me.mskCpf.Mask = "000,000,000-00"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(163, 27)
        Me.mskCpf.TabIndex = 67
        Me.mskCpf.Tag = "h"
        '
        'FrmCadMorador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 350)
        Me.Controls.Add(Me.mskCpf)
        Me.Controls.Add(Me.mskRg)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAlt)
        Me.Controls.Add(Me.grpLoc)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.mskTelEmer)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.CboBlo)
        Me.Controls.Add(Me.CboApt)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mskTel)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.lblRg)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.lblCargo)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCadMorador"
        Me.Text = "                                                                                 " & _
    "  CADASTRO DE MORADOR"
        Me.grpLoc.ResumeLayout(False)
        Me.grpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents lblRg As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents mskTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboApt As System.Windows.Forms.ComboBox
    Friend WithEvents CboBlo As System.Windows.Forms.ComboBox
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnCad As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents mskTelEmer As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnLoc As Button
    Friend WithEvents grpLoc As GroupBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents btnAlt As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents mskRg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCpf As System.Windows.Forms.MaskedTextBox
End Class
