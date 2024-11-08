Public Class ClsEntrada
    Dim m_cod As Integer
    Dim m_dts As Date 'Data saida 
    Dim m_dte As Date 'Data entrada 
    Dim m_rg As String
    Dim m_hre As Date 'Hora Entrada
    Dim m_hrs As Date 'Hora Saida


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
    Public Property DataSaida() As Date
        Get
            Return m_dts
        End Get
        Set(ByVal value As Date)
            m_dts = value
        End Set
    End Property
    Public Property DataEntrada() As Date
        Get
            Return m_dte
        End Get
        Set(ByVal value As Date)
            m_dte = value
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
    Public Property HoraEntrada() As Date
        Get
            Return m_hre
        End Get
        Set(ByVal value As Date)
            m_hre = value
        End Set
    End Property
    Public Property HoraSaida() As Date
        Get
            Return m_hrs
        End Get
        Set(ByVal value As Date)
            m_hrs = value
        End Set
    End Property


























End Class
