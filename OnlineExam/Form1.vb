Imports System.Data.OleDb
Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        If txtMatricule.Text = "" Or txtNomcand.Text = "" Then

            MessageBox.Show("Les Champs sont necessaire pour vous identifier ")

        ElseIf txtMatricule.Text = "Admin" And txtNomcand.Text = "Admin" Then
            frmAdmin.Show()


        Else
            frmResultat.Show()

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
