Public Class FrmConReserva
    Dim objRes As New ClsReserva
    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        If objRes.localizarPorPeriodo(DtpIni.Text, DtpFim.Text).Rows.Count > 0 Then
            DgdReserva.DataSource = objRes.localizarPorPeriodo(DtpIni.Text, DtpFim.Text)
        ElseIf objRes.localizarPorPeriodo(DtpIni.Text, DtpFim.Text).Rows.Count = 0 And DtpIni.Text <> DtpFim.Text Then
            MessageBox.Show("Nenhuma reserva foi encontrada neste período!")
            DgdReserva.DataSource = objRes.localizarPorPeriodo(Nothing, Nothing)
        ElseIf DtpIni.Text = DtpFim.Text Then
            MessageBox.Show("As datas de início e fim estão iguais, preencha corretamente!")
        End If
    End Sub

End Class