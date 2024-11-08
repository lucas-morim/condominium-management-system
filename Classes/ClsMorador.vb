Public Class ClsMorador
    Dim m_cod As Integer
    Dim m_apt As Integer
    Dim m_nom As String
    Dim m_tel As String
    Dim m_email As String
    Dim m_teleme As String
    Dim m_rg As String
    Dim m_cpf As String
    Dim m_blo As String


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
    Public Property NumeroApartamento() As String
        Get
            Return m_apt
        End Get
        Set(ByVal value As String)
            m_apt = value
        End Set
    End Property
    Public Property NomeMorador() As String
        Get
            Return m_nom
        End Get
        Set(ByVal value As String)
            m_nom = value
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
    Public Property Email() As String
        Get
            Return m_email
        End Get
        Set(ByVal value As String)
            m_email = value
        End Set
    End Property
    Public Property TelefoneEmergencia() As String
        Get
            Return m_teleme
        End Get
        Set(ByVal value As String)
            m_teleme = value
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
    Public Property CPF() As String
        Get
            Return m_cpf
        End Get
        Set(ByVal value As String)
            m_cpf = value
        End Set
    End Property
    Public Property Bloco() As String
        Get
            Return m_blo
        End Get
        Set(ByVal value As String)
            m_blo = value
        End Set
    End Property
    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "Insert into tabmoradores " &
           "(numapt " &
           ",nommor " &
           ",telmor " &
           ",emamor " &
           ",teleme " &
           ",rg " &
           ",cpf " &
           ",bloapt " &
           ") values " &
           "('" & m_apt & "'" &
           ",'" & m_nom & "'" &
            ",'" & m_tel & "'" &
           ",'" & m_email & "'" &
           ",'" & m_teleme & "'" &
           ",'" & m_rg & "'" &
           ",'" & m_cpf & "'" &
           ",'" & m_blo & "'" &
           ")"
            objbanco.Executar_comando(sql)
            sql = "Select max(codmor) from tabmoradores"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabmoradores set " &
            " numapt='" & m_apt & "'" &
            ",nommor='" & m_nom & "'" &
            ",telmor='" & m_tel & "'" &
            ",emamor='" & m_email & "'" &
            ",teleme='" & m_teleme & "'" &
            ",rg='" & m_rg & "'" &
            ",cpf='" & m_cpf & "'" &
            ",bloapt='" & m_blo & "'" &
            " where codmor=" & m_cod
            objbanco.Executar_comando(sql)
        End If
    End Sub





    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabmoradores where numapt = " & campo
        Else
            sql = "Select * from tabmoradores where nommor = '" & campo & "'"
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
            sql = "Select * from tabmoradores where numapt = " & campo
        Else
            sql = "Select * from tabmoradores where nommor like '" & campo & "%' order by numapt"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal

    End Function
    Public Sub excluir(campo As Integer)
        sql = "Delete from tabmorador where codmor=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_apt = objDtLocal.Rows(0).Item(1)
        m_nom = objDtLocal.Rows(0).Item(2)
        m_tel = objDtLocal.Rows(0).Item(3)
        m_email = objDtLocal.Rows(0).Item(4)
        m_teleme = objDtLocal.Rows(0).Item(5)
        m_rg = objDtLocal.Rows(0).Item(6)
        m_cpf = objDtLocal.Rows(0).Item(7)
        m_blo = objDtLocal.Rows(0).Item(8)

    End Sub
   
End Class
