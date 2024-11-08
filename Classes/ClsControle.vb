Public Class ClsControle

    Public Function Testar_Vazio(ByVal tela As Control) As Boolean
        Dim controle As Control
        For Each controle In tela.Controls
            If TypeOf controle Is TextBox Or
                TypeOf controle Is ComboBox Then
                If controle.Text = "" And controle.Tag <> "x" Then
                    controle.Focus()
                    Return True
                End If
            End If
        Next
    End Function

    Public Sub Limpar_tela(ByVal tela As Control)
        Dim controle As Object
        For Each controle In tela.Controls
            If TypeOf controle Is TextBox Or
                TypeOf controle Is MaskedTextBox Or
                TypeOf controle Is ComboBox Then
                controle.Text = ""
            ElseIf TypeOf controle Is Label And controle.Tag = "c" Then
                controle.Text = ""
                '  ElseIf TypeOf controle Is DataGridView Then
                '    controle.rows.clear()
            ElseIf TypeOf controle Is CheckBox Then
                controle.checked = False
            End If
        Next
    End Sub

    Public Sub Habilitar_tela(ByVal tela As Control, ByVal tipo As Boolean)
        Dim controle As Control
        For Each controle In tela.Controls
            If controle.Tag = "h" Then
                If TypeOf controle Is TextBox Or
                    TypeOf controle Is MaskedTextBox Or
                    TypeOf controle Is ComboBox Or
                    TypeOf controle Is DateTimePicker Or
                    TypeOf controle Is DataGridView Or
                    TypeOf controle Is CheckBox Then
                    controle.Enabled = tipo
                End If

            End If

        Next
    End Sub

    Public Sub Habilitar_botoes(ByVal tela As Control, ByVal tipo As Boolean)
        Dim controle As Control
        For Each controle In tela.Controls
            If TypeOf controle Is Button Then
                controle.Enabled = tipo
                If controle.Name.ToUpper = "BTNCAD" Then
                    controle.Enabled = Not tipo
                ElseIf controle.Name.ToUpper = "BTNSAIR" Or
                    controle.Name.ToUpper = "BTNCAN" Or
                    controle.Name.ToUpper = "BTNBUSCMOR" Or
                    controle.Name.ToUpper = "BTNBUSCAREA" Or
                    controle.Name.ToUpper = "BTNBUSC" Then
                    controle.Enabled = True
                End If
            End If
        Next
    End Sub

    Public Function SoNumeros(caracter As String) As Boolean
        If Asc(caracter) = 8 Or Asc(caracter) = 13 Then
            Return False 'Libera teclado
        Else
            If Asc(caracter) < 48 Or Asc(caracter) > 57 Then
                Return True ' Trava teclado
            End If
        End If
    End Function

    Public Function SoNumerosEVirgula(caracter As String) As Boolean
        If Asc(caracter) = 8 Or Asc(caracter) = 13 Or Asc(caracter) = 44 Then
            Return False 'Libera teclado
        Else
            If Asc(caracter) < 48 Or Asc(caracter) > 57 Then
                Return True ' Trava teclado
            End If
        End If
    End Function
End Class
