Public Class FrmCadMulta
    Dim objMult As New ClsMulta
    Dim objControle As New ClsControle
    Dim novo As String
    Dim objMor As New ClsMorador

    Private Sub btnBusc_Click(sender As Object, e As EventArgs) Handles btnBusc.Click
        FrmConMorador.ShowDialog()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCod.Enabled = False
        txtVal.Enabled = True
        novo = True

        btnBusc.Enabled = True
    End Sub

    Private Sub btnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click
        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
            objControle.Habilitar_tela(Me, True)
            objControle.Habilitar_botoes(Me, False)
            txtMotivo.Focus()

        Else


            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)


            'If novo = False Then
            objMult.Codigo = Val(txtCod.Text)
            'End If

            objMult.Morador = LblNom.Text
            objMult.CodigoMorador = txtCodMor.Text
            objMult.Bloco = LblBlo.Text
            objMult.Apartamento = LblApt.Text
            objMult.Motivo = txtMotivo.Text
            objMult.Data = dtpData.Text
            objMult.Hora = dtpHora.Text
            objMult.Valor = txtVal.Text

            objMult.gravar_dados(novo)

            txtCod.Text = objMult.Codigo

        End If
    End Sub

    Private Sub btnAlt_Click(sender As Object, e As EventArgs) Handles btnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCod.Enabled = False
        txtVal.Enabled = True
        novo = False
        btnBusc.Enabled = True
    End Sub

    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Call FrmCadMulta_Load(Nothing, Nothing)
    End Sub

    Private Sub FrmCadMulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        txtVal.Enabled = False
        txtCod.Enabled = False
        btnBusc.Enabled = False

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Dim rpt As New CrpMultasUnicas
        rpt.Refresh()
        rpt.SetDataSource(objMult.localizarUnicaMulta(objMult.Codigo))
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        FrmImp.ShowDialog()
    End Sub
End Class