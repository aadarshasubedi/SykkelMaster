﻿Public Class daoSykkelUtstyr
    Public Shared sql As String

    Public Shared Function leggTilUtstyr(ByVal utstyr As clsSykkelUtstyr) As Boolean
        sql = "INSERT INTO sykkelutstyr VALUES(" & utstyr.pID & ", " & utstyr.pUtstyrstype & ", '" &
              utstyr.pStorrelse & "', '" & utstyr.pStatus & "', '" &
              utstyr.pInnkjopspris & "', '" & Format(utstyr.pInnkjopt, "yyyy-MM-dd") & "', " & utstyr.pPosisjon & ", " & utstyr.pVirksomhet & ");"

        Return database.query(sql)
        Return MsgBox(Format(utstyr.pInnkjopt, "yyyy-MM-dd"))
    End Function

    Public Shared Function oppdaterUtstyr(ByVal utstyr As clsSykkelUtstyr) As Boolean
        sql = "UPDATE sykkelutstyr SET id = " & utstyr.pID & ", utstyrstype = " & utstyr.pUtstyrstype &
              ", storrelse = '" & utstyr.pStorrelse & "', s_u_status = '" & utstyr.pStatus &
              "', innkjopspris = " & utstyr.pInnkjopspris & ", innkjopt = '" & Format(utstyr.pInnkjopt, "yyyy-MM-dd") &
              "', posisjon = " & utstyr.pPosisjon & ", virksomhet_id = " & utstyr.pVirksomhet & " WHERE id = " & utstyr.pID & ";"

        Return database.query(sql)
    End Function

    Public Shared Function fjernUtstyr(ByVal utstyr As clsSykkelUtstyr) As Boolean
        Return database.query("DELETE FROM sykkelutstyr WHERE id = '" & utstyr.pID & "';")
    End Function

    Public Shared Function hentUtstyr(Optional ByVal sok As String = Nothing,
                                       Optional ByVal posisjon As String = Nothing,
                                       Optional ByVal status As String = Nothing) As DataTable

        sql = "SELECT sykkelutstyr.id, utstyrstype.utstyrstype, sykkelutstyr.storrelse, s_u_status, " &
              "sykkelutstyr.innkjopspris, sykkelutstyr.innkjopt, v1.navn posisjon, v2.navn " &
              "FROM sykkelutstyr " &
              "JOIN utstyrstype ON sykkelutstyr.utstyrstype = utstyrstype.id " &
              "JOIN virksomhet v1 ON sykkelutstyr.posisjon = v1.id " &
              "JOIN virksomhet v2 ON sykkelutstyr.virksomhet_id = v2.id " &
              "AND utstyrstype.utstyrstype LIKE '%" & sok & "%' AND v1.navn LIKE '%" & posisjon & "%' AND s_u_status LIKE '%" & status & "%';"

        Return database.dt_query(sql)
    End Function
End Class
