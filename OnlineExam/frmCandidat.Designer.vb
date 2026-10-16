<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCandidat
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMatricule = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtFilire = New System.Windows.Forms.TextBox()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Ravie", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(442, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "OnlineExam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(788, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Avec ce formulaire vous pouver enregistrer les Candidats selon les champs suivans" &
    ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEnregistrer)
        Me.GroupBox1.Controls.Add(Me.DTP)
        Me.GroupBox1.Controls.Add(Me.txtFilire)
        Me.GroupBox1.Controls.Add(Me.txtPrenom)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.txtMatricule)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(147, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 448)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Candidats"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "DateDe naissance:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Matricule:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nom:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 29)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Prenom:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 29)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Filière:"
        '
        'txtMatricule
        '
        Me.txtMatricule.Location = New System.Drawing.Point(226, 29)
        Me.txtMatricule.Name = "txtMatricule"
        Me.txtMatricule.Size = New System.Drawing.Size(537, 36)
        Me.txtMatricule.TabIndex = 5
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(226, 96)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(537, 36)
        Me.txtNom.TabIndex = 6
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(226, 169)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(537, 36)
        Me.txtPrenom.TabIndex = 7
        '
        'txtFilire
        '
        Me.txtFilire.Location = New System.Drawing.Point(306, 330)
        Me.txtFilire.Name = "txtFilire"
        Me.txtFilire.Size = New System.Drawing.Size(457, 36)
        Me.txtFilire.TabIndex = 9
        '
        'DTP
        '
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(318, 243)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(445, 36)
        Me.DTP.TabIndex = 10
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Location = New System.Drawing.Point(202, 391)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(456, 51)
        Me.btnEnregistrer.TabIndex = 11
        Me.btnEnregistrer.Text = "Enregistre"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'frmCandidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1206, 537)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCandidat"
        Me.Text = "frmCandidat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFilire As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtMatricule As TextBox
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents btnEnregistrer As Button
End Class
