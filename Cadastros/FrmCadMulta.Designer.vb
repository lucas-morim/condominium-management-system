<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadMulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadMulta))
        Me.btnBusc = New System.Windows.Forms.Button()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.LblApt = New System.Windows.Forms.Label()
        Me.LblBlo = New System.Windows.Forms.Label()
        Me.btnAlt = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCad = New System.Windows.Forms.Button()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.txtCodMor = New System.Windows.Forms.TextBox()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnImp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBusc
        '
        Me.btnBusc.Location = New System.Drawing.Point(220, 29)
        Me.btnBusc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBusc.Name = "btnBusc"
        Me.btnBusc.Size = New System.Drawing.Size(38, 27)
        Me.btnBusc.TabIndex = 74
        Me.btnBusc.Text = "..."
        Me.btnBusc.UseVisualStyleBackColor = True
        '
        'LblNom
        '
        Me.LblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNom.Location = New System.Drawing.Point(10, 31)
        Me.LblNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(207, 24)
        Me.LblNom.TabIndex = 90
        Me.LblNom.Tag = "c"
        '
        'LblApt
        '
        Me.LblApt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblApt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApt.Location = New System.Drawing.Point(359, 29)
        Me.LblApt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblApt.Name = "LblApt"
        Me.LblApt.Size = New System.Drawing.Size(89, 25)
        Me.LblApt.TabIndex = 89
        Me.LblApt.Tag = "c"
        '
        'LblBlo
        '
        Me.LblBlo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBlo.Location = New System.Drawing.Point(271, 31)
        Me.LblBlo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblBlo.Name = "LblBlo"
        Me.LblBlo.Size = New System.Drawing.Size(78, 24)
        Me.LblBlo.TabIndex = 88
        Me.LblBlo.Tag = "c"
        '
        'btnAlt
        '
        Me.btnAlt.Location = New System.Drawing.Point(467, 122)
        Me.btnAlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlt.Name = "btnAlt"
        Me.btnAlt.Size = New System.Drawing.Size(96, 51)
        Me.btnAlt.TabIndex = 81
        Me.btnAlt.Text = "Alterar"
        Me.btnAlt.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(467, 11)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(97, 51)
        Me.btnNovo.TabIndex = 79
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(267, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 20)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Bloco"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(307, 264)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(32, 27)
        Me.txtCod.TabIndex = 80
        Me.txtCod.Tag = "x"
        Me.txtCod.Visible = False
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(469, 285)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(96, 51)
        Me.btnSair.TabIndex = 83
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(10, 90)
        Me.txtMotivo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(438, 151)
        Me.txtMotivo.TabIndex = 75
        Me.txtMotivo.Tag = "h"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Motivo da multa"
        '
        'btnCad
        '
        Me.btnCad.Location = New System.Drawing.Point(467, 67)
        Me.btnCad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCad.Name = "btnCad"
        Me.btnCad.Size = New System.Drawing.Size(97, 51)
        Me.btnCad.TabIndex = 77
        Me.btnCad.Text = "Cadastrar"
        Me.btnCad.UseVisualStyleBackColor = True
        '
        'dtpHora
        '
        Me.dtpHora.CalendarTrailingForeColor = System.Drawing.Color.Gray
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHora.Location = New System.Drawing.Point(368, 307)
        Me.dtpHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(80, 27)
        Me.dtpHora.TabIndex = 78
        Me.dtpHora.Tag = "h"
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(135, 309)
        Me.dtpData.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(96, 27)
        Me.dtpData.TabIndex = 76
        Me.dtpData.Tag = "h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Nome do Morador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Apartamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 311)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Horário"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 312)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Data da infração"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 251)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Valor da Multa"
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(11, 273)
        Me.txtVal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(114, 27)
        Me.txtVal.TabIndex = 96
        Me.txtVal.Tag = "x"
        '
        'txtCodMor
        '
        Me.txtCodMor.Location = New System.Drawing.Point(359, 264)
        Me.txtCodMor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodMor.Name = "txtCodMor"
        Me.txtCodMor.Size = New System.Drawing.Size(32, 27)
        Me.txtCodMor.TabIndex = 97
        Me.txtCodMor.Tag = "x"
        Me.txtCodMor.Visible = False
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(468, 231)
        Me.btnCan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(97, 50)
        Me.btnCan.TabIndex = 82
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(467, 177)
        Me.btnImp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(97, 50)
        Me.btnImp.TabIndex = 98
        Me.btnImp.Text = "Imprimir"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'FrmCadMulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 354)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.txtCodMor)
        Me.Controls.Add(Me.txtVal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
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
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCad)
        Me.Controls.Add(Me.dtpHora)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmCadMulta"
        Me.Text = "                                                                          CADASTR" & _
    "O DE MULTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBusc As System.Windows.Forms.Button
    Friend WithEvents LblNom As System.Windows.Forms.Label
    Friend WithEvents LblApt As System.Windows.Forms.Label
    Friend WithEvents LblBlo As System.Windows.Forms.Label
    Friend WithEvents btnAlt As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCad As System.Windows.Forms.Button
    Friend WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodMor As System.Windows.Forms.TextBox
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnImp As System.Windows.Forms.Button
End Class
