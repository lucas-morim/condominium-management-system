Public Class FrmMenuPort

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        FrmCadExt.MdiParent = Me
        FrmCadExt.Show()
    End Sub

    Private Sub ControleDeAcessosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleDeAcessosToolStripMenuItem.Click
        FrmContAce.MdiParent = Me
        FrmContAce.Show()
    End Sub

    Private Sub EncomendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncomendasToolStripMenuItem.Click
        FrmEnc.MdiParent = Me
        FrmEnc.Show()
    End Sub

    Private Sub MoradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoradoresToolStripMenuItem.Click
        FrmDadosMor.MdiParent = Me
        FrmDadosMor.Show()
    End Sub
    Private Sub ExternosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExternosToolStripMenuItem.Click
        FrmConExt.MdiParent = Me
        FrmConExt.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
        FrmLogin.Show()
    End Sub
End Class