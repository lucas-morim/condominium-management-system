Public Class ClsCargo

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Function localizar_Todos() As DataTable

        sql = "Select codcar, nomcar from tabcargos order by codcar"

        objDtLocal = objbanco.Localizar_dados(Sql)
        Return objDtLocal
    End Function
End Class
