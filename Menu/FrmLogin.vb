Public Class FrmLogin
    Dim conexao As New OleDb.OleDbConnection
    Dim verificachaveSindico, verificachaveMorador, verificachavePorteiro As New OleDb.OleDbCommand()
    Dim read As OleDb.OleDbDataReader
    Dim objControle As New ClsControle

    Private Sub btnPort_Click_1(sender As Object, e As EventArgs)
        FrmMenuPortaria.Show()
        Me.Hide()
    End Sub

    Private Sub btnSind_Click_1(sender As Object, e As EventArgs)
        FrmMenuSindico.Show()
        Me.Hide()
    End Sub

    Private Sub btnMor_Click_1(sender As Object, e As EventArgs)
        FrmMenuMorador.Show()
        Me.Hide()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexao.ConnectionString = "Provider=microsoft.ace.oledb.12.0;data source=BancoCondominio.accdb"


        verificachaveSindico.Connection = conexao

        verificachaveSindico.CommandType = CommandType.Text

        verificachaveSindico.CommandText = "Select * From tabLoginSindico Where usuario=? and senha=?"


        verificachaveMorador.Connection = conexao

        verificachaveMorador.CommandType = CommandType.Text

        verificachaveMorador.CommandText = "Select * From tabLoginMorador Where usuario=? and senha=?"


        verificachavePorteiro.Connection = conexao

        verificachavePorteiro.CommandType = CommandType.Text

        verificachavePorteiro.CommandText = "Select * From tabLoginPorteiro Where usuario=? and senha=?"

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If objControle.Testar_Vazio(Me) = True Then
            MessageBox.Show("Favor preencher todos os campos obrigatórios")
        End If




        Try

            If cbxCargo.SelectedIndex = 0 Then
                verificachaveSindico.Parameters.Add("usuario", Data.OleDb.OleDbType.Variant)

                verificachaveSindico.Parameters.Add("senha", Data.OleDb.OleDbType.Variant)


                verificachaveSindico.Parameters("usuario").Value = txtUsu.Text

                verificachaveSindico.Parameters("senha").Value = txtSenha.Text




                'Abre conexao com banco de dados

                conexao.Open()


                ' Le a informação do banco de dados

                read = verificachaveSindico.ExecuteReader


                verificaLogin()

                ' fecha a conexao com o banco de dados

                conexao.Close()

            ElseIf cbxCargo.SelectedIndex = 1 Then
                verificachaveMorador.Parameters.Add("usuario", Data.OleDb.OleDbType.Variant)

                verificachaveMorador.Parameters.Add("senha", Data.OleDb.OleDbType.Variant)



                verificachaveMorador.Parameters("usuario").Value = txtUsu.Text

                verificachaveMorador.Parameters("senha").Value = txtSenha.Text



                'Abre conexao com banco de dados

                conexao.Open()


                ' Le a informação do banco de dados

                read = verificachaveMorador.ExecuteReader


                verificaLogin()

                ' fecha a conexao com o banco de dados

                conexao.Close()

            ElseIf cbxCargo.SelectedIndex = 2 Then
                verificachavePorteiro.Parameters.Add("usuario", Data.OleDb.OleDbType.Variant)

                verificachavePorteiro.Parameters.Add("senha", Data.OleDb.OleDbType.Variant)



                verificachavePorteiro.Parameters("usuario").Value = txtUsu.Text

                verificachavePorteiro.Parameters("senha").Value = txtSenha.Text



                'Abre conexao com banco de dados

                conexao.Open()


                ' Le a informação do banco de dados

                read = verificachavePorteiro.ExecuteReader


                verificaLogin()

                ' fecha a conexao com o banco de dados

                conexao.Close()


            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub verificaLogin()




        With read

            If .Read Then

                MessageBox.Show("Acesso permitido! Bem Vindo """ & txtUsu.Text & """", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If cbxCargo.SelectedIndex = 0 Then

                    Me.Hide()
                    FrmMenuSindico.Show()
                    read.Close()

                ElseIf cbxCargo.SelectedIndex = 1 Then
                    Me.Hide()
                    FrmMenuMorador.Show()
                    read.Close()
                ElseIf cbxCargo.SelectedIndex = 2 Then
                    Me.Hide()
                    FrmMenuPortaria.Show()
                    read.Close()
                End If
            Else
                MessageBox.Show("Um ou mais itens incorretos! Preencha corretamente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                read.Close()
            End If

        End With
    End Sub

    Private Sub cbxCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCargo.KeyPress
        e.Handled = True
    End Sub
End Class