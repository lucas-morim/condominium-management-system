Public Class FrmConMulta
    Dim objMulta As New ClsMulta

    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        DgdMultas.DataSource = objMulta.localizarParaGradeSindico(txtCampo.Text)
    End Sub

    Private Sub FrmConMulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCampo.Clear()
        Call txtCampo_TextChanged(Nothing, Nothing)
    End Sub


End Class