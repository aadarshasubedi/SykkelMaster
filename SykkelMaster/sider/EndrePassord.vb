﻿Public Class EndrePassord
    Private Sub Bytt_Passord(sender As Object, e As EventArgs) Handles btnBytt_Passord.Click
        'Knappen sjekker først input om tekstfeltene er under 30 karakterer
        'Så kjøres sjekkpassord om det finnes i databasen
        'Deretter kjører prosedyren endrepassord og endrer passordet. 
        If nyttPassordtxt.Text.Length > 30 Or nåværendePassordtxt.Text.Length > 30 Then
            MsgBox("Passord må inneholde mindre enn 30 tegn", MsgBoxStyle.Information)
        Else
            daoEndrePassord.endrePassord(nyttPassordtxt.Text, start.bruker.pEpost)
            MsgBox("Passordet er endret til: " & nyttPassordtxt.Text, MsgBoxStyle.Information)
            nåværendePassordtxt.Text = ""
            nyttPassordtxt.Text = ""
        End If
    End Sub
End Class