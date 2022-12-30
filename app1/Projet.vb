Public Class Projet

    Private _id As Integer
    Private _titre As String
    Private _description As String
    Private _image As String
    Private _idUser As Integer
    Private _dateDebut As String
    Private _dateFin As String




    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Titre As String
        Get
            Return _titre
        End Get
        Set(value As String)
            _titre = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property
    Public Property Descritption As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property Image As String
        Get
            Return _image
        End Get
        Set(value As String)
            _image = value
        End Set
    End Property

    Public Property IdUser As Integer
        Get
            Return _idUser
        End Get
        Set(value As Integer)
            _idUser = value
        End Set
    End Property
    Public Property DateDebut As String
        Get
            Return _dateDebut
        End Get
        Set(value As String)
            _dateDebut = value
        End Set
    End Property

    Public Property DateFin As String
        Get
            Return _dateFin
        End Get
        Set(value As String)
            _dateFin = value
        End Set
    End Property


    Public Sub New(id As Integer, titre As String, descritption As String, image As String, idUser As Integer, dateDebut As String, dateFin As String)
        Me.Id = id
        Me.Titre = titre
        Me.Descritption = descritption
        Me.Image = image
        Me.IdUser = idUser
        Me.DateDebut = dateDebut
        Me.DateFin = dateFin

    End Sub






End Class
