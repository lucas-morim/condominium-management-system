Public Class ClsReserva

    Dim m_cod As Integer
    Dim m_codarea As Integer
    Dim m_codmor As Integer
    Dim m_qtd As Integer 'Quantidade de participantes do evento 
    Dim m_max As Integer
    Dim m_nom As String
    Dim m_val As Single
    Dim m_dat As Date
    Dim m_hor As String
    Dim m_con As String
    Dim m_nomearea As String




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
    Public Property Area() As Integer
        Get
            Return m_codarea
        End Get
        Set(ByVal value As Integer)
            m_codarea = value
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

    Public Property QuantidadeParticipantes() As Integer
        Get
            Return m_qtd
        End Get
        Set(ByVal value As Integer)
            m_qtd = value
        End Set
    End Property
    Public Property QuantidadeMaxima() As Integer
        Get
            Return m_max
        End Get
        Set(ByVal value As Integer)
            m_max = value
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
    Public Property NomeArea() As String
        Get
            Return m_nomearea
        End Get
        Set(ByVal value As String)
            m_nomearea = value
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
    Public Property Data() As Date
        Get
            Return m_dat
        End Get
        Set(ByVal value As Date)
            m_dat = value
        End Set
    End Property
    Public Property Horario() As String
        Get
            Return m_hor
        End Get
        Set(ByVal value As String)
            m_hor = value
        End Set
    End Property
    Public Property Convidados() As String
        Get
            Return m_con
        End Get
        Set(ByVal value As String)
            m_con = value
        End Set
    End Property


    Public Sub gravar_dados(novo As Boolean)
        If novo = True Then
            sql = "Insert into TabReservas " &
               "(codarea " &
               ",codmor " &
               ",qtdpar " &
               ",qtdMax " &
               ",nomres " &
               ",valres " &
               ",datres " &
                ",horres " &
                 ",conres " &
                 ",nomarea " &
                ") values " &
               "('" & m_codarea & "'" &
               ",'" & m_codmor & "'" &
               ",'" & m_qtd & "'" &
                 ",'" & m_max & "'" &
                ",'" & m_nom & "'" &
                ",'" & m_val & "'" &
                ",'" & m_dat & "'" &
                ",'" & m_hor & "'" &
                 ",'" & m_con & "'" &
                ",'" & m_nomearea & "'" &
                ")"
            objbanco.Executar_comando(sql)
            sql = "Select max(codres) from tabReservas"
            m_cod = objbanco.Buscar_ultimoRegistro(sql)
        Else
            sql = "update tabReservas set " &
                " codarea='" & m_codarea & "'" &
                ",codmor='" & m_codmor & "'" &
                ",QtdPar='" & m_qtd & "'" &
                ",qtdMax='" & m_max & "'" &
                 ",nomres='" & m_nom & "'" &
                 ",valres='" & m_val & "'" &
                 ",datres='" & m_dat & "'" &
                 ",horres='" & m_hor & "'" &
                  ",conres='" & m_con & "'" &
                ",nomeare='" & m_nomearea & "'" &
                " where codres=" & m_cod
            objbanco.Executar_comando(sql)
        End If
    End Sub



    Public Function localizarParaGrade(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select codres,nomres,codmor,qtdpar,datres,horres,conres from tabReservas where codres =" & campo & " order by datres"
        Else
            sql = "Select codres,nomres,codmor,qtdpar,datres,horres,conres from tabReservas where nomres like '" & campo & "%' order by datres"
        End If
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
    Public Function localizarParaSindico() As DataTable
        sql = "Select codres,nomres,codmor,valres,qtdpar,datres,horres,conres from tabReservas order by datres"
        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function


    Public Sub excluir(campo As Integer)
        sql = "Delete from tabReservas where codres=" & campo
        objbanco.Executar_comando(sql)
    End Sub
    Public Function localizarPorPeriodo(dtaIni As Date, dtaFim As Date) As DataTable
        Dim objdt As New DataTable
        Try



            Dim objda = (New OleDb.OleDbDataAdapter("Con_Reservas", objbanco.objcon))
            objda.SelectCommand.CommandType = CommandType.StoredProcedure

            objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
            objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))

            objda.SelectCommand.Parameters("campo1").Value = dtaIni
            objda.SelectCommand.Parameters("campo2").Value = dtaFim

            objda.Fill(objdt)
            Return objdt
        Catch ex As Exception
            Return objdt
        End Try


    End Function
    Public Function localizarReservaTotalPorPeriodo(dtaIni As Date, dtaFim As Date) As Single

        'Dim objds As New DataSet
        Dim objdt As New DataTable

        Dim objda = (New OleDb.OleDbDataAdapter("Con_ReservasTot", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))

        objda.SelectCommand.Parameters("campo1").Value = dtaIni
        objda.SelectCommand.Parameters("campo2").Value = dtaFim

        'objds.Tables.Clear()
        'objda.Fill(objds)
        objda.Fill(objdt)


        'Return objds.Tables(0)
        Return objdt.Rows(0).Item(0)

        'funciona os itens em verde com ds ou os itens ativos com dt

    End Function
    Public Function localizarParaGradeOrdenado(dtaIni As Date) As DataTable
        Dim objdt As New DataTable

        Dim objda = (New OleDb.OleDbDataAdapter("Con_Reservas_Ordenada", objbanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure

        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))


        objda.SelectCommand.Parameters("campo1").Value = dtaIni


        objda.Fill(objdt)
        Return objdt


        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
End Class


