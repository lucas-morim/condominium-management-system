Public Class FrmMenuPortaria

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        FrmCadExterno.MdiParent = Me
        FrmCadExterno.Show()
    End Sub

    Private Sub MoradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoradoresToolStripMenuItem.Click
        FrmConMorador.MdiParent = Me
        FrmConMorador.Show()
    End Sub
    Private Sub ExternosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExternosToolStripMenuItem.Click
        FrmConExterno.MdiParent = Me
        FrmConExterno.Show()
    End Sub
    Private Sub EncomendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncomendasToolStripMenuItem.Click
        FrmEncomenda.MdiParent = Me
        FrmEncomenda.Show()
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

    Private Sub ReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem.Click
        FrmConReserva.MdiParent = Me
        FrmConReserva.Show()
    End Sub
End Class