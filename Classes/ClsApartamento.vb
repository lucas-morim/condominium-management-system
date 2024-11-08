Public Class ClsApartamento
    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Function localizar_Todos() As DataTable

        sql = "Select numapt, bloapt from tabapartamentos order by numapt"

        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function


    Public Function localizar_blocos() As DataTable

        sql = "Select distinct bloapt from tabapartamentos order by bloapt"

        objDtLocal = objbanco.Localizar_dados(sql)
        Return objDtLocal
    End Function
End Class

