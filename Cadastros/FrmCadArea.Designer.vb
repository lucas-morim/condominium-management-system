<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadArea))
        Me.lblRG = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.grpLoc = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.txtQtdMax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.BtnCad = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.grpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.Location = New System.Drawing.Point(10, 18)
        Me.lblRG.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(50, 20)
        Me.lblRG.TabIndex = 66
        Me.lblRG.Text = "Nome"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 82)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 20)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Valor do aluguel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-173, 201)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Telefone de Emergência"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(10, 40)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(177, 27)
        Me.txtNom.TabIndex = 0
        Me.txtNom.Tag = "h"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(327, 291)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(101, 44)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnLoc
        '
        Me.btnLoc.Location = New System.Drawing.Point(327, 126)
        Me.btnLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(101, 50)
        Me.btnLoc.TabIndex = 6
        Me.btnLoc.Text = "Localizar"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'btnAlt
        '
        Me.btnAlt.Location = New System.Drawing.Point(327, 181)
        Me.btnAlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(101, 50)
        Me.btnAlt.TabIndex = 6
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(327, 237)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(101, 50)
        Me.btnCan.TabIndex = 7
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'grpLoc
        '
        Me.grpLoc.Controls.Add(Me.btnConfirmar)
        Me.grpLoc.Controls.Add(Me.Label9)
        Me.grpLoc.Controls.Add(Me.txtLoc)
        Me.grpLoc.Location = New System.Drawing.Point(10, 209)
        Me.grpLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.grpLoc.Name = "grpLoc"
        Me.grpLoc.Padding = New System.Windows.Forms.Padding(2)
        Me.grpLoc.Size = New System.Drawing.Size(277, 127)
        Me.grpLoc.TabIndex = 78
        Me.grpLoc.TabStop = False
        Me.grpLoc.Text = "Localizar"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(186, 77)
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
        Me.Label9.Location = New System.Drawing.Point(4, 49)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 20)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Insira o Nome ou Apartamento"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(3, 77)
        Me.txtLoc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(175, 27)
        Me.txtLoc.TabIndex = 0
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(10, 104)
        Me.txtVal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(177, 27)
        Me.txtVal.TabIndex = 1
        Me.txtVal.Tag = "h"
        '
        'txtQtdMax
        '
        Me.txtQtdMax.Location = New System.Drawing.Point(10, 167)
        Me.txtQtdMax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQtdMax.Name = "txtQtdMax"
        Me.txtQtdMax.Size = New System.Drawing.Size(177, 27)
        Me.txtQtdMax.TabIndex = 2
        Me.txtQtdMax.Tag = "h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 20)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Quantidade Máx. de Pessoas"
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(327, 22)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(101, 50)
        Me.btnNovo.TabIndex = 5
        Me.btnNovo.Text = "Novo "
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'BtnCad
        '
        Me.BtnCad.Location = New System.Drawing.Point(327, 77)
        Me.BtnCad.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCad.Name = "BtnCad"
        Me.BtnCad.Size = New System.Drawing.Size(101, 44)
        Me.BtnCad.TabIndex = 3
        Me.BtnCad.Text = "Cadastrar"
        Me.BtnCad.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(245, 116)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(42, 27)
        Me.txtCod.TabIndex = 0
        Me.txtCod.Tag = "x"
        Me.txtCod.Visible = False
        '
        'FrmCadArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 351)
        Me.Controls.Add(Me.txtQtdMax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVal)
        Me.Controls.Add(Me.grpLoc)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAlt)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.BtnCad)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblRG)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCadArea"
        Me.Text = "                                                    CADASTRO DE ÁREAS"
        Me.grpLoc.ResumeLayout(False)
        Me.grpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRG As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnLoc As Button
    Friend WithEvents btnAlt As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents grpLoc As GroupBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents txtVal As TextBox
    Friend WithEvents txtQtdMax As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCad As System.Windows.Forms.Button
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
End Class
