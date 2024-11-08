<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadEncomenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadEncomenda))
        Me.btnCad = New System.Windows.Forms.Button()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.LblBlo = New System.Windows.Forms.Label()
        Me.LblApt = New System.Windows.Forms.Label()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.btnBusc = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lblCodMor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCad
        '
        Me.btnCad.Location = New System.Drawing.Point(467, 67)
        Me.btnCad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(97, 51)
        Me.btnCad.TabIndex = 2
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'dtpHora
        '
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHora.Location = New System.Drawing.Point(371, 254)
        Me.dtpHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(80, 27)
        Me.dtpHora.TabIndex = 3
        Me.dtpHora.Tag = "h"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 258)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Horário"
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(47, 256)
        Me.dtpData.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(96, 27)
        Me.dtpData.TabIndex = 2
        Me.dtpData.Tag = "h"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 259)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nome do Morador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(358, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Apartamento"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(12, 106)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(438, 133)
        Me.txtDesc.TabIndex = 1
        Me.txtDesc.Tag = "h"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Descrição"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(468, 232)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(97, 51)
        Me.btnSair.TabIndex = 8
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(271, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 20)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Bloco"
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(467, 11)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(97, 51)
        Me.btnNovo.TabIndex = 4
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnAlt
        '
        Me.btnAlt.Location = New System.Drawing.Point(468, 122)
        Me.btnAlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(96, 51)
        Me.btnAlt.TabIndex = 6
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(468, 178)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(97, 50)
        Me.btnCan.TabIndex = 7
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'LblBlo
        '
        Me.LblBlo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBlo.Location = New System.Drawing.Point(271, 38)
        Me.LblBlo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBlo.Name = "LblBlo"
        Me.LblBlo.Size = New System.Drawing.Size(78, 24)
        Me.LblBlo.TabIndex = 71
        Me.LblBlo.Tag = "c"
        '
        'LblApt
        '
        Me.LblApt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblApt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApt.Location = New System.Drawing.Point(361, 37)
        Me.LblApt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblApt.Name = "LblApt"
        Me.LblApt.Size = New System.Drawing.Size(89, 25)
        Me.LblApt.TabIndex = 72
        Me.LblApt.Tag = "c"
        '
        'LblNom
        '
        Me.LblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNom.Location = New System.Drawing.Point(10, 38)
        Me.LblNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(207, 24)
        Me.LblNom.TabIndex = 73
        Me.LblNom.Tag = "c"
        '
        'btnBusc
        '
        Me.btnBusc.Location = New System.Drawing.Point(220, 36)
        Me.btnBusc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBusc.Name = "btnBusc"
        Me.btnBusc.Size = New System.Drawing.Size(38, 27)
        Me.btnBusc.TabIndex = 0
        Me.btnBusc.Text = "..."
        Me.btnBusc.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(296, 74)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(32, 27)
        Me.txtCod.TabIndex = 5
        Me.txtCod.Tag = "x"
        Me.txtCod.Visible = False
        '
        'lblCodMor
        '
        Me.lblCodMor.AutoSize = True
        Me.lblCodMor.Location = New System.Drawing.Point(181, 258)
        Me.lblCodMor.Name = "lblCodMor"
        Me.lblCodMor.Size = New System.Drawing.Size(53, 20)
        Me.lblCodMor.TabIndex = 74
        Me.lblCodMor.Text = "Label6"
        Me.lblCodMor.Visible = False
        '
        'FrmCadEncomenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 296)
        Me.Controls.Add(Me.lblCodMor)
        Me.Controls.Add(Me.btnBusc)
        Me.Controls.Add(Me.LblNom)
        Me.Controls.Add(Me.LblApt)
        Me.Controls.Add(Me.LblBlo)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAlt)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.dtpHora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCadEncomenda"
        Me.Text = "                                                                  CADASTRO DE ENC" & _
    "OMENDAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCad As Button
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSair As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnAlt As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents LblBlo As System.Windows.Forms.Label
    Friend WithEvents LblApt As System.Windows.Forms.Label
    Friend WithEvents LblNom As System.Windows.Forms.Label
    Friend WithEvents btnBusc As System.Windows.Forms.Button
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lblCodMor As System.Windows.Forms.Label
End Class
