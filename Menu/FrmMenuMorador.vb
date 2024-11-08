Public Class FrmMenuMorador

    Private Sub VisitantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitantesToolStripMenuItem.Click
        FrmCadExterno.MdiParent = Me
        FrmCadExterno.Show()
    End Sub

    Private Sub ReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservaToolStripMenuItem.Click
        FrmCadReservas.MdiParent = Me
        FrmCadReservas.Show()

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
End Class