Public Class FrmCadReservas
    Dim objRes As New ClsReserva
    Dim objControle As New ClsControle
    Dim novo As String

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Call FrmCadReservas_Load(Nothing, Nothing)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCodRes.Enabled = False

        txtCodArea.Focus()
        novo = True

        txtCodArea.Enabled = False
        txtValor.Enabled = False
        txtQtdMax.Enabled = False
        txtNomMor.Enabled = False
        txtCodMor.Enabled = False
        txtArea.Enabled = False

    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmCadReservas_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
    Private Sub FrmCadReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If DgdReserva.CurrentRow.Cells(2).Value < DateTime.Now.Date Then
        '    DgdReserva.Rows.RemoveAt(DgdReserva.CurrentRow.Index)
        'End If


        
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        btnBuscArea.Enabled = False
        btnBuscMor.Enabled = False

        txtCampo.Clear()

        DgdReserva.DataSource = objRes.localizarParaGradeOrdenado(DateTime.Now.Date)
        '  Call txtCampo_TextChanged(Nothing, Nothing)
        dtpData.MinDate = DateTime.Now.Date
    End Sub

    Private Sub btnCad_Click(sender As Object, e As EventArgs) Handles btnCad.Click



        If objControle.Testar_Vazio(Me) = True Then


            MessageBox.Show("Favor preencher todos os campos obrigatórios")
            objControle.Habilitar_tela(Me, True)
            objControle.Habilitar_botoes(Me, False)
            txtCodArea.Focus()
            txtArea.Enabled = False
            txtValor.Enabled = False
            txtNomMor.Enabled = False
            txtQtdMax.Enabled = False

        Else

            For x = 0 To DgdReserva.Rows.Count - 1
                If dtpData.Text = DgdReserva.Rows(x).Cells(2).Value And txtArea.Text = DgdReserva.Rows(x).Cells(0).Value Then
                    MessageBox.Show("Já existe reserva para  " & txtArea.Text & " no dia " & DgdReserva.Rows(x).Cells(2).Value)
                    Exit Sub

                End If
            Next
            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)


            'If novo = False Then
            objRes.Codigo = Val(txtCodRes.Text)
            'End If

            objRes.NomeArea = txtArea.Text
            objRes.Area = txtCodArea.Text
            objRes.CodigoMorador = txtCodMor.Text
            objRes.QuantidadeParticipantes = txtQtdPar.Text
            objRes.QuantidadeMaxima = txtQtdMax.Text
            objRes.NomeMorador = txtNomMor.Text
            objRes.Valor = txtValor.Text
            objRes.Data = dtpData.Text
            objRes.Horario = txtHor.Text
            objRes.Convidados = txtCon.Text




            objRes.gravar_dados(novo)

            txtCodRes.Text = objRes.Codigo
        End If







    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Call FrmCadReservas_Load(Nothing, Nothing)
    End Sub
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)

        txtCodArea.Focus()
        novo = False

        txtCodArea.Enabled = False
        txtValor.Enabled = False
        txtQtdMax.Enabled = False
        txtNomMor.Enabled = False
        txtCodMor.Enabled = False
        txtArea.Enabled = False
    End Sub

    Private Sub btnBuscArea_Click(sender As Object, e As EventArgs) Handles btnBuscArea.Click
        FrmConArea.ShowDialog()
    End Sub

    Private Sub btnBuscMor_Click(sender As Object, e As EventArgs) Handles btnBuscMor.Click
        FrmConMorador.ShowDialog()
    End Sub

    Private Sub txtQtdPar_Validated(sender As Object, e As EventArgs) Handles txtQtdPar.Validated
        If txtQtdPar.Text > txtQtdMax.Text Then
            MessageBox.Show("Número de participantes maior que o número máximo, por favor preencha corretamente!")
            txtQtdPar.Focus()
            txtQtdPar.Clear()
        End If
    End Sub


    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged

    End Sub

    Private Sub txtHor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHor.KeyPress
        e.Handled = True
    End Sub

    'Private Sub dtpData_Validated(sender As Object, e As EventArgs) Handles dtpData.Validated

    '    If dtpData.Value = DgdReserva.CurrentRow.Cells(2).Value Then
    '        MessageBox.Show("Já existe uma reserva no dia selecionado")
    '    End If
    'End Sub

    Private Sub DgdReserva_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdReserva.CellContentClick

    End Sub
End Class