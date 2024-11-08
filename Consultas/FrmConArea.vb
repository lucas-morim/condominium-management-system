Public Class FrmConArea
    Dim objArea As New ClsArea
    Private Sub btnSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmConArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCampo.Clear()
        Call txtCampo_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        DgdArea.DataSource = objArea.localizarParaGrade(txtCampo.Text)
    End Sub
    Private Sub DgdArea_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdArea.CellContentDoubleClick
        FrmCadReservas.txtCodArea.Text = DgdArea.CurrentRow.Cells(0).Value
        FrmCadReservas.txtValor.Text = DgdArea.CurrentRow.Cells(2).Value
        FrmCadReservas.txtQtdMax.Text = DgdArea.CurrentRow.Cells(3).Value
        FrmCadReservas.txtArea.Text = DgdArea.CurrentRow.Cells(1).Value
        Me.Close()

    End Sub
End Class
