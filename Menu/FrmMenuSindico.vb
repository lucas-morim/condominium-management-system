Public Class FrmMenuSindico

    Private Sub MoradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoradoresToolStripMenuItem.Click
        FrmCadMorador.MdiParent = Me
        FrmCadMorador.Show()
    End Sub

    Private Sub FuncionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionariosToolStripMenuItem.Click
        FrmCadFuncionario.MdiParent = Me
        FrmCadFuncionario.Show()
    End Sub

    Private Sub ExternosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExternosToolStripMenuItem.Click
        FrmConExterno.MdiParent = Me
        FrmConExterno.Show()
    End Sub
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MessageBox.Show("Deseja mesmo sair?", "Aviso", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) =
                       Windows.Forms.DialogResult.Yes Then
            Me.Close()
            FrmLogin.Show()
            FrmLogin.txtUsu.Clear()
            FrmLogin.txtSenha.Clear()
        End If
    End Sub
    Private Sub MoradoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MoradoresToolStripMenuItem1.Click
        FrmConMorador.MdiParent = Me
        FrmConMorador.Show()
    End Sub

    Private Sub FuncionariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FuncionariosToolStripMenuItem1.Click
        FrmConFuncionario.MdiParent = Me
        FrmConFuncionario.Show()
    End Sub

    Private Sub ÁreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreasToolStripMenuItem.Click
        FrmCadArea.MdiParent = Me
        FrmCadArea.Show()
    End Sub

    Private Sub ReservasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem1.Click
        FrmConReservaSindico.MdiParent = Me
        FrmConReservaSindico.Show()

    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        FrmCadFornecedor.MdiParent = Me
        FrmCadFornecedor.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        FrmConFornecedores.MdiParent = Me
        FrmConFornecedores.Show()
    End Sub

    Private Sub PorPeríodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorPeríodoToolStripMenuItem.Click
        FrmConPeriodoEncomenda.MdiParent = Me
        FrmConPeriodoEncomenda.Show()
    End Sub

    Private Sub PorMoradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorMoradorToolStripMenuItem.Click
        FrmConEncomendas.MdiParent = Me
        FrmConEncomendas.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        FrmImp.MdiParent = Me
        Dim rpt As New CrpFuncionarios
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "HELVETIA LTDA"
        rpt.SummaryInfo.ReportComments = "Relatório de Funcionários"
        FrmImp.Show()
    End Sub

    Private Sub ExternosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExternosToolStripMenuItem1.Click
        FrmImp.MdiParent = Me
        Dim rpt As New CrpMorador_Externo
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "HELVETIA LTDA"
        rpt.SummaryInfo.ReportComments = "Relatório de Externos"
        FrmImp.Show()
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem.Click

    End Sub

    Private Sub EncomendasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EncomendasToolStripMenuItem1.Click
        FrmImp.MdiParent = Me
        Dim rpt As New CrpEncomendas
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "HELVETIA LTDA"
        rpt.SummaryInfo.ReportComments = "Relatório de Encomedas Entregues"
        FrmImp.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem2.Click
        FrmImp.MdiParent = Me
        Dim rpt As New CrpFornecedores
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "HELVETIA LTDA"
        rpt.SummaryInfo.ReportComments = "Relatório de Fornecedores"
        FrmImp.Show()
    End Sub

    Private Sub MoradoresToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MoradoresToolStripMenuItem2.Click
        FrmImp.MdiParent = Me
        Dim rpt As New CrpMoradores
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "HELVETIA LTDA"
        rpt.SummaryInfo.ReportComments = "Relatório de Moradores"
        FrmImp.Show()
    End Sub


    Private Sub CadastroDeMultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeMultasToolStripMenuItem.Click
        FrmCadMulta.MdiParent = Me
        FrmCadMulta.Show()
    End Sub

    Private Sub PorMoradorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorMoradorToolStripMenuItem1.Click
        FrmConMulta.MdiParent = Me
        FrmConMulta.Show()
    End Sub

    Private Sub PorPeríodoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PorPeríodoToolStripMenuItem1.Click
        FrmConPeriodoMulta.MdiParent = Me
        FrmConPeriodoMulta.Show()
    End Sub


    Private Sub GráficoAreaReservadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GráficoAreaReservadaToolStripMenuItem.Click
        FrmImp.MdiParent = Me
        Dim rpt As New CrpReservas
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "HELVETIA LTDA"
        rpt.SummaryInfo.ReportComments = "Relatório de Reservas"
        FrmImp.Show()
    End Sub

    Private Sub GráficoÁreaReservadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GráficoÁreaReservadaToolStripMenuItem.Click
        FrmImp.MdiParent = Me
        Dim rpt As New CrpGraficoReservas
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "HELVETIA LTDA"
        rpt.SummaryInfo.ReportComments = "Gráfico de Reservas por área"
        FrmImp.Show()
    End Sub

    Private Sub GráficoMultaPorMoradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GráficoMultaPorMoradorToolStripMenuItem.Click
        FrmImp.MdiParent = Me
        Dim rpt As New CrpGraficoMultaMorador
        rpt.Refresh()
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "HELVETIA LTDA"
        rpt.SummaryInfo.ReportComments = "Gráfico de multas por moradores"
        FrmImp.Show()
    End Sub
End Class