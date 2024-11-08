Public Class ClsMulta

    Dim m_cod As Integer
    Dim m_mor As String
    Dim m_dt As Date
    Dim m_val As Single
    Dim m_mot As String
    Dim m_apt As Integer
    Dim m_codmor As Integer
    Dim m_blo As Integer
    Dim m_hr As Date

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
    Public Property Morador() As String
        Get
            Return m_mor
        End Get
        Set(ByVal value As String)
            m_mor = value
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
    Public Property Valor() As Single
        Get
            Return m_val
        End Get
        Set(ByVal value As Single)
            m_val = value
        End Set
    End Property
    Public Property Motivo() As String
        Get
            Return m_mot
        End Get
        Set(ByVal value As String)
            m_mot = value
        End Set
    End Property
    Public Property Apartamento() As Integer
        Get
            Return m_apt
        End Get
        Set(ByVal value As Integer)
            m_apt = value
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
    Public Property Bloco() As Integer
        Get
            Return m_blo
        End Get
        Set(ByVal value As Integer)
            m_blo = value
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

    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then

            sql = "Insert into TabMultas " &
           "(mormul" &
           ",dtmul" &
           ",valmul" &
           ",motmul" &
           ",aptmul" &
           ",codmor" &
           ",blomul" &
           ",hrmul" &
           ") values " &
           "('" & m_mor & "'" &
           ",'" & m_dt & "'" &
           ",'" & m_val & "'" &
           ",'" & m_mot & "'" &
           ",'" & m_apt & "'" &
           ",'" & m_codmor & "'" &
           ",'" & m_blo & "'" &
           ",'" & m_hr & "'" &
           ")"

            objbanco.Executar_comando(sql)
            sql = "Select max(codmul) from TabMultas"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)

        Else
            sql = "update TabMultas set " &
            "mormul='" & m_mor & "'" &
           ",dtmul='" & m_dt & "'" &
            ",valmul='" & m_val & "'" &
            ",motmul='" & m_mot & "'" &
            ",aptmul='" & m_apt & "'" &
            ",codmor='" & m_codmor & "'" &
            ",blomul='" & m_blo & "'" &
            ",hrmul='" & m_hr & "'" &
           " where codmul=" & m_cod
            objbanco.Executar_comando(sql)
        End If
    End Sub
    Public Function localizarParaGradeSindico(campo As String) As DataTable

        If IsNumeric(campo) Then
            sql = "Select * from tabmultas where aptmul = " & campo
        Else
            sql = "Select * from TabMultas where mormul like '" & campo & "%' order by mormul"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal

    End Function
    Public Function localizarPorPeriodo(dtaIni As Date, dtaFim As Date) As DataTable


        Dim objdt As New DataTable

        Dim objda = (New OleDb.OleDbDataAdapter("Con_Multas", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))

        objda.SelectCommand.Parameters("campo1").Value = dtaIni
        objda.SelectCommand.Parameters("campo2").Value = dtaFim

        objda.Fill(objdt)
        Return objdt

    End Function
    Public Sub mostrar_dadosDaClasse()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_mor = objDtLocal.Rows(0).Item(1)
        m_dt = objDtLocal.Rows(0).Item(2)
        m_val = objDtLocal.Rows(0).Item(3)
        m_mot = objDtLocal.Rows(0).Item(4)
        m_apt = objDtLocal.Rows(0).Item(5)
        m_codmor = objDtLocal.Rows(0).Item(6)
        m_blo = objDtLocal.Rows(0).Item(7)
        m_hr = objDtLocal.Rows(0).Item(8)
    End Sub

    Public Function localizarUnicaMulta(campo As Integer) As DataTable

        Dim objdt As New DataTable
        Dim objda = (New OleDb.OleDbDataAdapter("Con_Multa_Unica", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))

        objda.SelectCommand.Parameters("campo1").Value = campo
        objda.Fill(objdt)
        Return objdt

    End Function
End Class
