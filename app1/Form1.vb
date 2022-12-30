Imports System.Web
Imports System.Windows

Public Class Form1
    Dim user As User = Nothing
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim db As New Database()
        Dim projects As Collection

        user = db.TryLogin(txt_login.Text, txt_mdp.Text)
        ' projects = db.getProjetsByUser(user.Id)
        If user IsNot Nothing Then
            MessageBox.Show("Connexion réussie!" & user.Id)
            Me.Hide()
            LoadFormAccueil(user)





        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.")
        End If
    End Sub

    Private Sub LoadFormAccueil(usr As User)
        Dim frm As New frm_accueil()
        frm.Label1.Text = usr.Nom & " " & usr.Prenom
        '  While prjts.Count > 0
        'MsgBox(prjts.Item(1).ToString)
        ' End While
        frm.Show()
    End Sub
End Class
