Public Class FrmConFornecedores
    Dim objFornecedores As New ClsFornecedor
    Private Sub btnSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmConFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCampo.Clear()
        Call txtCampo_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        DgdFornecedor.DataSource = objFornecedores.localizarParaGrade(txtCampo.Text)
    End Sub


End Class