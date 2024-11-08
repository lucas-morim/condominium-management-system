Public Class FrmEncomenda
    Dim objEnc As New ClsEncomenda
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmCadEncomenda.MdiParent = FrmMenuPortaria
        FrmCadEncomenda.Show()
        Me.Close()
    End Sub

    Private Sub txtCampo_TextChanged(sender As Object, e As EventArgs) Handles txtCampo.TextChanged
        DgdEncomenda.DataSource = objEnc.localizarParaGrade(txtCampo.Text)

        For Each row As DataGridViewRow In DgdEncomenda.Rows
            Dim ini, fim As Date
            ini = CDate(row.Cells(3).Value)
            fim = Now.ToShortDateString
            If DateDiff(DateInterval.Day, ini, fim) = 0 Then
                row.DefaultCellStyle.BackColor = Color.ForestGreen
            ElseIf DateDiff(DateInterval.Day, ini, fim) = 2 Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            ElseIf DateDiff(DateInterval.Day, ini, fim) >= 3 Then
                row.DefaultCellStyle.BackColor = Color.IndianRed
            Else
            End If
        Next
    End Sub

    Private Sub FrmEncomenda_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        For Each row As DataGridViewRow In DgdEncomenda.Rows
            Dim ini, fim As Date
            ini = CDate(row.Cells(3).Value)
            fim = Now.ToShortDateString
            If DateDiff(DateInterval.Day, ini, fim) = 0 Then
                row.DefaultCellStyle.BackColor = Color.ForestGreen
            ElseIf DateDiff(DateInterval.Day, ini, fim) = 2 Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            ElseIf DateDiff(DateInterval.Day, ini, fim) >= 3 Then
                row.DefaultCellStyle.BackColor = Color.IndianRed
            Else
            End If
        Next


    End Sub

    Private Sub FrmConEncomenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCampo.Clear()
        Call txtCampo_TextChanged(Nothing, Nothing)
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub DgdEncomenda_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdEncomenda.CellDoubleClick
        If DgdEncomenda.Rows.Count <> 0 Then
            If MessageBox.Show("A encomenda de " & _
            DgdEncomenda.CurrentRow.Cells(2).Value & _
                " foi recebida?", "aviso", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) =
                 Windows.Forms.DialogResult.Yes Then
                objEnc.entregar(DgdEncomenda.CurrentRow.Cells(0).Value)
                DgdEncomenda.Rows.RemoveAt(DgdEncomenda.CurrentRow.Index)
            End If
        End If
    End Sub

End Class