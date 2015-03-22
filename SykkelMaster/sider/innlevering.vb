﻿
Public Class innlevering
    Public telefon As Integer

    Private Sub innlevering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sokLeieAvtale()
    End Sub

    Private Sub txtSokKunde_TextChanged(sender As Object, e As EventArgs) Handles txtSokKunde.TextChanged
        If txtSokKunde.Text = "" Then
            sokLeieAvtale()
        Else
            sokKunde()
        End If
    End Sub

    Private Sub cbxKunde_DataSourceChanged(sender As Object, e As EventArgs) Handles cbxKunde.DataSourceChanged
        sokLeieAvtale(cbxKunde.SelectedValue())
    End Sub

    Private Sub sokKunde()
        Dim payload As New DataTable
        Dim sql As String = "SELECT id, fornavn, etternavn, telefon FROM person WHERE fornavn " &
                            "LIKE '" & txtSokKunde.Text & "%' " &
                            "OR etternavn LIKE '" & txtSokKunde.Text & "%' " &
                            "OR telefon LIKE '" & txtSokKunde.Text & "%' "

        payload = db.query(sql)

        payload.Columns.Add("navn", Type.GetType("System.String"), "fornavn + ' ' + etternavn")

        With cbxKunde
            .DisplayMember = "navn"
            .ValueMember = "telefon"
            .DataSource = payload
        End With
    End Sub

    Private Sub sokLeieAvtale(Optional ByVal id As Integer = Nothing)
        txtTelefon.Text = cbxKunde.SelectedValue
        Dim payload As New DataTable
        Dim sql As String

        If id Then
            sql = "SELECT salg_leie.*, " &
                  "person.id, person.fornavn, person.etternavn, person.telefon, person.adresse, person.post_nr " &
                  "FROM salg_leie, person " &
                  "WHERE salg_leie.person_id_kunde = person.id " &
                  "AND person.telefon = '" & id & "'"
        Else
            sql = "SELECT salg_leie.*, " &
                  "person.id, person.fornavn, person.etternavn, person.telefon, person.adresse, person.post_nr " &
                  "FROM salg_leie, person"

            cbxKunde.DataSource = Nothing
            'cbxLeieAvtaler.DataSource = Nothing
            'cbxLeieAvtaler.Items.Clear()
        End If

        payload = db.query(sql)
        DataGridView1.DataSource = payload 'Ordrene til kunden som er valgt blir lagt ut i DataGrid

        With cbxLeieAvtaler
            .DisplayMember = "ordre_nr"
            .ValueMember = "ordre_nr"
            .DataSource = payload
        End With

        With Me.DataGridView1
            'Vis ikke enkelte kolonner 
            .Columns("person_id_selger").Visible = False
            .Columns("id").Visible = False
            .Columns("person_id_kunde").Visible = False
            .Columns("rabatt_id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("ordre_nr").HeaderText = "Order nummer"
            .Columns("dato").HeaderText = "Dato"
            .Columns("frist").HeaderText = "Frist"
            .Columns("person_id_selger").HeaderText = "Etternavn"
            .Columns("fornavn").HeaderText = "Fornavn"
            .Columns("etternavn").HeaderText = "Etternavn"
            .Columns("telefon").HeaderText = "Telefon"
            .Columns("adresse").HeaderText = "Adresse"
            .Columns("post_nr").HeaderText = "Post nummer"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub
End Class