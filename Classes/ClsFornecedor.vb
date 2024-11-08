Public Class ClsFornecedor
    Dim m_cod As Integer
    Dim m_nom As String 'Nome empresa
    Dim m_des As String
    Dim m_cnpj As String
    Dim m_tel As String
    Dim m_con As String 'Nome do Contato da empresa 

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
    Public Property Descricao() As String
        Get
            Return m_des
        End Get
        Set(ByVal value As String)
            m_des = value
        End Set
    End Property
    Public Property CNPJ() As String
        Get
            Return m_cnpj
        End Get
        Set(ByVal value As String)
            m_cnpj = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return m_tel
        End Get
        Set(ByVal value As String)
            m_tel = value
        End Set
    End Property
    Public Property NomeDoContato() As String
        Get
            Return m_con
        End Get
        Set(ByVal value As String)
            m_con = value
        End Set
    End Property


    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "Insert into tabFornecedores " &
           "(nomfor " &
           ",desfor " &
           ",CNPJ " &
            ",telfor " &
            ",nomcon " &
           ") values " &
           "('" & m_nom & "'" &
           ",'" & m_des & "'" &
           ",'" & m_cnpj & "'" &
           ",'" & m_tel & "'" &
           ",'" & m_con & "'" &
           ")"
            objbanco.Executar_comando(sql)
            sql = "Select max(codfor) from tabFornecedores"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update TabFornecedores set " &
           " nomfor='" & m_nom & "'" &
           ",desfor='" & m_des & "'" &
           ",CNPJ='" & m_cnpj & "'" &
           ",telfor='" & m_tel & "'" &
           ",nomcon='" & m_con & "'" &
           " where codfor=" & m_cod
            objbanco.Executar_comando(sql)

        End If
    End Sub

    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabFornecedores where codfor=" & campo
        Else
            sql = "Select * from tabFornecedores where nomfor='" & campo & "'"
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
        If IsNumeric(campo) Then
            sql = "Select * from tabfornecedores where cnpj like '" & campo & "%' order by nomfor"
        Else
            sql = "Select * from tabfornecedores where nomfor like '" & campo & "%' order by nomfor"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function

    Public Sub excluir(campo As Integer)
        sql = "Delete from tabforcenedores where codfor=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nom = objDtLocal.Rows(0).Item(1)
        m_des = objDtLocal.Rows(0).Item(2)
        m_cnpj = objDtLocal.Rows(0).Item(3)
        m_tel = objDtLocal.Rows(0).Item(4)
        m_con = objDtLocal.Rows(0).Item(5)
    End Sub

End Class


