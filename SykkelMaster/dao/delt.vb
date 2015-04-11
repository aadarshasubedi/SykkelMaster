﻿Public Class delt
    Public Shared payload As DataTable
    Public Shared sql As String
    Public Shared Function hentStillinger() As DataTable
        Return database.dt_query("SELECT * FROM stilling")
    End Function

    Public Shared Function hentVirksomhet() As DataTable
        Return database.dt_query("SELECT * FROM virksomhet")
    End Function

    Public Shared Function hentSykkeltype() As DataTable
        Return database.dt_query("SELECT * FROM sykkeltype")
    End Function

    Public Shared Function finnTlfNummer(ByVal kunde_id As Integer) As String
        payload = database.dt_query("SELECT telefon FROM person WHERE id = " & kunde_id & ";")

        If payload.Rows.Count > 0 Then
            Return payload.Rows(0).Item(0) 'returnerer telefon nummer til Kunde
        Else
            Return vbEmpty
        End If
    End Function

    Public Shared Function finnPostSted(ByVal postnr As String) As String
        payload = database.dt_query("SELECT post_sted FROM sted WHERE sted.post_nr = " & postnr & ";")

        If payload.Rows.Count > 0 Then
            Return payload.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function

    Public Shared Function sjekkMailEksisterer(ByVal epost As String)
        Return database.query("SELECT mail from person WHERE mail='" & epost & "';")
    End Function

    Public Shared Function sjekkBrukerEksisterer(ByVal epost As String) As Boolean
        Return database.query("SELECT COUNT(id) FROM person WHERE mail = '" & epost & "';")
    End Function
End Class
