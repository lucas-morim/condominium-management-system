<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsu = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCargo = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuário"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(222, 278)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(168, 27)
        Me.txtSenha.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Senha"
        '
        'txtUsu
        '
        Me.txtUsu.Location = New System.Drawing.Point(17, 278)
        Me.txtUsu.Name = "txtUsu"
        Me.txtUsu.Size = New System.Drawing.Size(168, 27)
        Me.txtUsu.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HelvetiaSoftware.My.Resources.Resources.Imagem1
        Me.PictureBox1.Location = New System.Drawing.Point(17, -60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(386, 387)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(17, 392)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(373, 30)
        Me.btnEntrar.TabIndex = 3
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cargo"
        '
        'cbxCargo
        '
        Me.cbxCargo.FormattingEnabled = True
        Me.cbxCargo.Items.AddRange(New Object() {"Síndico", "Morador", "Porteiro"})
        Me.cbxCargo.Location = New System.Drawing.Point(123, 343)
        Me.cbxCargo.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxCargo.Name = "cbxCargo"
        Me.cbxCargo.Size = New System.Drawing.Size(163, 28)
        Me.cbxCargo.TabIndex = 2
        Me.cbxCargo.Tag = "h"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 436)
        Me.Controls.Add(Me.cbxCargo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                              LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUsu As System.Windows.Forms.TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxCargo As System.Windows.Forms.ComboBox
End Class
