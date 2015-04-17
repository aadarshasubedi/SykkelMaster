﻿Public Class clsSykkelUtstyr
    Private id, utstyrstype, passer_sykkel_id, pris, innkjopspris, posisjon, virksomhet As Integer
    Private storrelse, status As String
    Private innkjopt As Date

    'oppdater
    Sub New(ByVal id As Integer,
            ByVal virksomhet As Integer,
            ByVal posisjon As Integer,
            ByVal utstyrstype As Integer,
            ByVal pris As Object,
            ByVal innkjopspris As Object,
            ByVal innkjopt As Date,
            ByVal status As String,
            ByVal storrelse As String,
            ByVal passer_sykkel_id As Integer)

        Me.pID = id
        Me.pVirksomhet = virksomhet
        Me.pPosisjon = posisjon
        Me.pUtstyrstype = utstyrstype
        Me.pPris = pris
        Me.pInnkjopspris = innkjopspris
        Me.pInnkjopt = innkjopt
        Me.pStatus = status
        Me.pStorrelse = storrelse
        Me.pPasserSykkelID = passer_sykkel_id
    End Sub

    'fjern
    Sub New(ByVal id As Integer)
        Me.pID = id
    End Sub
    Public Property pID() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property
    Public Property pPosisjon() As Integer
        Get
            Return posisjon
        End Get
        Set(ByVal value As Integer)
            posisjon = value
        End Set
    End Property
    Public Property pVirksomhet() As Integer
        Get
            Return virksomhet
        End Get
        Set(ByVal value As Integer)
            virksomhet = value
        End Set
    End Property
    Public Property pUtstyrstype() As Integer
        Get
            Return utstyrstype
        End Get
        Set(ByVal value As Integer)
            utstyrstype = value
        End Set
    End Property
    Public Property pStorrelse() As Integer
        Get
            Return storrelse
        End Get
        Set(ByVal value As Integer)
            storrelse = value
        End Set
    End Property
    Public Property pStatus() As String
        Get
            Return status
        End Get
        Set(ByVal value As String)
            status = value
        End Set
    End Property
    Public Property pPris() As Object
        Get
            Return pris
        End Get
        Set(ByVal value As Object)
            pris = value
        End Set
    End Property
    Public Property pInnkjopspris() As Object
        Get
            Return innkjopspris
        End Get
        Set(ByVal value As Object)
            innkjopspris = value
        End Set
    End Property
    Public Property pInnkjopt() As Date
        Get
            Return innkjopt
        End Get
        Set(ByVal value As Date)
            innkjopt = value
        End Set
    End Property
    Public Property pPasserSykkelID() As Integer
        Get
            Return passer_sykkel_id
        End Get
        Set(ByVal value As Integer)
            passer_sykkel_id = value
        End Set
    End Property

End Class
