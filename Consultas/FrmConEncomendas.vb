Public Class FrmConEncomendas
    Dim objenc As New ClsEncomenda
    Private Sub FrmConEncomendas_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtCampo.Clear()
        Call txtCampo_TextChanged(Nothing, Nothing)
    End Sub
    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        DgdEncomenda.DataSource = objenc.localizarParaGradeSindico(txtCampo.Text)
    End Sub
End Class