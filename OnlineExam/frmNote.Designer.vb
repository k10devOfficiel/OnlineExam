<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNote
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNote = New System.Windows.Forms.Button()
        Me.cboMatricule = New System.Windows.Forms.ComboBox()
        Me.txtINecrite = New System.Windows.Forms.TextBox()
        Me.txtINoral = New System.Windows.Forms.TextBox()
        Me.txtANoral = New System.Windows.Forms.TextBox()
        Me.txtANecrite = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Ravie", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(498, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 36)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "OnlineExam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(997, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ce formulaire vous permet d'enregistrer les notes des candidats   dans les unitée" &
    "s suivantes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnNote)
        Me.GroupBox1.Controls.Add(Me.cboMatricule)
        Me.GroupBox1.Controls.Add(Me.txtINecrite)
        Me.GroupBox1.Controls.Add(Me.txtINoral)
        Me.GroupBox1.Controls.Add(Me.txtANoral)
        Me.GroupBox1.Controls.Add(Me.txtANecrite)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(264, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 309)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enregistrement"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(373, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 29)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Ecrite"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(373, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 29)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Oral"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 29)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Ecrite"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 29)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Oral"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Choisir le matricule"
        '
        'btnNote
        '
        Me.btnNote.Location = New System.Drawing.Point(230, 258)
        Me.btnNote.Name = "btnNote"
        Me.btnNote.Size = New System.Drawing.Size(288, 45)
        Me.btnNote.TabIndex = 7
        Me.btnNote.Text = "Enregistrer"
        Me.btnNote.UseVisualStyleBackColor = True
        '
        'cboMatricule
        '
        Me.cboMatricule.FormattingEnabled = True
        Me.cboMatricule.Location = New System.Drawing.Point(345, 25)
        Me.cboMatricule.Name = "cboMatricule"
        Me.cboMatricule.Size = New System.Drawing.Size(292, 37)
        Me.cboMatricule.TabIndex = 6
        '
        'txtINecrite
        '
        Me.txtINecrite.Location = New System.Drawing.Point(133, 176)
        Me.txtINecrite.Name = "txtINecrite"
        Me.txtINecrite.Size = New System.Drawing.Size(189, 36)
        Me.txtINecrite.TabIndex = 5
        '
        'txtINoral
        '
        Me.txtINoral.Location = New System.Drawing.Point(133, 122)
        Me.txtINoral.Name = "txtINoral"
        Me.txtINoral.Size = New System.Drawing.Size(189, 36)
        Me.txtINoral.TabIndex = 4
        '
        'txtANoral
        '
        Me.txtANoral.Location = New System.Drawing.Point(473, 122)
        Me.txtANoral.Name = "txtANoral"
        Me.txtANoral.Size = New System.Drawing.Size(164, 36)
        Me.txtANoral.TabIndex = 3
        '
        'txtANecrite
        '
        Me.txtANecrite.Location = New System.Drawing.Point(473, 176)
        Me.txtANecrite.Name = "txtANecrite"
        Me.txtANecrite.Size = New System.Drawing.Size(164, 36)
        Me.txtANecrite.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(419, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Anglais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Informatique"
        '
        'frmNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1228, 559)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNote"
        Me.Text = "frmNote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNote As Button
    Friend WithEvents cboMatricule As ComboBox
    Friend WithEvents txtINecrite As TextBox
    Friend WithEvents txtINoral As TextBox
    Friend WithEvents txtANoral As TextBox
    Friend WithEvents txtANecrite As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
