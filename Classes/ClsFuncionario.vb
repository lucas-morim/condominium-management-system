Public Class ClsFuncionario

    Dim m_cod As Integer
    Dim m_nom As String
    Dim m_car As Integer
    Dim m_tel As String
    Dim m_rg As String
    Dim m_end As String
    Dim m_num As Integer
    Dim m_com As String 'Complemento
    Dim m_bai As String
    Dim m_cid As String
    Dim m_est As String
    Dim m_cep As Integer
    Dim m_sal As Single
    Dim m_adm As Date
    Dim m_ati As Boolean

    Dim sql As String
    Dim objbanco As New ClsBanco
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
    Public Property Cargo() As Integer
        Get
            Return m_car
        End Get
        Set(ByVal value As Integer)
            m_car = value
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
    Public Property RG() As String
        Get
            Return m_rg
        End Get
        Set(ByVal value As String)
            m_rg = value
        End Set
    End Property
    Public Property Endereco() As String
        Get
            Return m_end
        End Get
        Set(ByVal value As String)
            m_end = value
        End Set
    End Property
    Public Property Numero() As Integer
        Get
            Return m_num
        End Get
        Set(ByVal value As Integer)
            m_num = value
        End Set
    End Property
    Public Property Complemento() As String
        Get
            Return m_com
        End Get
        Set(ByVal value As String)
            m_com = value
        End Set
    End Property
    Public Property Bairro() As String
        Get
            Return m_bai
        End Get
        Set(ByVal value As String)
            m_bai = value
        End Set
    End Property
    Public Property Cidade() As String
        Get
            Return m_cid
        End Get
        Set(ByVal value As String)
            m_cid = value
        End Set
    End Property
    Public Property Estado() As String
        Get
            Return m_est
        End Get
        Set(ByVal value As String)
            m_est = value
        End Set
    End Property
    Public Property CEP() As Integer
        Get
            Return m_cep
        End Get
        Set(ByVal value As Integer)
            m_cep = value
        End Set
    End Property
    Public Property Salario() As Single
        Get
            Return m_sal
        End Get
        Set(ByVal value As Single)
            m_sal = value
        End Set
    End Property
    Public Property Admissao() As Date
        Get
            Return m_adm
        End Get
        Set(ByVal value As Date)
            m_adm = value
        End Set
    End Property
    Public Property Ativo() As Boolean
        Get
            Return m_ati
        End Get
        Set(ByVal value As Boolean)
            m_ati = value
        End Set
    End Property





    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "Insert into tabfuncionarios " &
           "(nomfun " &
           ",carfun " &
           ",telfun " &
           ",rg " &
           ",endfun " &
           ",numfun " &
           ",comfun " &
           ",baifun " &
           ",cidfun " &
           ",estfun " &
           ",cepfun " &
           ",salfun " &
           ",admfun " &
           ",atifun " &
           ") values " &
           "('" & m_nom & "'" &
           ",'" & m_car & "'" &
           ",'" & m_tel & "'" &
           ",'" & m_rg & "'" &
           ",'" & m_end & "'" &
           ",'" & m_num & "'" &
           ",'" & m_com & "'" &
           ",'" & m_bai & "'" &
           ",'" & m_cid & "'" &
           ",'" & m_est & "'" &
           ",'" & m_cep & "'" &
           ",'" & m_sal & "'" &
           ",'" & m_adm & "'" &
           "," & m_ati & "" &
           ")"
            objbanco.Executar_comando(sql)

            sql = "Select max(codfun) from tabfuncionarios"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabfuncionarios set " &
            " nomfun='" & m_nom & "'" &
            ",carfun='" & m_car & "'" &
            ",telfun='" & m_tel & "'" &
            ",rg='" & m_rg & "'" &
            ",endfun='" & m_end & "'" &
            ",numfun='" & m_num & "'" &
            ",comfun='" & m_com & "'" &
            ",baifun='" & m_bai & "'" &
            ",cidfun='" & m_cid & "'" &
            ",estfun='" & m_est & "'" &
            ",cepfun='" & m_cep & "'" &
            ",salfun='" & m_sal & "'" &
            ",admfun='" & m_adm & "'" &
            ",atifun=" & m_ati & "" &
            "where codfun=" & m_cod
            objbanco.Executar_comando(sql)
        End If
    End Sub

Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabfuncionarios where codfun=" & campo
        Else
            sql = "Select * from tabfuncionarios where nomfun ='" & campo & "'"
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
            sql = "Select codfun, nomfun, carfun, telfun, rg, endfun, cepfun, salfun, admfun from tabfuncionarios where rg like '" & campo & "%' order by nomfun"
        Else
            sql = "Select codfun, nomfun, carfun, telfun, rg, endfun, cepfun, salfun, admfun from tabfuncionarios where nomfun like '" & campo & "%' order by nomfun"

        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal

    End Function
    Public Function localizar_Todos() As DataTable

        sql = "Select codfun, carfun from tabfuncionarios where atifun=true order by carFun"

        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Sub excluir(campo As Integer)
        sql = "Delete from tabfuncionarios where codfun=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_rg = objDtLocal.Rows(0).Item(1)
        m_nom = objDtLocal.Rows(0).Item(2)
        m_car = objDtLocal.Rows(0).Item(3)
        m_tel = objDtLocal.Rows(0).Item(4)
        m_end = objDtLocal.Rows(0).Item(5)
        m_num = objDtLocal.Rows(0).Item(6)
        m_com = objDtLocal.Rows(0).Item(7)
        m_bai = objDtLocal.Rows(0).Item(8)
        m_cid = objDtLocal.Rows(0).Item(9)
        m_est = objDtLocal.Rows(0).Item(10)
        m_cep = objDtLocal.Rows(0).Item(11)
        m_sal = objDtLocal.Rows(0).Item(12)
        m_adm = objDtLocal.Rows(0).Item(13)
        m_ati = objDtLocal.Rows(0).Item(14)
    End Sub


End Class
