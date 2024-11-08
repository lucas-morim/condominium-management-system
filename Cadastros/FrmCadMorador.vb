Public Class FrmCadMorador
    Dim objControle As New ClsControle
    Dim objMor As New ClsMorador
    Dim novo As Boolean
    Dim objApt As New ClsApartamento



    Private Sub btnNovCad_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)

        txtCod.Enabled = False
        txtNom.Focus()
        novo = True
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub FrmCadMorador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        txtCod.Enabled = False
        grpLoc.Visible = False

        CboApt.DisplayMember = "numapt"
        CboApt.DataSource = objApt.localizar_Todos()

        CboBlo.DisplayMember = "bloapt"
        CboBlo.DataSource = objApt.localizar_blocos()

    End Sub
    Private Sub BtnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click

        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
            objControle.Habilitar_tela(Me, True)
            objControle.Habilitar_botoes(Me, False)
            txtNom.Focus()


        Else

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)



            'If novo = False Then
            objMor.Codigo = Val(txtCod.Text)
            'End If

            objMor.NomeMorador = txtNom.Text
            objMor.Telefone = mskTel.Text
            objMor.Email = txtEmail.Text
            objMor.RG = mskRg.Text
            objMor.CPF = mskCpf.Text()
            objMor.TelefoneEmergencia = mskTelEmer.Text
            objMor.NumeroApartamento = CboApt.Text
            objMor.Bloco = CboBlo.Text

            objMor.gravar_dados(novo)

            txtCod.Text = objMor.Codigo

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Call FrmCadMorador_Load(Nothing, Nothing)
        btnLoc.Enabled = True

    End Sub

    Private Sub btnAlt_Click(sender As Object, e As EventArgs) Handles btnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCod.Enabled = False
        txtNom.Focus()
        novo = False
    End Sub

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        grpLoc.Visible = True
        btnLoc.Enabled = False
        btnConfirmar.Enabled = False
        txtLoc.Text = ""
        txtLoc.Focus()
    End Sub

    Private Sub txtLoc_TextChanged(sender As Object, e As EventArgs) Handles txtLoc.TextChanged
        If txtLoc.Text <> "" Then
            btnConfirmar.Enabled = True
        Else
            btnConfirmar.Enabled = False
        End If

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If objMor.localizar(txtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            grpLoc.Visible = False
            btnLoc.Enabled = True
        Else
            txtLoc.Clear()
            txtLoc.Focus()
        End If
    End Sub

    Private Sub Mostrar_dados_da_tela()
        txtCod.Text = objMor.Codigo
        CboApt.Text = objMor.NumeroApartamento
        txtNom.Text = objMor.NomeMorador
        mskTel.Text = objMor.Telefone
        txtEmail.Text = objMor.Email
        mskTelEmer.Text = objMor.TelefoneEmergencia
        mskRg.Text = objMor.RG
        mskCpf.Text = objMor.CPF
        CboBlo.Text = objMor.Bloco


    End Sub

    Private Sub mskTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskTel.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub txtCPF_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub CboApt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboApt.KeyPress
        e.Handled = True
    End Sub

    Private Sub mskTelEmer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskTelEmer.KeyPress
        e.Handled = objControle.SoNumeros(e.KeyChar)
    End Sub

    Private Sub CboBlo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboBlo.KeyPress
        e.Handled = True
    End Sub


End Class