﻿Public Class utleie
    Private payload As DataTable

    Private Sub utleie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        payload = database.dt_query("SELECT * FROM sykkeltype")
        With cbxSykkeltype
            .DisplayMember = "sykkeltype"
            .ValueMember = "id"
            .DataSource = payload
        End With
        cbxSykkeltype.SelectedIndex = -1

        ToolTip1.SetToolTip(Me.Label5, "Her kan du søke på navn eller telefonnr.")
    End Sub


    Private Sub btnKunde_Click(sender As Object, e As EventArgs) Handles btnKunde.Click
        kunder.Show()
    End Sub
    Private Sub btnRedigerKunde_Click(sender As Object, e As EventArgs) Handles btnRedigerKunde.Click
        kunder.Show()
        kunder.oppdaterGridView(id:=cbxNavn.SelectedValue)
    End Sub

    Private Sub txtSok_TextChanged(sender As Object, e As EventArgs) Handles txtSok.TextChanged
        sokKunde(txtSok.Text)
    End Sub

    Private Sub sokKunde(ByVal sok As String)
        Dim sql As String = "SELECT id, fornavn, etternavn, telefon FROM person " &
                            "WHERE fornavn LIKE '" & sok & "%' " &
                            "OR etternavn LIKE '" & sok & "%' " &
                            "OR telefon LIKE '" & sok & "%' "

        payload = database.dt_query(sql)

        payload.Columns.Add("kunde_navn", Type.GetType("System.String"), "fornavn + ' ' + etternavn")

        If payload.Rows.Count >= 1 Then
            With cbxNavn
                .DisplayMember = "kunde_navn"
                .ValueMember = "id"
                .DataSource = payload
            End With

            txtTelefon.Text = delt.finnTlfNummer(cbxNavn.SelectedValue)
        Else
            Me.cbxNavn.DataSource = Nothing
        End If
    End Sub

    Private Sub cbxAvtale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAvtale.SelectedIndexChanged
        Dim sql As String = "SELECT count(*) FROM salg_leie s JOIN person p ON s.person_id_kunde = p.id WHERE id = " _
                            & CInt(cbxNavn.SelectedValue)

    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
       
    End Sub
End Class