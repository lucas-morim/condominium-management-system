<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuSin
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
        Me.MoradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoradoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExternosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatorioDeAcessoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.RelatorioDeAcessoToolStripMenuItem, Me.MultasToolStripMenuItem, Me.EmpresasToolStripMenuItem, Me.ReservasToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoradoresToolStripMenuItem, Me.FuncionariosToolStripMenuItem, Me.ÁreasToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.CadastroToolStripMenuItem.Text = "&Cadastro"
        '
        'MoradoresToolStripMenuItem
        '
        Me.MoradoresToolStripMenuItem.Name = "MoradoresToolStripMenuItem"
        Me.MoradoresToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MoradoresToolStripMenuItem.Text = "&Moradores"
        '
        'FuncionariosToolStripMenuItem
        '
        Me.FuncionariosToolStripMenuItem.Name = "FuncionariosToolStripMenuItem"
        Me.FuncionariosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.FuncionariosToolStripMenuItem.Text = "&Funcionarios"
        '
        'ÁreasToolStripMenuItem
        '
        Me.ÁreasToolStripMenuItem.Name = "ÁreasToolStripMenuItem"
        Me.ÁreasToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ÁreasToolStripMenuItem.Text = "Áreas"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoradoresToolStripMenuItem1, Me.FuncionariosToolStripMenuItem1, Me.ExternosToolStripMenuItem, Me.ReservasToolStripMenuItem1})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.ConsultaToolStripMenuItem.Text = "C&onsulta"
        '
        'MoradoresToolStripMenuItem1
        '
        Me.MoradoresToolStripMenuItem1.Name = "MoradoresToolStripMenuItem1"
        Me.MoradoresToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.MoradoresToolStripMenuItem1.Text = "Moradores"
        '
        'FuncionariosToolStripMenuItem1
        '
        Me.FuncionariosToolStripMenuItem1.Name = "FuncionariosToolStripMenuItem1"
        Me.FuncionariosToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.FuncionariosToolStripMenuItem1.Text = "Funcionarios "
        '
        'ExternosToolStripMenuItem
        '
        Me.ExternosToolStripMenuItem.Name = "ExternosToolStripMenuItem"
        Me.ExternosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ExternosToolStripMenuItem.Text = "&Externos"
        '
        'ReservasToolStripMenuItem1
        '
        Me.ReservasToolStripMenuItem1.Name = "ReservasToolStripMenuItem1"
        Me.ReservasToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ReservasToolStripMenuItem1.Text = "Reservas"
        '
        'RelatorioDeAcessoToolStripMenuItem
        '
        Me.RelatorioDeAcessoToolStripMenuItem.Name = "RelatorioDeAcessoToolStripMenuItem"
        Me.RelatorioDeAcessoToolStripMenuItem.Size = New System.Drawing.Size(121, 19)
        Me.RelatorioDeAcessoToolStripMenuItem.Text = "Controle de Acesso"
        '
        'MultasToolStripMenuItem
        '
        Me.MultasToolStripMenuItem.Name = "MultasToolStripMenuItem"
        Me.MultasToolStripMenuItem.Size = New System.Drawing.Size(55, 19)
        Me.MultasToolStripMenuItem.Text = "&Multas"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(69, 19)
        Me.EmpresasToolStripMenuItem.Text = "&Empresas"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(64, 19)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 19)
        Me.SairToolStripMenuItem.Text = "&Sair"
        '
        'FrmMenuSin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 471)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmMenuSin"
        Me.Text = "FrmMenuSin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoradoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoradoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FuncionariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RelatorioDeAcessoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExternosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÁreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
