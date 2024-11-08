Public Class ClsEncomenda

    Dim m_cod As Integer
    Dim m_codMor As Integer
    Dim m_nomMor As String
    Dim m_dt As Date
    Dim m_hr As Date
    Dim m_desc As String
    Dim m_num As Integer
    Dim m_blo As Integer

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
    Public Property CodigoMorador() As Integer
        Get
            Return m_codMor
        End Get
        Set(ByVal value As Integer)
            m_codMor = value
        End Set
    End Property
    Public Property NomeMorador() As String
        Get
            Return m_nomMor
        End Get
        Set(ByVal value As String)
            m_nomMor = value
        End Set
    End Property
    Public Property Data() As Date
        Get
            Return m_dt
        End Get
        Set(ByVal value As Date)
            m_dt = value
        End Set
    End Property
    Public Property Hora() As Date
        Get
            Return m_hr
        End Get
        Set(ByVal value As Date)
            m_hr = value
        End Set
    End Property
    Public Property Descricao() As String
        Get
            Return m_desc
        End Get
        Set(ByVal value As String)
            m_desc = value
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

    Public Property Bloco() As Integer
        Get
            Return m_blo
        End Get
        Set(ByVal value As Integer)
            m_blo = value
        End Set
    End Property



    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then

            sql = "Insert into TabEncomendas " &
           "(nommor" &
           ",codmor" &
           ",datent" &
           ",horent" &
           ",descEnc" &
           ",numapt" &
           ",bloapt" &
           ") values " &
           "('" & m_nomMor & "'" &
           ",'" & m_codMor & "'" &
           ",'" & m_dt & "'" &
           ",'" & m_hr & "'" &
           ",'" & m_desc & "'" &
           ",'" & m_num & "'" &
           ",'" & m_blo & "'" &
           ")"
            objbanco.Executar_comando(sql)
            sql = "Select max(codenc) from TabEncomendas"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)

        Else
            sql = "update tabencomendas set " &
            " nommor='" & m_nomMor & "'" &
           ",codmor='" & m_codMor & "'" &
            ",datent='" & m_dt & "'" &
            ",horent='" & m_hr & "'" &
           ",descEnc='" & m_desc & "'" &
           ",numapt='" & m_num & "'" &
           ",bloapt='" & m_blo & "'" &
           " where codenc=" & m_cod
            objbanco.Executar_comando(sql)
        End If
    End Sub

    Public Function localizarParaGrade(campo As String) As DataTable

        If IsNumeric(campo) Then
            sql = "Select * from tabEncomendas where numapt=" & campo & " and etgenc=false order by codenc"
        Else
            sql = "Select * from tabEncomendas where nommor like '" & campo & "%' and etgenc=false order by codenc"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal

    End Function
    Public Function localizarParaGradeSindico(campo As String) As DataTable

        If IsNumeric(campo) Then
            sql = "Select * from tabEncomendas where numapt=" & campo & "and etgenc=true order by codenc"
        Else
            sql = "Select * from tabEncomendas where nommor like '" & campo & "%' and etgenc=true order by codenc"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal

    End Function


    Public Sub excluir(campo As Integer)
        sql = "Delete from tabEncomendas where codenc=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_codMor = objDtLocal.Rows(0).Item(1)
        m_nomMor = objDtLocal.Rows(0).Item(2)
        m_dt = objDtLocal.Rows(0).Item(3)
        m_hr = objDtLocal.Rows(0).Item(4)
        m_desc = objDtLocal.Rows(0).Item(6)
        m_num = objDtLocal.Rows(0).Item(7)
        m_blo = objDtLocal.Rows(0).Item(8)

    End Sub
    Public Sub entregar(campo As Integer)
        sql = "update tabencomendas set " &
    " etgenc=true" & _
    ",datrec='" & DateTime.Now.ToShortDateString & "'" &
    ",horrec='" & DateTime.Now.ToShortTimeString & "'" &
    " where codenc=" & campo
        objbanco.Executar_comando(sql)
    End Sub

    Public Function localizarPorPeriodo(dtaIni As Date, dtaFim As Date) As DataTable


        Dim objdt As New DataTable

        Dim objda = (New OleDb.OleDbDataAdapter("Con_Encomendas", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

            objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
            objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))

            objda.SelectCommand.Parameters("campo1").Value = dtaIni
            objda.SelectCommand.Parameters("campo2").Value = dtaFim

            objda.Fill(objdt)
            Return objdt

    End Function

End Class
