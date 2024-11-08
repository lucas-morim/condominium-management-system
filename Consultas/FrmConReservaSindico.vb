Public Class FrmConReservaSindico
    Dim objres As New ClsReserva
    Dim contagem As Integer

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click

        If objres.localizarPorPeriodo(DtpIni.Text, DtpFim.Text).Rows.Count > 0 Then
            DgdReservaSind.DataSource = objres.localizarPorPeriodo(DtpIni.Text, DtpFim.Text)
            txtTotalRes.Text = objres.localizarReservaTotalPorPeriodo(DtpIni.Text, DtpFim.Text)
        ElseIf objres.localizarPorPeriodo(DtpIni.Text, DtpFim.Text).Rows.Count = 0 And DtpIni.Text <> DtpFim.Text Then
            MessageBox.Show("Nenhuma reserva foi encontrada neste período!")
            DgdReservaSind.DataSource = objres.localizarPorPeriodo(Nothing, Nothing)
            txtTotalRes.Text = 0
        ElseIf DtpIni.Text = DtpFim.Text Then
            MessageBox.Show("As datas de início e fim estão iguais, preencha corretamente!")
        End If

        'If contagem = 0 Then
        '    DgdReservaSind.DataSource = objres.localizarPorPeriodo(DtpIni.Text, DtpFim.Text)
        '    txtTotalRes.Text = objres.localizarReservaTotalPorPeriodo(DtpIni.Text, DtpFim.Text)
        '    contagem += 1
        'ElseIf DtpIni.Text <> DtpFim.Text Then
        '    MessageBox.Show("Nenhuma reserva foi encontrada neste período!")
        'ElseIf DtpIni.Text = DtpFim.Text Then
        '    MessageBox.Show("As datas de início e fim estão iguais, preencha corretamente!")
        'ElseIf DtpIni.Text > DtpFim.Text Then
        '    MessageBox.Show("A data de início está a frente do final, preencha corretamente!")
        'ElseIf contagem = 1 Then

        'End If


        'If contagem = 1 Then
        '    contagem = 0
        'End If




    End Sub

    Private Sub FrmConReservaSindico_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtTotalRes.Enabled = False
        contagem = 0
    End Sub

    Private Sub DtpIni_ValueChanged(sender As Object, e As EventArgs) Handles DtpIni.ValueChanged

    End Sub
End Class