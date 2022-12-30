Imports MySql.Data.MySqlClient

Public Class frm_accueil
    Private Sub frm_accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_titre.Hide()
        rtxt_desc.Hide()
        txt_dateDebut.Hide()
        btn_valider.Hide()
        btn_annuler.Hide()





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_titre.Show()
        rtxt_desc.Show()
        txt_dateDebut.Show()
        btn_valider.Show()
        btn_annuler.Show()
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        txt_titre.Hide()
        rtxt_desc.Hide()
        txt_dateDebut.Hide()
        btn_valider.Hide()
        btn_annuler.Hide()

    End Sub

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim db As New Database()
        Dim titre As String = txt_titre.Text
        Dim desc As String = rtxt_desc.Text
        Dim idUser As Integer = 1
        Dim dateDebut As String = txt_dateDebut.Text
        Dim projet As New Projet(Nothing, titre, desc, Nothing, idUser, dateDebut, Nothing)
        If db.addProject(projet.Titre, projet.Description, projet.IdUser) Then
            txt_titre.Text = ""
            rtxt_desc.Text = ""

            MsgBox("Projet ajouté avec succès!")
        Else
            MsgBox("Erreur lors de l'ajout du projet!")
        End If
    End Sub

    Private Sub cmb_projet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_projet.SelectedIndexChanged
        Dim test As String = cmb_projet.SelectedItem
        MsgBox("test : " & test)

    End Sub
End Class