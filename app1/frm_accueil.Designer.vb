<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_projet = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_titre = New System.Windows.Forms.TextBox()
        Me.txt_dateDebut = New System.Windows.Forms.TextBox()
        Me.rtxt_desc = New System.Windows.Forms.RichTextBox()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(641, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To Do List By Bryce Kaddouri"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1463, 61)
        Me.Panel1.TabIndex = 1
        '
        'cmb_projet
        '
        Me.cmb_projet.FormattingEnabled = True
        Me.cmb_projet.Location = New System.Drawing.Point(233, 65)
        Me.cmb_projet.Name = "cmb_projet"
        Me.cmb_projet.Size = New System.Drawing.Size(913, 28)
        Me.cmb_projet.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(63, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Choix du projet :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.Location = New System.Drawing.Point(1195, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = " + Nouveau"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_titre
        '
        Me.txt_titre.Location = New System.Drawing.Point(369, 156)
        Me.txt_titre.Name = "txt_titre"
        Me.txt_titre.Size = New System.Drawing.Size(777, 27)
        Me.txt_titre.TabIndex = 5
        '
        'txt_dateDebut
        '
        Me.txt_dateDebut.Location = New System.Drawing.Point(369, 362)
        Me.txt_dateDebut.Name = "txt_dateDebut"
        Me.txt_dateDebut.Size = New System.Drawing.Size(777, 27)
        Me.txt_dateDebut.TabIndex = 9
        '
        'rtxt_desc
        '
        Me.rtxt_desc.Location = New System.Drawing.Point(369, 207)
        Me.rtxt_desc.Name = "rtxt_desc"
        Me.rtxt_desc.Size = New System.Drawing.Size(777, 109)
        Me.rtxt_desc.TabIndex = 10
        Me.rtxt_desc.Text = ""
        '
        'btn_valider
        '
        Me.btn_valider.Location = New System.Drawing.Point(369, 528)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(254, 41)
        Me.btn_valider.TabIndex = 11
        Me.btn_valider.Text = "valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Location = New System.Drawing.Point(892, 528)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(254, 41)
        Me.btn_annuler.TabIndex = 12
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'frm_accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1457, 809)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.rtxt_desc)
        Me.Controls.Add(Me.txt_dateDebut)
        Me.Controls.Add(Me.txt_titre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_projet)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_accueil"
        Me.Text = "frm_accueil"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmb_projet As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents txt_dateDebut As TextBox
    Friend WithEvents rtxt_desc As RichTextBox
    Friend WithEvents btn_valider As Button
    Friend WithEvents btn_annuler As Button
End Class
