Public Class Projet
    Implements IEquatable(Of Projet)

    Private _id As Integer
    Private _titre As String
    Private _description As String
    Private _image As String
    Private _idUser As Integer
    Private _dateDebut As String
    Private _dateFin As String




    Private Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Private Property Titre As String
        Get
            Return _titre
        End Get
        Set(value As String)
            _titre = value
        End Set
    End Property

    Private Property Descritption As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Private Property Image As String
        Get
            Return _image
        End Get
        Set(value As String)
            _image = value
        End Set
    End Property

    Private Property IdUser As Integer
        Get
            Return _idUser
        End Get
        Set(value As Integer)
            _idUser = value
        End Set
    End Property
    Private Property DateDebut As String
        Get
            Return _dateDebut
        End Get
        Set(value As String)
            _dateDebut = value
        End Set
    End Property

    Private Property DateFin As String
        Get
            Return _dateFin
        End Get
        Set(value As String)
            _dateFin = value
        End Set
    End Property


    Public Sub New(id As Integer, titre As String, descritption As String, image As String, idUser As Integer, dateDebut As String, dateFin As String)
        _id = id
        _titre = titre
        _description = descritption
        _image = image
        _idUser = idUser
        _dateDebut = dateDebut
        _dateFin = dateFin

    End Sub


End Class
