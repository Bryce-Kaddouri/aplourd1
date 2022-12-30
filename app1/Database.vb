Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient

Public Class Database
    Private connection As New MySqlConnection()

    Public Sub New()
        ' Modifiez les chaînes de connexion suivantes en fonction de vos paramètres de base de données
        connection.ConnectionString = "server=localhost;user id=root;password='';database=todo_list"
    End Sub

    Public Function OpenConnection() As Boolean
        Try
            connection.Open()
            Return True
        Catch ex As MySqlException
            ' Gérez les erreurs de connexion ici
            Return False
        End Try
    End Function

    Public Function CloseConnection() As Boolean
        Try
            connection.Close()
            Return True
        Catch ex As MySqlException
            ' Gérez les erreurs de fermeture de connexion ici
            Return False
        End Try
    End Function

    Public Function GetConnection() As MySqlConnection
        Return connection
    End Function

    Public Function TryLogin(login As String, mdp As String) As User
        ' Ouvrez la connexion à la base de données
        If OpenConnection() Then
            ' Créez une commande SQL pour sélectionner l'utilisateur avec les informations de connexion entrées
            Dim command As New MySqlCommand("SELECT * FROM user WHERE login = @login AND mdp = SHA2(@mdp, 512);", GetConnection())
            command.Parameters.AddWithValue("@login", login)
            command.Parameters.AddWithValue("@mdp", mdp)

            ' Exécutez la commande et stockez le résultat dans un objet MySqlDataReader
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Si l'utilisateur a été trouvé, retournez True
            If reader.Read() Then
                Dim current_user As User
                current_user = New User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4))
                reader.Close()
                CloseConnection()
                Return current_user
            Else
                reader.Close()
                CloseConnection()
                Return Nothing

            End If
        Else
            Return Nothing
        End If
    End Function

    Public Function getProjetsByUser(Iduser As Integer) As List(Of Projet)
        Dim db As New Database()
        Dim projets As New List(Of Projet)()
        Dim i As Integer = 0

        If OpenConnection() Then
            ' Créez une commande SQL pour sélectionner l'utilisateur avec les informations de connexion entrées
            Dim command As New MySqlCommand("SELECT * FROM projet WHERE idUser = @idUser;", GetConnection())
            command.Parameters.AddWithValue("@iduser", Iduser)

            ' Exécutez la commande et stockez le résultat dans un objet MySqlDataReader
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Si l'utilisateur a été trouvé, retournez True
            While reader.Read()
                projets.Add(New Projet(reader.GetInt32(0), reader.ToString(1), reader.ToString(2), reader.ToString(3), reader.GetInt32(4), reader.ToString(5), reader.ToString(6)))
            End While
            Return projets

        Else
            Return Nothing
        End If
    End Function

End Class
