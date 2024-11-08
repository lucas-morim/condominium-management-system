Public Class ClsArea
    Dim m_cod As Integer
    Dim m_nom As String
    Dim m_val As Single
    Dim m_qtd As Integer

    Dim objbanco As New ClsBanco
    Dim sql As String
    Dim objDtLocal As New DataTable


    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return m_nom
        End Get
        Set(ByVal value As String)
            m_nom = value
        End Set
    End Property
    Public Property Valor() As Single
        Get
            Return m_val
        End Get
        Set(ByVal value As Single)
            m_val = value
        End Set
    End Property
    Public Property QuantidadeMaxima() As Integer
        Get
            Return m_qtd
        End Get
        Set(ByVal value As Integer)
            m_qtd = value
        End Set
    End Property

    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "Insert into tabAreas" &
           "(nomarea " &
           ",valarea" &
           ",qtdmax" &
           ") values " &
           "('" & m_nom & "'" &
           ",'" & m_val & "'" &
            ",'" & m_qtd & "'" &
           ")"
            objbanco.Executar_comando(sql)
            sql = "Select max(codarea) from tabAreas"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabAreas set " &
            " nomarea='" & m_nom & "'" &
            ",valarea='" & m_val & "'" &
            ",qtdmax='" & m_qtd & "'" &
            " where codarea=" & m_cod
            objbanco.Executar_comando(sql)
        End If

    End Sub

    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabAreas where codarea=" & campo
        Else
            sql = "Select * from tabAreas where nomarea='" & campo & "'"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não encontrado")
            Return False
        Else
            mostrar_dadosDaClasse()
            Return True
        End If
    End Function

    Public Function localizarParaGrade(campo As String) As DataTable

        sql = "Select codarea, nomarea, valarea, qtdmax from tabareas where nomarea like '" & campo & "%' order by nomarea"

        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal

    End Function

    Public Sub excluir(campo As Integer)
        sql = "Delete from tabareas where codarea=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nom = objDtLocal.Rows(0).Item(1)
        m_val = objDtLocal.Rows(0).Item(2)
        m_qtd = objDtLocal.Rows(0).Item(3)
    End Sub


End Class
