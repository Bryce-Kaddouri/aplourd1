Public Class User
    Private _id As Integer
    Private _login As String
    Private _nom As String
    Private _prenom As String
    Private _mdp As String


    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Login As String
        Get
            Return _login
        End Get
        Set(value As String)
            _login = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(value As String)
            _nom = value
        End Set
    End Property

    Public Property Prenom As String
        Get
            Return _prenom
        End Get
        Set(value As String)
            _prenom = value
        End Set
    End Property

    Public Property Mdp As String
        Get
            Return _mdp
        End Get
        Set(value As String)
            _mdp = value
        End Set
    End Property

    Public Sub New(id As Integer, login As String, nom As String, prenom As String, mdp As String)
        _id = id
        _login = login
        _nom = nom
        _prenom = prenom
        _mdp = mdp
    End Sub
End Class
