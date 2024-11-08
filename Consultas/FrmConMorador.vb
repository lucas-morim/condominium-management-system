Public Class FrmConMorador
    Dim objMorador As New ClsMorador

    Private Sub FrmConMorador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCampo.Clear()
        Call txtCampo_TextChanged(Nothing, Nothing)
    End Sub
    Private Sub DgdMorador_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdMorador.CellDoubleClick
        FrmCadExterno.lblCodMor1.Text = DgdMorador.CurrentRow.Cells(2).Value
        FrmCadExterno.lblCodMor.Text = DgdMorador.CurrentRow.Cells(0).Value

        FrmCadEncomenda.lblCodMor.Text = DgdMorador.CurrentRow.Cells(0).Value
        FrmCadEncomenda.LblNom.Text = DgdMorador.CurrentRow.Cells(2).Value
        FrmCadEncomenda.LblApt.Text = DgdMorador.CurrentRow.Cells(1).Value
        FrmCadEncomenda.LblBlo.Text = DgdMorador.CurrentRow.Cells(8).Value

        FrmCadReservas.txtCodMor.Text = DgdMorador.CurrentRow.Cells(0).Value
        FrmCadReservas.txtNomMor.Text = DgdMorador.CurrentRow.Cells(2).Value

        FrmCadMulta.txtCodMor.Text = DgdMorador.CurrentRow.Cells(0).Value
        FrmCadMulta.LblNom.Text = DgdMorador.CurrentRow.Cells(2).Value
        FrmCadMulta.LblApt.Text = DgdMorador.CurrentRow.Cells(1).Value
        FrmCadMulta.LblBlo.Text = DgdMorador.CurrentRow.Cells(8).Value

        Me.Close()
    End Sub

    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        DgdMorador.DataSource = objMorador.localizarParaGrade(txtCampo.Text)
    End Sub

End Class