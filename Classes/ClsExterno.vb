Public Class ClsExterno
    Dim m_cod As Integer
    Dim m_nom As String
    Dim m_rg As String
    Dim m_emp As String
    Dim m_codmor As Integer
    Dim m_servico As Boolean 'Para Serviços
    Dim m_interfonar As Boolean 'INTERFONAR
    Dim m_inicio As Date
    Dim m_fim As Date
    

    Dim objbanco As New ClsBanco
    Dim sql As String
    Dim objDtLocal As New DataTable
    Dim objMor As New ClsMorador


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
    Public Property RG() As String
        Get
            Return m_rg
        End Get
        Set(ByVal value As String)
            m_rg = value
        End Set
    End Property
    Public Property Empresa() As String
        Get
            Return m_emp
        End Get
        Set(ByVal value As String)
            m_emp = value
        End Set
    End Property
    Public Property CodigoMorador() As Integer
        Get
            Return m_codmor
        End Get
        Set(ByVal value As Integer)
            m_codmor = value
        End Set
    End Property
    Public Property Servico() As Boolean
        Get
            Return m_servico
        End Get
        Set(ByVal value As Boolean)
            m_servico = value
        End Set
    End Property
    Public Property Interfone() As Boolean
        Get
            Return m_interfonar
        End Get
        Set(ByVal value As Boolean)
            m_interfonar = value
        End Set
    End Property
    Public Property Inicio() As Date
        Get
            Return m_inicio
        End Get
        Set(ByVal value As Date)
            m_inicio = value
        End Set
    End Property
    Public Property Fim() As Date
        Get
            Return m_fim
        End Get
        Set(ByVal value As Date)
            m_fim = value
        End Set
    End Property


    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "Insert into tabExternos " &
           "(nomext " &
           ",rg " &
           ",empfun " &
            ",codmor " &
            ",servico " &
           ",interfonar " &
           ",inicio " &
           ",fim " &
           ") values " &
           "('" & m_nom & "'" &
           ",'" & m_rg & "'" &
           ",'" & m_emp & "'" &
           ",'" & m_codmor & "'" &
            "," & m_servico &
           "," & m_interfonar &
           ",'" & m_inicio & "'" &
           ",'" & m_fim & "'" &
           ")"
            objbanco.Executar_comando(sql)
            sql = "Select max(codext) from tabexternos"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabExternos set " &
          " nomext='" & m_nom & "'" &
          ",rg='" & m_rg & "'" &
          ",empfun='" & m_emp & "'" &
          ",codmor='" & m_codmor & "'" &
          ",servico=" & m_servico & "" &
          ",interfonar=" & m_interfonar & "" &
          ",inicio='" & m_inicio & "'" &
          ",fim='" & m_fim & "'" &
          "where codext=" & m_cod
            objbanco.Executar_comando(sql)

        End If
    End Sub

    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from TabExternos where codext=" & campo
        Else

            sql = "Select * from TabExternos where nomext like '" & campo & "'"
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

    Public Function localizarParagrade(campo As String) As DataTable

        If IsNumeric(campo) Then
            sql = "Select * from tabexternos where rg like '" & campo & "%' order by codext"
        Else
            sql = "Select * from tabexternos where nomext like '" & campo & "%' order by codext"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal

    End Function
    Public Sub excluir(campo As Integer)
        sql = "Delete from tabExternos where codext=" & campo
        objbanco.Executar_comando(sql)
    End Sub
    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nom = objDtLocal.Rows(0).Item(1)
        m_rg = objDtLocal.Rows(0).Item(2)
        m_emp = objDtLocal.Rows(0).Item(3)
        m_codmor = objDtLocal.Rows(0).Item(4)
        m_servico = objDtLocal.Rows(0).Item(5)
        m_interfonar = objDtLocal.Rows(0).Item(6)
        m_inicio = objDtLocal.Rows(0).Item(7)
        m_fim = objDtLocal.Rows(0).Item(8)

    End Sub

End Class