﻿Public Class utleie
    Private payload As DataTable
    Private kundevogn_sykkler As DataTable = daoUtleie.lagSykklerDataTable
    Private kundevogn_utstyr As DataTable = daoUtleie.lagUtstyrDataTable

    Private Sub utleie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cbxRabattAvtale
            .DisplayMember = "type_rabatt"
            .ValueMember = "id"
            .DataSource = daoUtleie.hentRabattAvtaler
        End With

        With Me.sykkelGrid
            .DataSource = daoUtleie.hentSykkler
            .Columns("sykkeltype").Visible = False
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkelnavn").HeaderText = "Type"
            .Columns("hjulstr").HeaderText = "Hjulstr"
            .Columns("rammestr").HeaderText = "Rammestr"
        End With

        With Me.vognSykkel
            .DataSource = kundevogn_sykkler
            .Columns("sykkeltype").Visible = False
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkelnavn").HeaderText = "Type"
            .Columns("hjulstr").HeaderText = "Hjulstr"
            .Columns("rammestr").HeaderText = "Rammestr"
        End With

        With Me.utstyrGrid
            .DataSource = daoUtleie.hentUtstyr
            .Columns("id").Visible = False
            .Columns("navn").HeaderText = "Navn"
            .Columns("Pris").HeaderText = "Pris"
        End With

        With Me.vognStyr
            .DataSource = kundevogn_utstyr
            .Columns("id").Visible = False
            .Columns("navn").HeaderText = "Navn"
            .Columns("pris").HeaderText = "Pris"
        End With
    End Sub

    Private Sub utleie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        tomKundevogn()
    End Sub


    Private Sub btnKunde_Click(sender As Object, e As EventArgs) Handles btnKunde.Click
        person.Show()
    End Sub
    Private Sub btnRedigerKunde_Click(sender As Object, e As EventArgs) Handles btnRedigerKunde.Click
        person.Show()
        person.oppdaterGridView(id:=cbxNavn.SelectedValue)
    End Sub

    Private Sub txtSokKunde_TextChanged(sender As Object, e As EventArgs) Handles txtSokKunde.TextChanged
        payload = daoDelt.finnKunde(txtSokKunde.Text)

        payload.Columns.Add("kunde_navn", Type.GetType("System.String"), "fornavn + ' ' + etternavn")

        If payload.Rows.Count > 0 Then
            With cbxNavn
                .DisplayMember = "kunde_navn"
                .ValueMember = "id"
                .DataSource = payload
            End With

            txtTelefon.Text = daoDelt.finnTlfNummer(cbxNavn.SelectedValue)
        Else
            Me.cbxNavn.DataSource = Nothing
        End If
    End Sub
    Private Sub rbTime_CheckedChanged(sender As Object, e As EventArgs) Handles rbTime.CheckedChanged
        fraTid.Format = DateTimePickerFormat.Time
        fraTid.ShowUpDown = True
        tilTid.Format = DateTimePickerFormat.Time
        tilTid.ShowUpDown = True
    End Sub
    Private Sub rbDag_CheckedChanged(sender As Object, e As EventArgs) Handles rbDag.CheckedChanged
        fraTid.Format = DateTimePickerFormat.Short
        fraTid.ShowUpDown = False
        tilTid.Format = DateTimePickerFormat.Short
        tilTid.ShowUpDown = False
    End Sub

    Private Sub btnOprettAvtale_Click(sender As Object, e As EventArgs) Handles btnOprettAvtale.Click
        If cbxNavn.SelectedValue Then
            If kundevogn_sykkler.Rows.Count > 0 Or kundevogn_utstyr.Rows.Count > 0 Then
                MsgBox("yey!")
            Else
                MsgBox("Du må legg til produkter i kundevognen.", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Du må velge en kunde.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub sykkelGrid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles sykkelGrid.MouseDoubleClick
        If Not IsNothing(Me.sykkelGrid.CurrentRow) Then
            kundevogn_sykkler = daoUtleie.leggTilSykkelKundevogn(kundevogn_sykkler,
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "rammenr"),
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "sykkelnavn"),
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "sykkeltype"),
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "hjulstr"),
                                                                 daoDelt.finnDGWVerdi(sykkelGrid, "rammestr"))

            sykkelGrid.DataSource = daoUtleie.settSykkelStatus("Reservert",
                                                               daoDelt.finnDGWVerdi(sykkelGrid, "rammenr"))
        Else
            MsgBox("Du må velg en gyldig rad i sykkel oversikten.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub FjernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FjernToolStripMenuSykkel.Click
        If Not IsNothing(Me.vognSykkel.CurrentRow) Then
            sykkelGrid.DataSource = daoUtleie.settSykkelStatus("Tilgjengelig",
                                                               CStr(daoDelt.finnDGWVerdi(vognSykkel, "rammenr")))

            kundevogn_sykkler = daoUtleie.fjernFraKundevogn(Me.vognSykkel.CurrentRow.Index,
                                                               kundevogn_sykkler)
        Else
            MsgBox("Du må velge en gyldig rad i kundevognen.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Function helgLeie(ByVal fra As Date, ByVal til As Date)
        If dagErHelg(fra) And dagErHelg(til) Then
            If DateDiff(DateInterval.Day, fra, til) = 1 Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Function dagErHelg(ByVal dag As Date)
        Select Case dag.DayOfWeek
            Case DayOfWeek.Saturday
                Return True
            Case DayOfWeek.Sunday
                Return True
            Case Else
                Return False
        End Select
    End Function

    Private Sub utstyrGrid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles utstyrGrid.MouseDoubleClick
        If Not IsNothing(Me.utstyrGrid.CurrentRow) Then
            kundevogn_utstyr = daoUtleie.leggTilUtstyrKundevogn(kundevogn_utstyr,
                                                                daoDelt.finnDGWVerdi(utstyrGrid, "id"),
                                                                daoDelt.finnDGWVerdi(utstyrGrid, "navn"),
                                                                daoDelt.finnDGWVerdi(utstyrGrid, "pris"))

            utstyrGrid.DataSource = daoUtleie.settUtstyrStatus("Reservert",
                                                               daoDelt.finnDGWVerdi(utstyrGrid, "id"))

        Else
            MsgBox("Du må velg en gyldig rad i utstyr oversikten.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub FjernToolStripMenuUtstyr_Click(sender As Object, e As EventArgs) Handles FjernToolStripMenuUtstyr.Click
        If Not IsNothing(Me.vognStyr.CurrentRow) Then
            utstyrGrid.DataSource = daoUtleie.settUtstyrStatus("Tilgjengelig",
                                                             daoDelt.finnDGWVerdi(vognStyr, "id"))

            kundevogn_utstyr = daoUtleie.fjernFraKundevogn(Me.vognStyr.CurrentRow.Index,
                                                           kundevogn_utstyr)
        Else
            MsgBox("Du må velge en gyldig rad i kundevognen.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnTomKundevogn_Click(sender As Object, e As EventArgs) Handles btnTomKundevogn.Click
        tomKundevogn()
    End Sub

    Private Sub tomKundevogn()
        For Each sykkel As DataRow In kundevogn_sykkler.Rows
            daoUtleie.settSykkelStatus("Tilgjengelig", sykkel.Item("rammenr"))
        Next sykkel

        For Each utstyr As DataRow In kundevogn_utstyr.Rows
            daoUtleie.settUtstyrStatus("Tilgjengelig", utstyr.Item("id"))
        Next utstyr

        kundevogn_sykkler = daoUtleie.lagSykklerDataTable
        kundevogn_utstyr = daoUtleie.lagUtstyrDataTable

        vognSykkel.DataSource = kundevogn_sykkler
        vognStyr.DataSource = kundevogn_utstyr

        sykkelGrid.DataSource = daoUtleie.hentSykkler
        utstyrGrid.DataSource = daoUtleie.hentUtstyr
    End Sub
End Class