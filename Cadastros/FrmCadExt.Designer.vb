<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadExt
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodMor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.ChkInt = New System.Windows.Forms.CheckBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDtIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpDtFim = New System.Windows.Forms.DateTimePicker()
        Me.ChkSer = New System.Windows.Forms.CheckBox()
        Me.SS = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cadastro Externos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 401)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Empresa"
        '
        'txtEmp
        '
        Me.txtEmp.Location = New System.Drawing.Point(34, 428)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Size = New System.Drawing.Size(243, 29)
        Me.txtEmp.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nome"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(34, 136)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(243, 29)
        Me.txtCod.TabIndex = 0
        Me.txtCod.Tag = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "RG"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(34, 206)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(243, 29)
        Me.txtNome.TabIndex = 1
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(34, 280)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(243, 29)
        Me.txtRG.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Código"
        '
        'txtCodMor
        '
        Me.txtCodMor.Location = New System.Drawing.Point(34, 357)
        Me.txtCodMor.Name = "txtCodMor"
        Me.txtCodMor.Size = New System.Drawing.Size(243, 29)
        Me.txtCodMor.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 24)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Código do Morador"
        '
        'btnCad
        '
        Me.btnCad.Location = New System.Drawing.Point(413, 136)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(145, 64)
        Me.btnCad.TabIndex = 5
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'ChkInt
        '
        Me.ChkInt.AutoSize = True
        Me.ChkInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkInt.Location = New System.Drawing.Point(415, 24)
        Me.ChkInt.Name = "ChkInt"
        Me.ChkInt.Size = New System.Drawing.Size(143, 33)
        Me.ChkInt.TabIndex = 38
        Me.ChkInt.Tag = "x"
        Me.ChkInt.Text = "Interfonar"
        Me.ChkInt.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(413, 551)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(142, 53)
        Me.btnSair.TabIndex = 50
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(413, 206)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(145, 62)
        Me.btnNovo.TabIndex = 49
        Me.btnNovo.Text = "Novo Cadastro"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 476)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 24)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Início do serviço"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 548)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 24)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Final do serviço"
        '
        'dtpDtIni
        '
        Me.dtpDtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDtIni.Location = New System.Drawing.Point(34, 503)
        Me.dtpDtIni.Name = "dtpDtIni"
        Me.dtpDtIni.Size = New System.Drawing.Size(174, 29)
        Me.dtpDtIni.TabIndex = 54
        Me.dtpDtIni.Tag = "h"
        '
        'dtpDtFim
        '
        Me.dtpDtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDtFim.Location = New System.Drawing.Point(34, 575)
        Me.dtpDtFim.Name = "dtpDtFim"
        Me.dtpDtFim.Size = New System.Drawing.Size(174, 29)
        Me.dtpDtFim.TabIndex = 55
        Me.dtpDtFim.Tag = "h"
        '
        'ChkSer
        '
        Me.ChkSer.AutoSize = True
        Me.ChkSer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSer.Location = New System.Drawing.Point(415, 63)
        Me.ChkSer.Name = "ChkSer"
        Me.ChkSer.Size = New System.Drawing.Size(120, 33)
        Me.ChkSer.TabIndex = 56
        Me.ChkSer.Tag = "x"
        Me.ChkSer.Text = "Serviço"
        Me.ChkSer.UseVisualStyleBackColor = True
        '
        'SS
        '
        Me.SS.Location = New System.Drawing.Point(283, 357)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(50, 29)
        Me.SS.TabIndex = 57
        Me.SS.Text = "..."
        Me.SS.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(415, 280)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(145, 62)
        Me.btnAlterar.TabIndex = 58
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'FrmCadExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 628)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.ChkSer)
        Me.Controls.Add(Me.dtpDtFim)
        Me.Controls.Add(Me.dtpDtIni)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.ChkInt)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.txtCodMor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmCadExt"
        Me.Text = "FrmCadExternos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodMor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCad As System.Windows.Forms.Button
    Friend WithEvents ChkInt As System.Windows.Forms.CheckBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpDtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDtFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkSer As System.Windows.Forms.CheckBox
    Friend WithEvents SS As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As Button
End Class
