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

        With Me.vognGrid
            .DataSource = kundevogn_sykkler
            .Columns("sykkeltype").Visible = False
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkelnavn").HeaderText = "Type"
            .Columns("hjulstr").HeaderText = "Hjulstr"
            .Columns("rammestr").HeaderText = "Rammestr"
        End With

        With Me.utstyrGrid
            .DataSource = kundevogn_utstyr
            .Columns("id").Visible = False
            .Columns("navn").HeaderText = "Navn"
        End With

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
            If kundevogn_sykkler.Rows.Count > 0 Then
                MsgBox("yey!")
            Else
                MsgBox("Du må legg til sykkler i kundevognen.", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Du må velge en kunde.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub sykkelGrid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles sykkelGrid.MouseDoubleClick
        If Not IsNothing(Me.sykkelGrid.CurrentRow) Then
            kundevogn_sykkler = daoUtleie.leggTilSykkelKundevogn(kundevogn_sykkler,
                                                                 sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("rammenr").Value,
                                                                 sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("sykkelnavn").Value,
                                                                 sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("sykkeltype").Value,
                                                                 sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("hjulstr").Value,
                                                                 sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("rammestr").Value)

            sykkelGrid.DataSource = daoUtleie.settSykkelStatus("Reservert",
                                                               Me.sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("rammenr").Value)
        Else
            MsgBox("Du må velg en gyldig rad i sykkel oversikten.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub FjernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FjernToolStripMenuItem.Click
        If Not IsNothing(Me.vognGrid.CurrentRow) Then
            sykkelGrid.DataSource = daoUtleie.settSykkelStatus("Tilgjengelig",
                                                               Me.vognGrid.Rows(Me.vognGrid.CurrentRow.Index).Cells("rammenr").Value)

            kundevogn_sykkler = daoUtleie.fjernSykkelKundevogn(Me.vognGrid.CurrentRow.Index,
                                                               kundevogn_sykkler)
        Else
            MsgBox("Du må velge en gyldig rad i kundevognen.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub nullStillOrdre()

    End Sub

    Private Function sykkelUtstyr()
    End Function

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
        If Not IsNothing(Me.sykkelGrid.CurrentRow) Then
            kundevogn_sykkler = daoUtleie.leggTilUtstyrKundevogn(kundevogn_utstyr,
                                                                 sykkelGrid.Rows(Me.utstyrGrid.CurrentRow.Index).Cells("id").Value,
                                                                 sykkelGrid.Rows(Me.utstyrGrid.CurrentRow.Index).Cells("navn").Value)

            sykkelGrid.DataSource = daoUtleie.settSykkelStatus("Reservert",
                                                               Me.sykkelGrid.Rows(Me.sykkelGrid.CurrentRow.Index).Cells("rammenr").Value)
        Else
            MsgBox("Du må velg en gyldig rad i sykkel oversikten.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class