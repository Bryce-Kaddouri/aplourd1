Public Class Projet
    Private _id As Integer
    Private _titre As String
    Private _description As String
    Private _image As String


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


    Public Sub New(id As Integer, titre As String, descritption As String, image As String)
        _id = id
        _titre = titre
        _description = descritption
        _image = image
    End Sub
End Class
