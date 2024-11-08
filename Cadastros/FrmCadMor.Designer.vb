<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadMor
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
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtEma = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbAP = New System.Windows.Forms.ComboBox()
        Me.CmbBloc = New System.Windows.Forms.ComboBox()
        Me.btnNovCad = New System.Windows.Forms.Button()
        Me.BtnCad = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.mskTelEmer = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(285, 180)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(243, 29)
        Me.txtRG.TabIndex = 4
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(285, 111)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(243, 29)
        Me.txtNom.TabIndex = 1
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(547, 180)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(243, 29)
        Me.txtCPF.TabIndex = 5
        Me.txtCPF.Tag = "h"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Telefone de Emergência"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(543, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 24)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "CPF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 24)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Bloco"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(543, 230)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(128, 24)
        Me.lblNumero.TabIndex = 47
        Me.lblNumero.Text = "Apartamento"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(281, 153)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(39, 24)
        Me.lblCep.TabIndex = 46
        Me.lblCep.Text = "RG"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(543, 81)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(93, 24)
        Me.lblRg.TabIndex = 45
        Me.lblRg.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(319, 31)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Cadastro de Moradores"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(18, 111)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(243, 29)
        Me.txtCod.TabIndex = 0
        Me.txtCod.Tag = "x"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(281, 81)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(66, 24)
        Me.lblCargo.TabIndex = 43
        Me.lblCargo.Text = "Nome"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(14, 84)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(77, 24)
        Me.lblNome.TabIndex = 42
        Me.lblNome.Text = "Código"
        '
        'mskTel
        '
        Me.mskTel.Location = New System.Drawing.Point(547, 111)
        Me.mskTel.Mask = "(99) 00000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(243, 29)
        Me.mskTel.TabIndex = 2
        '
        'txtEma
        '
        Me.txtEma.Location = New System.Drawing.Point(18, 180)
        Me.txtEma.Name = "txtEma"
        Me.txtEma.Size = New System.Drawing.Size(243, 29)
        Me.txtEma.TabIndex = 3
        Me.txtEma.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Email"
        '
        'CmbAP
        '
        Me.CmbAP.FormattingEnabled = True
        Me.CmbAP.Location = New System.Drawing.Point(547, 257)
        Me.CmbAP.Name = "CmbAP"
        Me.CmbAP.Size = New System.Drawing.Size(243, 32)
        Me.CmbAP.TabIndex = 8
        '
        'CmbBloc
        '
        Me.CmbBloc.FormattingEnabled = True
        Me.CmbBloc.Location = New System.Drawing.Point(285, 257)
        Me.CmbBloc.Name = "CmbBloc"
        Me.CmbBloc.Size = New System.Drawing.Size(243, 32)
        Me.CmbBloc.TabIndex = 7
        '
        'btnNovCad
        '
        Me.btnNovCad.Location = New System.Drawing.Point(830, 169)
        Me.btnNovCad.Name = "btnNovCad"
        Me.btnNovCad.Size = New System.Drawing.Size(152, 60)
        Me.btnNovCad.TabIndex = 10
        Me.btnNovCad.Text = "Novo "
        Me.btnNovCad.UseVisualStyleBackColor = True
        '
        'BtnCad
        '
        Me.BtnCad.Location = New System.Drawing.Point(830, 100)
        Me.BtnCad.Name = "BtnCad"
        Me.BtnCad.Size = New System.Drawing.Size(152, 53)
        Me.BtnCad.TabIndex = 9
        Me.BtnCad.Text = "Cadastrar"
        Me.BtnCad.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(830, 243)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(152, 53)
        Me.btnSair.TabIndex = 11
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'mskTelEmer
        '
        Me.mskTelEmer.Location = New System.Drawing.Point(18, 257)
        Me.mskTelEmer.Mask = "(99) 00000-0000"
        Me.mskTelEmer.Name = "mskTelEmer"
        Me.mskTelEmer.Size = New System.Drawing.Size(243, 29)
        Me.mskTelEmer.TabIndex = 6
        '
        'FrmCadMor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 322)
        Me.Controls.Add(Me.mskTelEmer)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.BtnCad)
        Me.Controls.Add(Me.btnNovCad)
        Me.Controls.Add(Me.CmbBloc)
        Me.Controls.Add(Me.CmbAP)
        Me.Controls.Add(Me.txtEma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mskTel)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.lblRg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblNome)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmCadMor"
        Me.Text = "FrmCadMor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtCPF As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents lblRg As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents mskTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEma As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbAP As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBloc As System.Windows.Forms.ComboBox
    Friend WithEvents btnNovCad As System.Windows.Forms.Button
    Friend WithEvents BtnCad As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents mskTelEmer As System.Windows.Forms.MaskedTextBox
End Class
