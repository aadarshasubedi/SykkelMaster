﻿Public Class lokasjoner
    Private payload As New DataTable

    Private Sub lokasjon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oppdaterGridView()
    End Sub
    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing)
        Oppdaterlokasjon.DataSource = daoLokasjon.hentLokasjoner(sok)

        With Me.Oppdaterlokasjon
            ' Kolonne vises ikke 
            .Columns("id").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("navn").HeaderText = "Lokasjon"
            .Columns("telefon").HeaderText = "Telefonnummer"
            .Columns("mail").HeaderText = "Epost"
            .Columns("adresse").HeaderText = "Adresse"
            .Columns("post_nr").HeaderText = "Postnr"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub
    Private Sub oversiktGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Oppdaterlokasjon.CellClick
        With Me.Oppdaterlokasjon
            txtNavn.Text = .Rows(Me.Oppdaterlokasjon.CurrentRow.Index).Cells("navn").Value
            txtTelefon.Text = .Rows(Me.Oppdaterlokasjon.CurrentRow.Index).Cells("telefon").Value
            txtMail.Text = .Rows(Me.Oppdaterlokasjon.CurrentRow.Index).Cells("mail").Value
            txtAdresse.Text = .Rows(Me.Oppdaterlokasjon.CurrentRow.Index).Cells("adresse").Value
            txtPostnr.Text = .Rows(Me.Oppdaterlokasjon.CurrentRow.Index).Cells("post_nr").Value
        End With
    End Sub


    Private Sub btnAddlocation_Click(sender As Object, e As EventArgs) Handles btnAddLocation.Click
        Try
            Dim lokasjon As New clsLokasjon(txtNavn.Text, txtMail.Text, txtAdresse.Text, txtTelefon.Text, txtPostnr.Text)

            daoLokasjon.leggTilLokasjon(lokasjon)
            MsgBox(lokasjon.pNavn & " lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            oppdaterGridView()
        End Try
    End Sub


    Private Sub txtpostnr_TextChanged(sender As Object, e As EventArgs) Handles txtPostnr.TextChanged
        If IsNumeric(txtPostnr.Text) Then
            txtPoststed.Text = daoDelt.finnPostSted(txtPostnr.Text)
        End If
    End Sub

    Private Sub btnUpdateLocation_Click(sender As Object, e As EventArgs) Handles btnUpdateLocation.Click
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & txtNavn.Text & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim lokasjon As New clsLokasjon(Me.Oppdaterlokasjon.Rows(Me.Oppdaterlokasjon.CurrentRow.Index).Cells("id").Value, txtNavn.Text, txtMail.Text, txtAdresse.Text, txtTelefon.Text, txtPostnr.Text)

                    daoLokasjon.oppdaterLokasjon(lokasjon)
                    MsgBox(txtNavn.Text & " oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
    End Sub

    Private Sub BtnDeleteLocation_Click(sender As Object, e As EventArgs) Handles BtnDeleteLocation.Click
        'Slette en lokasjon i databasen
        Select Case MsgBox("Er du sikker på at du vil fjern " & txtNavn.Text & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim lokasjon As New clsLokasjon(Me.Oppdaterlokasjon.Rows(Me.Oppdaterlokasjon.CurrentRow.Index).Cells("id").Value, txtNavn.Text)

                    daoLokasjon.leggTilLokasjon(lokasjon)
                    MsgBox(txtNavn.Text & " fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    oppdaterGridView()
                End Try
        End Select
    End Sub

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        txtNavn.Text = ""
        txtTelefon.Text = ""
        txtAdresse.Text = ""
        txtMail.Text = ""
        txtPostnr.Text = ""
        txtPoststed.Text = ""
        oppdaterGridView()
    End Sub
End Class