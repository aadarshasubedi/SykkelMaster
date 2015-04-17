﻿Public Class sykkelEdit
    Private sykkel As clsSykkel

    Private Sub sykkelEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn data fra databasen til gridView
        With Me.SykkelGridView
            .DataSource = daoSykkel.hentSykkler
            .Columns("innkjopspris").Visible = False
            .Columns("innkjopt").Visible = False
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkeltype").HeaderText = "Sykkeltype"
            .Columns("s_status").HeaderText = "Status"
            .Columns("pris").HeaderText = "Pris"
            .Columns("hjulstr").HeaderText = "Hjulstørrelse"
            .Columns("rammestr").HeaderText = "Rammestørrelse"
            .Columns("avviksmelding").HeaderText = "Avviksmelding"
            .Columns("posisjon").HeaderText = "Posisjon"
            .Columns("navn").HeaderText = "Tilhører"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With

        'Laster inn data til comboBox'ene
        With cbxTilhorer
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = daoDelt.hentVirksomhet
        End With
        'Gjør at comboBox'en er tom når programmet starter
        cbxTilhorer.SelectedIndex = -1

        With cbxPosisjon
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = daoDelt.hentVirksomhet
        End With
        cbxPosisjon.SelectedIndex = -1

        With cbxLokasjon
            .DisplayMember = "navn"
            .ValueMember = "id"
            .DataSource = daoDelt.hentVirksomhet
        End With
        cbxLokasjon.SelectedIndex = -1

        With cbxType
            .DisplayMember = "sykkeltype"
            .ValueMember = "id"
            .DataSource = daoDelt.hentSykkelType
        End With
        cbxType.SelectedIndex = -1
    End Sub

    Private Sub SykkelGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SykkelGridView.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub oppdaterTxtbox()
        'Setter inn datane fra Grid Viewn i Textboksene
        With Me.SykkelGridView
            cbxTilhorer.Text = daoDelt.finnDGWVerdi(SykkelGridView, "navn")
            cbxPosisjon.Text = daoDelt.finnDGWVerdi(SykkelGridView, "posisjon")
            cbxType.Text = daoDelt.finnDGWVerdi(SykkelGridView, "sykkeltype")
            txtRammenr.Text = daoDelt.finnDGWVerdi(SykkelGridView, "rammenr")
            cbxHjul.Text = daoDelt.finnDGWVerdi(SykkelGridView, "hjulstr")
            cbxRamme.Text = daoDelt.finnDGWVerdi(SykkelGridView, "rammestr")
            cbxStatus.Text = daoDelt.finnDGWVerdi(SykkelGridView, "s_status")
            txtPris.Text = daoDelt.finnDGWVerdi(SykkelGridView, "pris")
            txtInnkjopspris.Text = daoDelt.finnDGWVerdi(SykkelGridView, "innkjopspris")
            dtpInnkjop.Text = daoDelt.finnDGWVerdi(SykkelGridView, "innkjopt")
            txtAvvik.Text = daoDelt.finnDGWVerdi(SykkelGridView, "avviksmelding")
        End With
    End Sub

    Private Sub btnTom_Click(sender As Object, e As EventArgs) Handles btnTom.Click
        'Nulstiller alle textBox'ene og comboBox'ene
        cbxTilhorer.SelectedIndex = -1
        cbxPosisjon.SelectedIndex = -1
        cbxType.SelectedIndex = -1
        cbxHjul.SelectedIndex = -1
        cbxRamme.SelectedIndex = -1
        cbxStatus.SelectedIndex = -1
        txtRammenr.Text = ""
        txtPris.Text = ""
        txtInnkjopspris.Text = ""
        txtAvvik.Text = ""
        dtpInnkjop.Value = Date.Now

        SykkelGridView.DataSource = daoSykkel.hentSykkler
    End Sub

    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        'Legge til en ny sykkel i databasen
        Try
            Dim sykkel As New clsSykkel(txtRammenr.Text,
                                        txtAvvik.Text,
                                        cbxType.SelectedValue,
                                        cbxHjul.Text,
                                        cbxRamme.Text,
                                        cbxStatus.Text,
                                        txtPris.Text,
                                        txtInnkjopspris.Text,
                                        dtpInnkjop.Value,
                                        cbxPosisjon.SelectedValue,
                                        cbxTilhorer.SelectedValue)
            daoSykkel.leggTilSykkel(sykkel)
            MsgBox(sykkel_navn() & " lagt til.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            SykkelGridView.DataSource = daoSykkel.hentSykkler
            oppdaterTxtbox()
        End Try

    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Oppdatere sykkel i databasen
        Select Case MsgBox("Er du sikker på at du vil oppdatere " & sykkel_navn() & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim sykkel As New clsSykkel(txtRammenr.Text,
                                                txtAvvik.Text,
                                                cbxType.SelectedValue,
                                                cbxHjul.Text,
                                                cbxRamme.Text,
                                                cbxStatus.Text,
                                                txtPris.Text,
                                                txtInnkjopspris.Text,
                                                dtpInnkjop.Value,
                                                cbxPosisjon.SelectedValue,
                                                cbxTilhorer.SelectedValue)

                    daoSykkel.oppdaterSykkel(sykkel)
                    MsgBox(sykkel_navn() & " er oppdatert.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    SykkelGridView.DataSource = daoSykkel.hentSykkler
                    oppdaterTxtbox()
                End Try
        End Select
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Slette en sykkel i databasen
        Select Case MsgBox("Er du sikker på at du vil fjerne " & sykkel_navn() & "?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                Try
                    Dim sykkel As New clsSykkel(daoDelt.finnDGWVerdi(SykkelGridView, "rammenr"))

                    daoSykkel.fjernSykkel(sykkel)
                    MsgBox(sykkel_navn() & " er fjernet.", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                Finally
                    SykkelGridView.DataSource = daoSykkel.hentSykkler
                End Try
        End Select
    End Sub

    Private Sub txtSok_TextChanged(sender As Object, e As EventArgs) Handles txtSok.TextChanged
        SykkelGridView.DataSource = daoSykkel.hentSykkler(sok:=txtSok.Text)
    End Sub

    Private Sub cbxLokasjon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLokasjon.SelectedIndexChanged
        SykkelGridView.DataSource = daoSykkel.hentSykkler(posisjon:=cbxLokasjon.Text)
    End Sub

    Private Sub cbxSokStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSokStatus.SelectedIndexChanged
        SykkelGridView.DataSource = daoSykkel.hentSykkler(status:=cbxSokStatus.Text)
    End Sub

    Private Sub btnSykkeltype_Click(sender As Object, e As EventArgs) Handles btnSykkeltype.Click
        sykkeltype.Show()
    End Sub

    Private Function sykkel_navn() As String
        Return txtRammenr.Text & " " & cbxType.Text
    End Function
End Class