Public Class FrmCadFun
    Dim objControle As New ClsControle
    Dim objFun As New ClsFuncionario
    Dim novo As String
    Dim EnderecoCompleto As String

    Private Sub btnCadFun_Click(sender As Object, e As EventArgs) Handles btnCad.Click
        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        Else



            ' If Novo = False Then
            objFun.Codigo = Val(txtCod.Text)
            ' End If

            objFun.Nome = txtNom.Text
            objFun.Cargo = txtCar.Text
            objFun.Telefone = mskTel.Text
            objFun.RegistroGeral = txtRg.Text
            objFun.CEP = txtCep.Text
            objFun.Endereco = EnderecoCompleto
            objFun.NumeroEndereco = txtNum.Text
            objFun.ComplementoEndereco = txtCom.Text
            objFun.Bairro = txtBai.Text
            objFun.Cidade = txtCid.Text
            objFun.Estado = txtEst.Text
            objFun.Salario = mskSal.Text
            objFun.Admissao = dtpDtAdm.Text
            objFun.Atividade = ChkAtivo.Checked

            objFun.gravar_dados(novo)

            txtCod.Text = objFun.Codigo


        End If
    End Sub

    Private Sub FrmCadFun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Habilitar_tela(Me, False)

        novo = True
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
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        txtCod.Focus()
        novo = True
    End Sub
End Class