<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPort
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DadosMoradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExternosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleDeAcessosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncomendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.DadosMoradoresToolStripMenuItem, Me.ControleDeAcessosToolStripMenuItem, Me.EncomendasToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(846, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.CadastroToolStripMenuItem.Text = "&Cadastro"
        '
        'DadosMoradoresToolStripMenuItem
        '
        Me.DadosMoradoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoradoresToolStripMenuItem, Me.ExternosToolStripMenuItem})
        Me.DadosMoradoresToolStripMenuItem.Name = "DadosMoradoresToolStripMenuItem"
        Me.DadosMoradoresToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.DadosMoradoresToolStripMenuItem.Text = "Consulta"
        '
        'MoradoresToolStripMenuItem
        '
        Me.MoradoresToolStripMenuItem.Name = "MoradoresToolStripMenuItem"
        Me.MoradoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MoradoresToolStripMenuItem.Text = "Moradores"
        '
        'ExternosToolStripMenuItem
        '
        Me.ExternosToolStripMenuItem.Name = "ExternosToolStripMenuItem"
        Me.ExternosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExternosToolStripMenuItem.Text = "Externos"
        '
        'ControleDeAcessosToolStripMenuItem
        '
        Me.ControleDeAcessosToolStripMenuItem.Name = "ControleDeAcessosToolStripMenuItem"
        Me.ControleDeAcessosToolStripMenuItem.Size = New System.Drawing.Size(127, 19)
        Me.ControleDeAcessosToolStripMenuItem.Text = "C&ontrole de acessos "
        '
        'EncomendasToolStripMenuItem
        '
        Me.EncomendasToolStripMenuItem.Name = "EncomendasToolStripMenuItem"
        Me.EncomendasToolStripMenuItem.Size = New System.Drawing.Size(87, 19)
        Me.EncomendasToolStripMenuItem.Text = "Encomendas"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 19)
        Me.SairToolStripMenuItem.Text = "&Sair"
        '
        'FrmMenuPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 526)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmMenuPort"
        Me.Text = "FrmMenuPort"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DadosMoradoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleDeAcessosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncomendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoradoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExternosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
