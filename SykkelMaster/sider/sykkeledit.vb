﻿Public Class sykkelEdit
    Private gridIndex As Integer

    Private Sub sykkelEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Laster inn data fra databasen til gridView
        oppdaterGridView()

        Dim payload As New DataTable


        With cbxSted
            .DisplayMember = "navn"
            .DataSource = hoved.lokasjoner
        End With

    End Sub

    Private Sub SykkelGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SykkelGridView.CellClick
        oppdaterTxtbox()
    End Sub

    Private Sub oppdaterGridView(Optional ByVal sok As String = Nothing)
        'Søke på kundens fornavn, etternavn og telefonnr i databasen
        Dim payload As New DataTable
        Dim sql As String
        If Not sok = Nothing Then
            sql = "SELECT * FROM sykkel WHERE rammenr LIKE '%" & sok & "%'"
        Else
            sql = "SELECT sykkel.rammenr, sykkeltype.sykkeltype, status.status, sykkel.hjulstr, sykkel.rammestr, " & _
                "sykkel.avviksmelding, v1.navn posisjon, v2.navn " & _
                "FROM sykkel JOIN sykkeltype ON sykkel.sykkeltype = sykkeltype.id JOIN status ON sykkel.status = status.id " & _
                "JOIN virksomhet v1 ON sykkel.posisjon = v1.id JOIN virksomhet v2 ON sykkel.virksomhet_id = v2.id"
        End If
        payload = db.query(sql)
        SykkelGridView.DataSource = payload

        With Me.SykkelGridView
            'Endre navn for å gi en bedre visuell opplevelse
            .Columns("rammenr").HeaderText = "Rammenr"
            .Columns("sykkeltype").HeaderText = "Sykkeltype"
            .Columns("status").HeaderText = "Status"
            .Columns("hjulstr").HeaderText = "Hjulstørrelse"
            .Columns("rammestr").HeaderText = "Rammestørrelse"
            .Columns("avviksmelding").HeaderText = "Avviksmelding"
            .Columns("posisjon").HeaderText = "Posisjon"
            .Columns("navn").HeaderText = "Tilhører"
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With
    End Sub

    Private Sub oppdaterTxtbox()
        gridIndex = SykkelGridView.CurrentRow.Index()

        'Setter inn datane fra Grid Viewn i Textboksene
        With Me.SykkelGridView
            txtRammenr.Text = .Rows(gridIndex).Cells("rammenr").Value
            txtAvvik.Text = .Rows(gridIndex).Cells("avviksmelding").Value
        End With
        sykkeltype()
    End Sub

    Private Sub sykkeltype()
        Dim payload As New DataTable
        Dim sql As String = "SELECT id, sykkeltype FROM sykkeltype"
        payload = db.query(sql)

        With cbxType
            .DisplayMember = "sykkeltype"
            .ValueMember = "id"
            .DataSource = payload
        End With

        For i As Integer = 0 To payload.Rows.Count - 1
            If payload.Rows(i)(cbxType.DisplayMember).ToString() = SykkelGridView.Rows(gridIndex).Cells("sykkeltype").Value Then
                Me.cbxType.SelectedIndex = i
            End If
        Next
    End Sub

    Private Sub txtSok_TextChanged(sender As Object, e As EventArgs) Handles txtSok.TextChanged
        oppdaterGridView(txtSok.Text)
    End Sub
End Class