Public Class FrmConPeriodoMulta
    Dim objMulta As New ClsMulta
    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        If objMulta.localizarPorPeriodo(DtpIni.Text, DtpFim.Text).Rows.Count > 0 Then
            DgdMultas.DataSource = objMulta.localizarPorPeriodo(DtpIni.Text, DtpFim.Text)
        ElseIf objMulta.localizarPorPeriodo(DtpIni.Text, DtpFim.Text).Rows.Count = 0 And DtpIni.Text <> DtpFim.Text Then
            MessageBox.Show("Nenhuma reserva foi encontrada neste período!")
            DgdMultas.DataSource = objMulta.localizarPorPeriodo(Nothing, Nothing)

        ElseIf DtpIni.Text = DtpFim.Text Then
            MessageBox.Show("As datas de início e fim estão iguais, preencha corretamente!")
        End If
    End Sub

End Class