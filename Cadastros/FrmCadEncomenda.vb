Public Class FrmCadEncomenda
    Dim objEnc As New ClsEncomenda
    Dim objControle As New ClsControle
    Dim novo As String
    Dim objMor As New ClsMorador

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCod.Enabled = False
        novo = True

        btnBusc.Enabled = True



    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
        FrmEncomenda.MdiParent = FrmMenuPortaria
        FrmEncomenda.Show()
    End Sub
    Private Sub FrmCadEncomenda_Load(sender As Object, e As EventArgs) Handles Me.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        txtCod.Enabled = False
        btnBusc.Enabled = False


    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCad.Click



        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
            objControle.Habilitar_tela(Me, True)
            objControle.Habilitar_botoes(Me, False)
            txtDesc.Focus()

        Else

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)


            'If novo = False Then
            objEnc.Codigo = Val(txtCod.Text)
            'End If

            objEnc.NomeMorador = LblNom.Text
            objEnc.Data = dtpData.Text
            objEnc.Hora = dtpHora.Text
            objEnc.CodigoMorador = lblCodMor.Text
            objEnc.Descricao = txtDesc.Text
            objEnc.Numero = LblApt.Text
            objEnc.Bloco = LblBlo.Text


            objEnc.gravar_dados(novo)

            txtCod.Text = objEnc.Codigo

        End If


    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Call FrmCadEncomenda_Load(Nothing, Nothing)
    End Sub
    Private Sub txtBusc_Click(sender As Object, e As EventArgs)
        FrmConMorador.ShowDialog()
        txtDesc.Focus()

    End Sub
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCod.Enabled = False
        novo = False
        btnBusc.Enabled = True
    End Sub

    Private Sub txtCodMor_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = objControle.SoNumeros(e.KeyChar)
    End Sub

    Private Sub btnBusc_Click(sender As Object, e As EventArgs) Handles btnBusc.Click
        FrmConMorador.ShowDialog()
    End Sub
End Class