Imports System.Data.OleDb

Public Class frmCandidat
    Private Sub frmCandidat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmAdmin


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()

        End If
        Dim req As String = "insert into Candidat (matCand,nomCand,prenomCand,datenaissanceCand,filiereCand) Values ('" & txtMatricule.Text & "','" & txtNom.Text & "','" & txtPrenom.Text & "','" & DTP.Value & "','" & txtFilire.Text & "')"


        Try

            cd = New OleDbCommand(req, cnx)
            cd.ExecuteNonQuery()

            MessageBox.Show("le candidat " & " " & txtNom.Text & " a été enregistré ")
            txtMatricule.Text = ""
            txtNom.Text = ""
            txtPrenom.Text = ""
            txtFilire.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cd.Dispose()

    End Sub

    Private Sub btnMatricule_TextChanged(sender As Object, e As EventArgs) Handles txtMatricule.TextChanged

    End Sub
End Class