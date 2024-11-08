<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuSindico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuSindico))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÁreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoradoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExternosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncomendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorMoradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorPeríodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeMultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarMultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorMoradorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorPeríodoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExternosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GráficoAreaReservadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GráficoÁreaReservadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncomendasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoradoresToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GráficoMultaPorMoradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.MultasToolStripMenuItem, Me.RelatórioToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(785, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoradoresToolStripMenuItem, Me.FuncionariosToolStripMenuItem, Me.ÁreasToolStripMenuItem, Me.FornecedoresToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.CadastroToolStripMenuItem.Text = "&Cadastro"
        '
        'MoradoresToolStripMenuItem
        '
        Me.MoradoresToolStripMenuItem.Name = "MoradoresToolStripMenuItem"
        Me.MoradoresToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.MoradoresToolStripMenuItem.Text = "&Moradores"
        '
        'FuncionariosToolStripMenuItem
        '
        Me.FuncionariosToolStripMenuItem.Name = "FuncionariosToolStripMenuItem"
        Me.FuncionariosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FuncionariosToolStripMenuItem.Text = "&Funcionarios"
        '
        'ÁreasToolStripMenuItem
        '
        Me.ÁreasToolStripMenuItem.Name = "ÁreasToolStripMenuItem"
        Me.ÁreasToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ÁreasToolStripMenuItem.Text = "Áreas"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FornecedoresToolStripMenuItem.Text = "&Fornecedores"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoradoresToolStripMenuItem1, Me.FuncionariosToolStripMenuItem1, Me.ExternosToolStripMenuItem, Me.ReservasToolStripMenuItem1, Me.FornecedoresToolStripMenuItem1, Me.EncomendasToolStripMenuItem})
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
        'FornecedoresToolStripMenuItem1
        '
        Me.FornecedoresToolStripMenuItem1.Name = "FornecedoresToolStripMenuItem1"
        Me.FornecedoresToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.FornecedoresToolStripMenuItem1.Text = "Fornecedores"
        '
        'EncomendasToolStripMenuItem
        '
        Me.EncomendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorMoradorToolStripMenuItem, Me.PorPeríodoToolStripMenuItem})
        Me.EncomendasToolStripMenuItem.Name = "EncomendasToolStripMenuItem"
        Me.EncomendasToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EncomendasToolStripMenuItem.Text = "Encomendas"
        '
        'PorMoradorToolStripMenuItem
        '
        Me.PorMoradorToolStripMenuItem.Name = "PorMoradorToolStripMenuItem"
        Me.PorMoradorToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PorMoradorToolStripMenuItem.Text = "Por morador"
        '
        'PorPeríodoToolStripMenuItem
        '
        Me.PorPeríodoToolStripMenuItem.Name = "PorPeríodoToolStripMenuItem"
        Me.PorPeríodoToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PorPeríodoToolStripMenuItem.Text = "Por período"
        '
        'MultasToolStripMenuItem
        '
        Me.MultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeMultasToolStripMenuItem, Me.ConsultarMultasToolStripMenuItem})
        Me.MultasToolStripMenuItem.Name = "MultasToolStripMenuItem"
        Me.MultasToolStripMenuItem.Size = New System.Drawing.Size(50, 19)
        Me.MultasToolStripMenuItem.Text = "&Multa"
        '
        'CadastroDeMultasToolStripMenuItem
        '
        Me.CadastroDeMultasToolStripMenuItem.Name = "CadastroDeMultasToolStripMenuItem"
        Me.CadastroDeMultasToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CadastroDeMultasToolStripMenuItem.Text = "Nova Multa"
        '
        'ConsultarMultasToolStripMenuItem
        '
        Me.ConsultarMultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorMoradorToolStripMenuItem1, Me.PorPeríodoToolStripMenuItem1, Me.GráficoMultaPorMoradorToolStripMenuItem})
        Me.ConsultarMultasToolStripMenuItem.Name = "ConsultarMultasToolStripMenuItem"
        Me.ConsultarMultasToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ConsultarMultasToolStripMenuItem.Text = "Consultar Multas"
        '
        'PorMoradorToolStripMenuItem1
        '
        Me.PorMoradorToolStripMenuItem1.Name = "PorMoradorToolStripMenuItem1"
        Me.PorMoradorToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.PorMoradorToolStripMenuItem1.Text = "Por morador"
        '
        'PorPeríodoToolStripMenuItem1
        '
        Me.PorPeríodoToolStripMenuItem1.Name = "PorPeríodoToolStripMenuItem1"
        Me.PorPeríodoToolStripMenuItem1.Size = New System.Drawing.Size(216, 22)
        Me.PorPeríodoToolStripMenuItem1.Text = "Por período"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncionáriosToolStripMenuItem, Me.ExternosToolStripMenuItem1, Me.ReservasToolStripMenuItem, Me.EncomendasToolStripMenuItem1, Me.FornecedoresToolStripMenuItem2, Me.MoradoresToolStripMenuItem2})
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.RelatórioToolStripMenuItem.Text = "Relatório"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'ExternosToolStripMenuItem1
        '
        Me.ExternosToolStripMenuItem1.Name = "ExternosToolStripMenuItem1"
        Me.ExternosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExternosToolStripMenuItem1.Text = "Externos"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GráficoAreaReservadaToolStripMenuItem, Me.GráficoÁreaReservadaToolStripMenuItem})
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'GráficoAreaReservadaToolStripMenuItem
        '
        Me.GráficoAreaReservadaToolStripMenuItem.Name = "GráficoAreaReservadaToolStripMenuItem"
        Me.GráficoAreaReservadaToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.GráficoAreaReservadaToolStripMenuItem.Text = "Padrão"
        '
        'GráficoÁreaReservadaToolStripMenuItem
        '
        Me.GráficoÁreaReservadaToolStripMenuItem.Name = "GráficoÁreaReservadaToolStripMenuItem"
        Me.GráficoÁreaReservadaToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.GráficoÁreaReservadaToolStripMenuItem.Text = "Gráfico área reservada"
        '
        'EncomendasToolStripMenuItem1
        '
        Me.EncomendasToolStripMenuItem1.Name = "EncomendasToolStripMenuItem1"
        Me.EncomendasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EncomendasToolStripMenuItem1.Text = "Encomendas"
        '
        'FornecedoresToolStripMenuItem2
        '
        Me.FornecedoresToolStripMenuItem2.Name = "FornecedoresToolStripMenuItem2"
        Me.FornecedoresToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.FornecedoresToolStripMenuItem2.Text = "Fornecedores"
        '
        'MoradoresToolStripMenuItem2
        '
        Me.MoradoresToolStripMenuItem2.Name = "MoradoresToolStripMenuItem2"
        Me.MoradoresToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.MoradoresToolStripMenuItem2.Text = "Moradores"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 19)
        Me.SairToolStripMenuItem.Text = "&Sair"
        '
        'GráficoMultaPorMoradorToolStripMenuItem
        '
        Me.GráficoMultaPorMoradorToolStripMenuItem.Name = "GráficoMultaPorMoradorToolStripMenuItem"
        Me.GráficoMultaPorMoradorToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.GráficoMultaPorMoradorToolStripMenuItem.Text = "Gráfico multa por morador"
        '
        'FrmMenuSindico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 626)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenuSindico"
        Me.Text = "CONDOMÍNIO HELVETIA"
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
    Friend WithEvents MultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExternosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÁreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EncomendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorMoradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PorPeríodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExternosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncomendasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoradoresToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeMultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarMultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorPeríodoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorMoradorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GráficoAreaReservadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GráficoÁreaReservadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GráficoMultaPorMoradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
