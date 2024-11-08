Public Class FrmCadExt
    Dim objExt As New ClsExterno
    Dim objControle As New ClsControle
    Dim novo As String



    Private Sub btnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click
        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else



            ' If Novo = False Then
            objExt.Codigo = Val(txtCod.Text)
            ' End If

            objExt.Nome = txtNome.Text
            objExt.Empresa = txtEmp.Text
            objExt.RG = txtRG.Text
            objExt.CodigoMorador = txtCodMor.Text
            objExt.Interfone = ChkInt.Checked
            objExt.Servico = ChkSer.Checked
            objExt.Inicio = dtpDtIni.Text
            objExt.Fim = dtpDtFim.Text

            objExt.gravar_dados(novo)

            txtCod.Text = objExt.Codigo
        End If
    End Sub

    Private Sub btnBusc_Click(sender As Object, e As EventArgs) Handles SS.Click
        FrmDadosMor.ShowDialog()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmCadExt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Habilitar_tela(Me, False)
        novo = True
    End Sub
End Class