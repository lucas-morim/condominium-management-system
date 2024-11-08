Public Class FrmCadExterno
    Dim objExt As New ClsExterno
    Dim objControle As New ClsControle
    Dim novo As String
    Dim objMor As New ClsMorador

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCod.Enabled = False

        txtNom.Focus()
        novo = True

        dtpDtFim.Enabled = False
        dtpDtIni.Enabled = False
        txtEmp.Enabled = True
        ChkInt.Enabled = True
        ChkSer.Enabled = True
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub FrmCadExterno_Load(sender As Object, e As EventArgs) Handles Me.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        txtCod.Enabled = False
        grpLoc.Visible = False
        txtEmp.Enabled = False
        btnBusc.Enabled = False
        ChkInt.Enabled = False
        ChkSer.Enabled = False


    End Sub
    Private Sub btnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click
        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
            objControle.Habilitar_tela(Me, True)
            objControle.Habilitar_botoes(Me, False)
            txtEmp.Enabled = True
            txtNom.Focus()

        Else

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
            txtEmp.Enabled = False

            objControle.Habilitar_botoes(Me, True)

            'If novo = False Then
            objExt.Codigo = Val(txtCod.Text)
            'End If

            objExt.Nome = txtNom.Text
            objExt.RG = mskRg.Text
            objExt.CodigoMorador = lblCodMor.Text
            objExt.Empresa = txtEmp.Text
            objExt.Inicio = dtpDtIni.Text
            objExt.Fim = dtpDtFim.Text
            objExt.Interfone = ChkInt.Checked
            objExt.Servico = ChkSer.Checked

            objExt.gravar_dados(novo)

            txtCod.Text = objExt.Codigo

        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Call FrmCadExterno_Load(Nothing, Nothing)
        btnLoc.Enabled = True

    End Sub
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)

        txtCod.Enabled = False
        txtEmp.Enabled = True
        ChkInt.Enabled = True
        ChkSer.Enabled = True
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
        If objExt.localizar(txtLoc.Text) = True Then
            Call Mostrar_dados_da_tela()
            grpLoc.Visible = False
            btnLoc.Enabled = True
        Else
            txtLoc.Clear()
            txtLoc.Focus()
        End If

    End Sub

    Private Sub Mostrar_dados_da_tela()

        txtCod.Text = objExt.Codigo
        txtNom.Text = objExt.Nome
        mskRg.Text = objExt.RG
        txtEmp.Text = objExt.Empresa
        lblCodMor.Text = objExt.CodigoMorador
        ChkSer.Checked = objExt.Servico
        ChkInt.Checked = objExt.Interfone
        dtpDtIni.Value = objExt.Inicio
        dtpDtFim.Value = objExt.Fim



    End Sub

    Private Sub btnBusc_Click(sender As Object, e As EventArgs)
        FrmConMorador.ShowDialog()
    End Sub

    Private Sub ChkSer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSer.CheckedChanged
        If ChkSer.Checked = True Then
            dtpDtIni.Enabled = True
            dtpDtFim.Enabled = True
        ElseIf ChkSer.Checked = False Then
            dtpDtIni.Enabled = False
            dtpDtFim.Enabled = False
        End If
    End Sub

    Private Sub btnBuscArea_Click(sender As Object, e As EventArgs) Handles btnBusc.Click
        FrmConMorador.ShowDialog()
    End Sub


End Class