<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadExterno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadExterno))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
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
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.grpLoc = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.lblCodMor = New System.Windows.Forms.Label()
        Me.btnBusc = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskRg = New System.Windows.Forms.MaskedTextBox()
        Me.lblCodMor1 = New System.Windows.Forms.Label()
        Me.grpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 199)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Empresa"
        '
        'txtEmp
        '
        Me.txtEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmp.Location = New System.Drawing.Point(10, 223)
        Me.txtEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmp.Name = "txtEmp"
        Me.txtEmp.Size = New System.Drawing.Size(183, 24)
        Me.txtEmp.TabIndex = 3
        Me.txtEmp.Tag = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "RG"
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(10, 34)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(183, 24)
        Me.txtNom.TabIndex = 0
        Me.txtNom.Tag = "h"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 139)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Nome do Morador"
        '
        'btnCad
        '
        Me.btnCad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCad.Location = New System.Drawing.Point(336, 139)
        Me.btnCad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(109, 47)
        Me.btnCad.TabIndex = 8
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'ChkInt
        '
        Me.ChkInt.AutoSize = True
        Me.ChkInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkInt.Location = New System.Drawing.Point(345, 12)
        Me.ChkInt.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkInt.Name = "ChkInt"
        Me.ChkInt.Size = New System.Drawing.Size(107, 28)
        Me.ChkInt.TabIndex = 6
        Me.ChkInt.Tag = "x"
        Me.ChkInt.Text = "Interfonar"
        Me.ChkInt.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(336, 372)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(109, 47)
        Me.btnSair.TabIndex = 14
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Location = New System.Drawing.Point(336, 84)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(109, 47)
        Me.btnNovo.TabIndex = 9
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 260)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Início do serviço"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(185, 260)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Final do serviço"
        '
        'dtpDtIni
        '
        Me.dtpDtIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDtIni.Location = New System.Drawing.Point(13, 282)
        Me.dtpDtIni.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDtIni.Name = "dtpDtIni"
        Me.dtpDtIni.Size = New System.Drawing.Size(132, 24)
        Me.dtpDtIni.TabIndex = 4
        Me.dtpDtIni.Tag = "h"
        '
        'dtpDtFim
        '
        Me.dtpDtFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDtFim.Location = New System.Drawing.Point(188, 282)
        Me.dtpDtFim.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDtFim.Name = "dtpDtFim"
        Me.dtpDtFim.Size = New System.Drawing.Size(132, 24)
        Me.dtpDtFim.TabIndex = 5
        Me.dtpDtFim.Tag = "h"
        '
        'ChkSer
        '
        Me.ChkSer.AutoSize = True
        Me.ChkSer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSer.Location = New System.Drawing.Point(345, 47)
        Me.ChkSer.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkSer.Name = "ChkSer"
        Me.ChkSer.Size = New System.Drawing.Size(92, 28)
        Me.ChkSer.TabIndex = 7
        Me.ChkSer.Tag = "x"
        Me.ChkSer.Text = "Serviço"
        Me.ChkSer.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Location = New System.Drawing.Point(336, 256)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(109, 47)
        Me.btnAlterar.TabIndex = 12
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnLoc
        '
        Me.btnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoc.Location = New System.Drawing.Point(336, 197)
        Me.btnLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(109, 47)
        Me.btnLoc.TabIndex = 11
        Me.btnLoc.Text = "Localizar"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCan.Location = New System.Drawing.Point(336, 312)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(109, 47)
        Me.btnCan.TabIndex = 13
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'grpLoc
        '
        Me.grpLoc.Controls.Add(Me.btnConfirmar)
        Me.grpLoc.Controls.Add(Me.Label9)
        Me.grpLoc.Controls.Add(Me.txtLoc)
        Me.grpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLoc.Location = New System.Drawing.Point(6, 320)
        Me.grpLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.grpLoc.Name = "grpLoc"
        Me.grpLoc.Padding = New System.Windows.Forms.Padding(2)
        Me.grpLoc.Size = New System.Drawing.Size(326, 100)
        Me.grpLoc.TabIndex = 61
        Me.grpLoc.TabStop = False
        Me.grpLoc.Text = "Localizar"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(238, 58)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(82, 29)
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
        Me.Label9.Size = New System.Drawing.Size(248, 18)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Insira o Nome ou Código do externo"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(4, 59)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(230, 24)
        Me.txtLoc.TabIndex = 0
        '
        'lblCodMor
        '
        Me.lblCodMor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodMor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodMor.Location = New System.Drawing.Point(270, 152)
        Me.lblCodMor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodMor.Name = "lblCodMor"
        Me.lblCodMor.Size = New System.Drawing.Size(50, 24)
        Me.lblCodMor.TabIndex = 2
        Me.lblCodMor.Tag = "c"
        Me.lblCodMor.Visible = False
        '
        'btnBusc
        '
        Me.btnBusc.Location = New System.Drawing.Point(199, 159)
        Me.btnBusc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBusc.Name = "btnBusc"
        Me.btnBusc.Size = New System.Drawing.Size(39, 27)
        Me.btnBusc.TabIndex = 2
        Me.btnBusc.Text = "..."
        Me.btnBusc.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(276, 87)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(44, 24)
        Me.txtCod.TabIndex = 62
        Me.txtCod.Tag = "x"
        Me.txtCod.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 18)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "RG"
        '
        'mskRg
        '
        Me.mskRg.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskRg.Location = New System.Drawing.Point(10, 95)
        Me.mskRg.Mask = "00,000,000-0"
        Me.mskRg.Name = "mskRg"
        Me.mskRg.Size = New System.Drawing.Size(180, 27)
        Me.mskRg.TabIndex = 65
        Me.mskRg.Tag = "h"
        '
        'lblCodMor1
        '
        Me.lblCodMor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodMor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodMor1.Location = New System.Drawing.Point(10, 162)
        Me.lblCodMor1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodMor1.Name = "lblCodMor1"
        Me.lblCodMor1.Size = New System.Drawing.Size(180, 24)
        Me.lblCodMor1.TabIndex = 66
        Me.lblCodMor1.Tag = "c"
        '
        'FrmCadExterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 440)
        Me.Controls.Add(Me.lblCodMor1)
        Me.Controls.Add(Me.mskRg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnBusc)
        Me.Controls.Add(Me.lblCodMor)
        Me.Controls.Add(Me.grpLoc)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.ChkSer)
        Me.Controls.Add(Me.dtpDtFim)
        Me.Controls.Add(Me.dtpDtIni)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.ChkInt)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCadExterno"
        Me.Text = "                                                 CADASTRO DE EXTERNOS"
        Me.grpLoc.ResumeLayout(False)
        Me.grpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
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
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnLoc As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents grpLoc As GroupBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents lblCodMor As System.Windows.Forms.Label
    Friend WithEvents btnBusc As Button
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mskRg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCodMor1 As System.Windows.Forms.Label
End Class
