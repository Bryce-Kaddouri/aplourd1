Imports System.Web
Imports System.Windows

Public Class Form1
    Dim user As User = Nothing
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim db As New Database()

        user = db.TryLogin(txt_login.Text, txt_mdp.Text)
        ' projects = db.getProjetsByUser(user.Id)
        If user IsNot Nothing Then
            MessageBox.Show("Connexion réussie!" & user.Id)
            Me.Hide()
            Dim projets As New List(Of Projet)()
            projets = db.getProjetsByUser(user.Id)
            LoadFormAccueil(user, projets)





        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.")
        End If
    End Sub

    Private Sub LoadFormAccueil(usr As User, projets As List(Of Projet))
        Dim frm As New frm_accueil()
        frm.Label1.Text = usr.Nom & " " & usr.Prenom

        Dim db As New Database()
        Dim cpt As Integer

        cpt = 0

        For Each projet As Projet In projets
            'Console.WriteLine("ID: " & projet.Id)
            MsgBox(projet.DateDebut)
            frm.cmb_projet.Items.Add(projet.Id & " - " & projet.IdUser & " - " & projet.Titre & " - " & projet.DateDebut)
            'Console.WriteLine("Description: " & projet.Description)
        Next
        '  While prjts.Count > 0
        'MsgBox(prjts.Item(1).ToString)
        ' End While
        frm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
