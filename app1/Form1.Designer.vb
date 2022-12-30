<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_mdp = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(81, 219)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(283, 27)
        Me.txt_login.TabIndex = 0
        '
        'txt_mdp
        '
        Me.txt_mdp.Location = New System.Drawing.Point(81, 303)
        Me.txt_mdp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_mdp.Name = "txt_mdp"
        Me.txt_mdp.Size = New System.Drawing.Size(283, 27)
        Me.txt_mdp.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(81, 457)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(283, 43)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 600)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_mdp)
        Me.Controls.Add(Me.txt_login)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_mdp As TextBox
    Friend WithEvents btn_login As Button
End Class
