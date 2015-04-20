﻿Public Class daoInnlevering
    Public Shared sql As String

    Public Shared Function hentTilbehor(ByVal ordre_nr As Integer) As DataTable
        sql = "SELECT utstyr_leid_ut.ordre_nr, " &
              "utstyrstype.utstyrstype, sykkelutstyr.storrelse, sykkelutstyr.id " &
              "FROM utstyr_leid_ut " &
              "JOIN sykkelutstyr ON utstyr_leid_ut.utstyr_id = sykkelutstyr.id " &
              "JOIN utstyrstype ON sykkelutstyr.utstyrstype = utstyrstype.id " &
              "WHERE utstyr_leid_ut.ordre_nr = " & ordre_nr & ";"

        Return database.dt_query(sql)
    End Function

    Public Shared Function hentLeieAvtaler(ByVal kunde_id As Integer) As DataTable
        sql = "SELECT ordre_nr " &
              "FROM salg_leie " &
              "WHERE salg_leie.person_id_kunde = " & kunde_id & " AND s_l_status = 'Leid ut';"

        Return database.dt_query(sql)
    End Function

    Public Shared Function hentAvtaleInnehold(Optional ByVal id As Integer = Nothing) As DataTable
        Dim payload As DataTable

        If id Then
            sql = "SELECT person.fornavn, person.etternavn, salg_leie.ordre_nr, salg_leie.frist, " &
                  "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
                  "sykkeltype.sykkeltype , person.id " &
                  "FROM salg_leie " &
                  "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
                  "JOIN sykkel ON sykkel.rammenr = sykkel_leid_ut.rammenr " &
                  "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                  "JOIN person ON salg_leie.person_id_kunde = person.id " &
                  "WHERE salg_leie.ordre_nr = " & id
        Else
            sql = "SELECT person.fornavn, person.etternavn, salg_leie.ordre_nr, salg_leie.frist, " &
                  "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
                  "sykkeltype.sykkeltype, person.id " &
                  "FROM salg_leie " &
                  "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
                  "JOIN sykkel ON sykkel.rammenr = sykkel_leid_ut.rammenr " &
                  "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
                  "JOIN person ON salg_leie.person_id_kunde = person.id " &
                  "WHERE s_l_status <> 'Innlevert';"
        End If

        payload = database.dt_query(sql)
        payload.Columns.Add("Navn", Type.GetType("System.String"), "fornavn + ' ' + etternavn")

        Return payload
    End Function

    Public Shared Function hentLeieFrister(ByVal sok As String) As DataTable
        Dim payload As DataTable
        sql = "SELECT person.fornavn, person.etternavn, salg_leie.ordre_nr, salg_leie.frist, " &
              "sykkel.rammenr, sykkel.hjulstr, sykkel.rammestr, " &
              "sykkeltype.sykkeltype, person.id " &
              "FROM salg_leie " &
              "JOIN sykkel_leid_ut ON salg_leie.ordre_nr = sykkel_leid_ut.ordre_nr " &
              "JOIN sykkel ON sykkel.rammenr = sykkel_leid_ut.rammenr " &
              "JOIN sykkeltype ON sykkeltype.id = sykkel.sykkeltype " &
              "JOIN person ON salg_leie.person_id_kunde = person.id " &
              "WHERE DATE(frist) " & sok & " DATE(NOW()) AND s_l_status = 'Leid ut';"
        payload = database.dt_query(sql)
        payload.Columns.Add("Navn", Type.GetType("System.String"), "fornavn + ' ' + etternavn")

        Return payload
    End Function

    Public Shared Function avsluttLeieAvtale(ByVal ordre_nr As Integer, ByVal lokasjon As Integer) As Boolean
        sql = "START TRANSACTION;" &
              "UPDATE salg_leie SET s_l_status = 'Innlevert' " &
              "WHERE ordre_nr = " & ordre_nr & ";" &
              "UPDATE sykkel " &
              "JOIN sykkel_leid_ut ON sykkel.rammenr = sykkel_leid_ut.rammenr AND sykkel_leid_ut.ordre_nr = " & ordre_nr & " " &
              "SET sykkel.s_status = 'Tilgjengelig', sykkel.posisjon = " & lokasjon & ";" &
              "UPDATE sykkelutstyr " &
              "JOIN utstyr_leid_ut ON sykkelutstyr.id = utstyr_leid_ut.utstyr_id AND utstyr_leid_ut.ordre_nr = " & ordre_nr & " " &
              "SET sykkelutstyr.s_u_status = 'Tilgjengelig', sykkelutstyr.posisjon = " & lokasjon & ";" &
              "COMMIT;"

        Return database.query(sql)
    End Function

    Public Shared Function FinnMailOrdreNr(ByVal ordre_nr As Integer) As String
        sql = "SELECT person.mail " &
              "FROM salg_leie " &
              "JOIN person ON salg_leie.person_id_kunde = person.id " &
              "WHERE ordre_nr =" & ordre_nr & ";"

        Dim payload As DataTable = database.dt_query(sql)

        If payload.Rows.Count > 0 Then
            Return payload.Rows(0).Item(0)
        Else
            Return vbNullChar
        End If
    End Function
End Class
