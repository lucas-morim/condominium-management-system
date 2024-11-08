Public Class FrmConPeriodoEncomenda
    Dim objEncomendas As New ClsEncomenda
    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click

        If objEncomendas.localizarPorPeriodo(DtpIni.Text, DtpFim.Text).Rows.Count > 0 Then
            DgdEncomenda.DataSource = objEncomendas.localizarPorPeriodo(DtpIni.Text, DtpFim.Text)
        ElseIf objEncomendas.localizarPorPeriodo(DtpIni.Text, DtpFim.Text).Rows.Count = 0 And DtpIni.Text <> DtpFim.Text Then
            MessageBox.Show("Nenhuma reserva foi encontrada neste período!")
            DgdEncomenda.DataSource = objEncomendas.localizarPorPeriodo(Nothing, Nothing)

        ElseIf DtpIni.Text = DtpFim.Text Then
            MessageBox.Show("As datas de início e fim estão iguais, preencha corretamente!")
        End If
    End Sub

    Private Sub FrmConPeriodoEncomenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class