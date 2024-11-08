Public Class FrmCadMor
    Dim objControle As New ClsControle
    Dim objMor As New ClsMorador
    Dim novo As String

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnNovCad_Click(sender As Object, e As EventArgs) Handles btnNovCad.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        txtCod.Focus()
        novo = True
    End Sub

    Private Sub BtnCad_Click(sender As Object, e As EventArgs) Handles BtnCad.Click
        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else

            objControle.Habilitar_botoes(Me, True)

            'If novo = False Then
            objMor.Codigo = Val(txtCod.Text)
            'End If

            objMor.Nome = txtNom.Text
            objMor.Telefone = mskTel.Text
            objMor.Email = txtEma.Text
            objMor.RG = txtRG.Text
            objMor.CPF = txtCPF.Text
            objMor.TelefoneEmergencia = mskTelEmer.Text
            objMor.Apartamento = CmbAP.Text
            objMor.Bloco = CmbBloc.Text

            objMor.gravar_dados(novo)

            txtCod.Text = objMor.Codigo

        End If
    End Sub

    Private Sub FrmCadMor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        novo = True
    End Sub
End Class