<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvoirenote
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtINecrite = New System.Windows.Forms.TextBox()
        Me.txtINoral = New System.Windows.Forms.TextBox()
        Me.txtANoral = New System.Windows.Forms.TextBox()
        Me.txtANecrite = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtc = New System.Windows.Forms.TextBox()
        Me.btnc = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnc)
        Me.GroupBox1.Controls.Add(Me.txtc)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtINecrite)
        Me.GroupBox1.Controls.Add(Me.txtINoral)
        Me.GroupBox1.Controls.Add(Me.txtANoral)
        Me.GroupBox1.Controls.Add(Me.txtANecrite)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 331)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulter mes note"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(440, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 19)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Ecrite"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(440, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Oral"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Ecrite"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 19)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Oral"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Entrer votre matricule"
        '
        'txtINecrite
        '
        Me.txtINecrite.Location = New System.Drawing.Point(200, 247)
        Me.txtINecrite.Name = "txtINecrite"
        Me.txtINecrite.ReadOnly = True
        Me.txtINecrite.Size = New System.Drawing.Size(189, 27)
        Me.txtINecrite.TabIndex = 18
        '
        'txtINoral
        '
        Me.txtINoral.Location = New System.Drawing.Point(200, 193)
        Me.txtINoral.Name = "txtINoral"
        Me.txtINoral.ReadOnly = True
        Me.txtINoral.Size = New System.Drawing.Size(189, 27)
        Me.txtINoral.TabIndex = 17
        '
        'txtANoral
        '
        Me.txtANoral.Location = New System.Drawing.Point(540, 193)
        Me.txtANoral.Name = "txtANoral"
        Me.txtANoral.ReadOnly = True
        Me.txtANoral.Size = New System.Drawing.Size(164, 27)
        Me.txtANoral.TabIndex = 16
        '
        'txtANecrite
        '
        Me.txtANecrite.Location = New System.Drawing.Point(540, 247)
        Me.txtANecrite.Name = "txtANecrite"
        Me.txtANecrite.ReadOnly = True
        Me.txtANecrite.Size = New System.Drawing.Size(164, 27)
        Me.txtANecrite.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(546, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Anglais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Informatique"
        '
        'txtc
        '
        Me.txtc.Location = New System.Drawing.Point(356, 74)
        Me.txtc.Name = "txtc"
        Me.txtc.Size = New System.Drawing.Size(164, 27)
        Me.txtc.TabIndex = 25
        '
        'btnc
        '
        Me.btnc.Location = New System.Drawing.Point(283, 107)
        Me.btnc.Name = "btnc"
        Me.btnc.Size = New System.Drawing.Size(191, 37)
        Me.btnc.TabIndex = 26
        Me.btnc.Text = "Consulter mes notes"
        Me.btnc.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Retour"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmvoirenote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmvoirenote"
        Me.Text = "frmvoirenote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtINecrite As TextBox
    Friend WithEvents txtINoral As TextBox
    Friend WithEvents txtANoral As TextBox
    Friend WithEvents txtANecrite As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnc As Button
    Friend WithEvents Button1 As Button
End Class
