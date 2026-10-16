<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultat
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
        Me.txtMatricule = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConsulter = New System.Windows.Forms.Button()
        Me.lblResultat = New System.Windows.Forms.Label()
        Me.btnVoirNote = New System.Windows.Forms.Button()
        Me.btnvider = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Ravie", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 36)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "OnlineExam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Consulter  vos resultas "
        '
        'txtMatricule
        '
        Me.txtMatricule.Location = New System.Drawing.Point(248, 74)
        Me.txtMatricule.Name = "txtMatricule"
        Me.txtMatricule.Size = New System.Drawing.Size(228, 30)
        Me.txtMatricule.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnvider)
        Me.GroupBox1.Controls.Add(Me.btnVoirNote)
        Me.GroupBox1.Controls.Add(Me.lblResultat)
        Me.GroupBox1.Controls.Add(Me.btnConsulter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMatricule)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 273)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultation de resultat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Entrer votre matricule"
        '
        'btnConsulter
        '
        Me.btnConsulter.Location = New System.Drawing.Point(59, 214)
        Me.btnConsulter.Name = "btnConsulter"
        Me.btnConsulter.Size = New System.Drawing.Size(212, 37)
        Me.btnConsulter.TabIndex = 13
        Me.btnConsulter.Text = "Consulter"
        Me.btnConsulter.UseVisualStyleBackColor = True
        '
        'lblResultat
        '
        Me.lblResultat.AutoSize = True
        Me.lblResultat.Location = New System.Drawing.Point(122, 157)
        Me.lblResultat.Name = "lblResultat"
        Me.lblResultat.Size = New System.Drawing.Size(258, 23)
        Me.lblResultat.TabIndex = 14
        Me.lblResultat.Text = "-------------------------------"
        '
        'btnVoirNote
        '
        Me.btnVoirNote.ForeColor = System.Drawing.Color.Red
        Me.btnVoirNote.Location = New System.Drawing.Point(289, 214)
        Me.btnVoirNote.Name = "btnVoirNote"
        Me.btnVoirNote.Size = New System.Drawing.Size(174, 37)
        Me.btnVoirNote.TabIndex = 15
        Me.btnVoirNote.Text = "Voir mes notes"
        Me.btnVoirNote.UseVisualStyleBackColor = True
        Me.btnVoirNote.Visible = False
        '
        'btnvider
        '
        Me.btnvider.ForeColor = System.Drawing.Color.Red
        Me.btnvider.Location = New System.Drawing.Point(498, 214)
        Me.btnvider.Name = "btnvider"
        Me.btnvider.Size = New System.Drawing.Size(174, 37)
        Me.btnvider.TabIndex = 16
        Me.btnvider.Text = "Vider"
        Me.btnvider.UseVisualStyleBackColor = True
        Me.btnvider.Visible = False
        '
        'frmResultat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmResultat"
        Me.Text = "frmResultat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMatricule As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnConsulter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResultat As Label
    Friend WithEvents btnVoirNote As Button
    Friend WithEvents btnvider As Button
End Class
