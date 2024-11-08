Public Class FrmConFuncionario
    Dim objFuncionario As New ClsFuncionario
    Private Sub FrmConFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCampo.Clear()
        Call txtCampo_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        DgdFuncionario.DataSource = objFuncionario.localizarParaGrade(txtCampo.Text)
    End Sub
End Class