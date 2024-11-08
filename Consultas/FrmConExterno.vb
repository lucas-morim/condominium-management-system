Public Class FrmConExterno
    Dim objExterno As New ClsExterno
    Private Sub btnSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmConExterno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCampo.Clear()
        Call txtCampo_TextChanged(Nothing, Nothing)
    End Sub

    
    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        DgdExterno.DataSource = objExterno.localizarParaGrade(txtCampo.Text)
    End Sub


End Class