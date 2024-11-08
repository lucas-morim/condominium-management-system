Public Class FrmMenuSin

    Private Sub MoradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoradoresToolStripMenuItem.Click
        FrmCadMor.MdiParent = Me
        FrmCadMor.Show()
    End Sub

    Private Sub FuncionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionariosToolStripMenuItem.Click
        FrmCadFun.MdiParent = Me
        FrmCadFun.Show()
    End Sub

    Private Sub ExternosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExternosToolStripMenuItem.Click
        FrmConExt.MdiParent = Me
        FrmConExt.Show()
    End Sub

    Private Sub RelatorioDeAcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatorioDeAcessoToolStripMenuItem.Click
        FrmConsAce.MdiParent = Me
        FrmConsAce.Show()

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem.Click
        FrmRes.MdiParent = Me
        FrmRes.Show()
    End Sub

    Private Sub MoradoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MoradoresToolStripMenuItem1.Click
        FrmDadosMor.MdiParent = Me
        FrmDadosMor.Show()
    End Sub

    Private Sub FuncionariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FuncionariosToolStripMenuItem1.Click
        FrmConsFun.MdiParent = Me
        FrmConsFun.Show()
    End Sub

    Private Sub ÁreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreasToolStripMenuItem.Click
        FrmCadArea.MdiParent = Me
        FrmCadArea.Show()
    End Sub

    Private Sub ReservasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem1.Click
        FrmConRes.MdiParent = Me
        FrmConRes.Show()
    End Sub

    Private Sub MultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultasToolStripMenuItem.Click
        FrmMultas.MdiParent = Me
        FrmMultas.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click
        FrmEmpresas.MdiParent = Me
        FrmEmpresas.Show()
    End Sub
End Class