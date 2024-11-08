Public Class FrmCadFuncionario
    Dim objControle As New ClsControle
    Dim objFun As New ClsFuncionario
    Dim novo As String
    Dim EnderecoCompleto As String
    Dim objCargo As New ClsCargo

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCod.Enabled = False
        txtEnd.Enabled = False
        txtCid.Enabled = False
        txtEst.Enabled = False
        txtBai.Enabled = False
        ChkAtivo.Enabled = True
        txtCom.Enabled = True




        txtNom.Focus()
        novo = True
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSaiR.Click
        Me.Close()
    End Sub
    Private Sub FrmCadFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        txtCod.Enabled = False
        grpLoc.Visible = False
        txtCom.Enabled = False
        ChkAtivo.Enabled = False

        CboCar.DisplayMember = "codcar"
        CboCar.ValueMember = "nomcar"
        CboCar.DataSource = objCargo.localizar_Todos()


    End Sub

    Private Sub btnCadFun_Click(sender As Object, e As EventArgs) Handles btnCad.Click


        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
            objControle.Habilitar_tela(Me, True)
            objControle.Habilitar_botoes(Me, False)
            txtCom.Enabled = True
            ChkAtivo.Enabled = True
            txtEnd.Enabled = False
            txtCid.Enabled = False
            txtEst.Enabled = False
            txtBai.Enabled = False
            txtNom.Focus()


        Else

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
            txtCom.Enabled = False
            ChkAtivo.Enabled = False

            ' If Novo = False Then
            objFun.Codigo = Val(txtCod.Text)
            ' End If

            objFun.Nome = txtNom.Text
            objFun.Cargo = CboCar.Text
            objFun.Telefone = mskTel.Text
            objFun.RG = mskRg.Text
            objFun.CEP = txtCep.Text
            objFun.Endereco = EnderecoCompleto
            objFun.Numero = txtNum.Text
            objFun.Complemento = txtCom.Text
            objFun.Bairro = txtBai.Text
            objFun.Cidade = txtCid.Text
            objFun.Estado = txtEst.Text
            objFun.Salario = txtsal.Text
            objFun.Admissao = dtpDtAdm.Text
            objFun.Ativo = ChkAtivo.Checked

            objFun.gravar_dados(novo)

            txtCod.Text = objFun.Codigo


        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Call FrmCadFuncionario_Load(Nothing, Nothing)
        btnLoc.Enabled = True
    End Sub
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlt.Click
      objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCod.Enabled = False
        txtEnd.Enabled = False
        txtCid.Enabled = False
        txtEst.Enabled = False
        txtBai.Enabled = False
        txtCom.Enabled = True
        ChkAtivo.Enabled = True
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
        If objFun.localizar(txtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            grpLoc.Visible = False
            btnLoc.Enabled = True
        Else
            txtLoc.Clear()
            txtLoc.Focus()
        End If
    End Sub
    Private Sub Mostrar_dados_da_tela()

        txtCod.Text = objFun.Codigo
        txtNom.Text = objFun.Nome
        CboCar.Text = objFun.Cargo
        mskTel.Text = objFun.Telefone
        mskRg.Text = objFun.RG
        txtCep.Text = objFun.CEP
        txtEnd.Text = objFun.Endereco
        txtCid.Text = objFun.Cidade
        txtEst.Text = objFun.Estado
        txtBai.Text = objFun.Bairro
        txtNum.Text = objFun.Numero
        txtCom.Text = objFun.Complemento
        txtsal.Text = objFun.Salario
        dtpDtAdm.Value = objFun.Admissao
        ChkAtivo.Checked = objFun.Ativo



    End Sub




    Private Sub TxtCEP_Validated(sender As Object, e As EventArgs) Handles txtCep.Validated
        If txtCep.Text.Length = 0 Then
            MessageBox.Show("CEP está vazio", "Aviso", MessageBoxButtons.OK)
            EnderecoCompleto = txtEnd.Text
            txtCep.Clear()
            txtBai.Clear()
            txtCid.Clear()
            txtEst.Clear()
            txtEnd.Clear()
        Else
            Dim xml As String = String.Format("http://cep.republicavirtual.com.br/web_cep.php?cep={0}&formato=xml", txtCep.Text)

            Dim ds As New DataSet()
            ds.ReadXml(xml)

            If ds.Tables(0).Rows(0)(2).ToString() = "sucesso - cep não encontrado" Or ds.Tables(0).Rows(0)(2).ToString() = "sucesso - cep completo" Then
                MessageBox.Show("CEP incorreto", "Aviso", MessageBoxButtons.OK)
                txtCep.Clear()
                txtBai.Clear()
                txtCid.Clear()
                txtEst.Clear()
                txtEnd.Clear()
                txtCep.Focus()
            Else

                lblEndereco.Text = ds.Tables(0).Rows(0)(5).ToString()

                txtEnd.Text = ds.Tables(0).Rows(0)(6).ToString()
                txtBai.Text = ds.Tables(0).Rows(0)(4).ToString()
                txtCid.Text = ds.Tables(0).Rows(0)(3).ToString()
                txtEst.Text = ds.Tables(0).Rows(0)(2).ToString()
                EnderecoCompleto = lblEndereco.Text & " " & txtEnd.Text
            End If
        End If
    End Sub

    Private Sub txtsal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsal.KeyPress
        e.Handled = objControle.SoNumerosEVirgula(e.KeyChar)
    End Sub

    Private Sub txtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum.KeyPress
        e.Handled = objControle.SoNumeros(e.KeyChar)
    End Sub

    Private Sub mskTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskTel.KeyPress
        e.Handled = objControle.SoNumeros(e.KeyChar)
    End Sub

    Private Sub CboCar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboCar.KeyPress
        e.Handled = True
    End Sub

    Private Sub CboCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCar.SelectedIndexChanged
        If CboCar.Text = "1" Then
            LblNomCar.Text = "Sindico"
        ElseIf CboCar.Text = "2" Then
            LblNomCar.Text = "Porteiro"
        ElseIf CboCar.Text = "3" Then
            LblNomCar.Text = "Zelador"
        ElseIf CboCar.Text = "4" Then
            LblNomCar.Text = "Limpeza"
        End If
    End Sub
End Class