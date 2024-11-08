Public Class FrmCadFornecedor
    Dim objControle As New ClsControle
    Dim objForn As New ClsFornecedor
    Dim novo As Boolean
    Private Sub btnNovCad_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)

        txtCod.Enabled = False
        txtDesc.Enabled = True
        txtNom.Focus()
        novo = True
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmCadFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)


        txtCod.Enabled = False
        txtDesc.Enabled = False
        grpLoc.Visible = False
    End Sub
    Private Sub BtnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click

        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
            objControle.Habilitar_tela(Me, True)
            objControle.Habilitar_botoes(Me, False)
            txtDesc.Enabled = True
            txtNom.Focus()


        Else


            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
            txtDesc.Enabled = False

            'If novo = False Then
            objForn.Codigo = Val(txtCod.Text)
            'End If

            objForn.Nome = txtNom.Text
            objForn.CNPJ = mskCnpj.Text
            objForn.Telefone = mskTel.Text
            objForn.Descricao = txtDesc.Text
            objForn.NomeDoContato = txtNomCon.Text

            objForn.gravar_dados(novo)

            txtCod.Text = objForn.Codigo



        End If
    End Sub

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        grpLoc.Visible = True
        btnLoc.Enabled = False
        btnConfirmar.Enabled = False
        txtLoc.Text = ""
        txtLoc.Focus()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If objForn.localizar(txtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            grpLoc.Visible = False
            btnLoc.Enabled = True
        Else
            txtLoc.Clear()
            txtLoc.Focus()
        End If
    End Sub

    Private Sub txtLoc_TextChanged(sender As Object, e As EventArgs) Handles txtLoc.TextChanged
        If txtLoc.Text <> "" Then
            btnConfirmar.Enabled = True
        Else
            btnConfirmar.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Call FrmCadFornecedor_Load(Nothing, Nothing)
        btnLoc.Enabled = True

    End Sub
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCod.Enabled = False
        txtDesc.Enabled = True
        txtNom.Focus()
        novo = False
    End Sub
    Private Sub Mostrar_dados_da_tela()

        txtCod.Text = objForn.Codigo
        txtNom.Text = objForn.Nome
        mskCnpj.Text = objForn.CNPJ
        mskTel.Text = objForn.Telefone
        txtDesc.Text = objForn.Descricao
        txtNomCon.Text = objForn.NomeDoContato
    End Sub

    Private Sub txtCNPJ_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = objControle.SoNumeros(e.KeyChar)
    End Sub

    Private Sub mskTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskTel.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub
End Class