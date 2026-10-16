Imports System.Data.OleDb

Public Class frmNote
    Public moyI As Double = 0
    Public moyA As Double = 0

    Private Sub frmNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = frmAdmin

        Try

            cboMatricule.Items.Clear()

            If cnx.State = ConnectionState.Closed Then
                cnx.Open()
            End If

            Dim req As String = "select matCand from Candidat"

            cd = New OleDbCommand(req, cnx)

            cr = cd.ExecuteReader()

            While cr.Read

                cboMatricule.Items.Add(cr("matCand").ToString)

            End While

            cr.Close()
            cd.Dispose()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If

        End Try

    End Sub

    Private Sub btnNote_Click(sender As Object, e As EventArgs) Handles btnNote.Click
        Try
            If Val(txtINecrite.Text) > 20 Or Val(txtINoral.Text) > 20 Or Val(txtANecrite.Text) > 20 Or Val(txtANoral.Text) > 20 Then
                MessageBox.Show("Erreur : Les notes ne peuvent pas dépasser 20 !")
                Exit Sub
            End If

            If Val(txtINecrite.Text) < 0 Or Val(txtINoral.Text) < 0 Or Val(txtANecrite.Text) < 0 Or Val(txtANoral.Text) < 0 Then
                MessageBox.Show("Erreur : Les notes ne peuvent pas être inférieures à 0 !")
                Exit Sub
            End If


            ' On nettoie les virgules pour éviter les bugs de calcul
            Dim txtIE As String = txtINecrite.Text.Replace(",", ".")
            Dim txtIO As String = txtINoral.Text.Replace(",", ".")
            Dim txtAE As String = txtANecrite.Text.Replace(",", ".")
            Dim txtAO As String = txtANoral.Text.Replace(",", ".")

            If cnx.State = ConnectionState.Closed Then cnx.Open()

            Dim req As String = "insert into NoteC(matCand, NoteIE, NoteIO, NoteAE, NoteAO) Values('" & cboMatricule.Text & "', " & Val(txtIE) & ", " & Val(txtIO) & ", " & Val(txtAE) & ", " & Val(txtAO) & ")"

            cd = New OleDbCommand(req, cnx)
            cd.ExecuteNonQuery()
            cnx.Close()
            MessageBox.Show("Les notes du matricule " & cboMatricule.Text & " sont enregistrées.")

            moyI = (Val(txtIE) + Val(txtIO)) / 2
            moyA = (Val(txtAE) + Val(txtAO)) / 2
            Dim moyeG As Double = ((moyI * 2) + moyA) / 3

            ' On nettoie la moyenne pour la deuxième table
            Dim moyeGStr As String = moyeG.ToString().Replace(",", ".")

            If cnx.State = ConnectionState.Closed Then cnx.Open()

            Dim reqs As String = "insert into Moyenne(matCand,MoyCand) Values ('" & cboMatricule.Text & "', " & moyeGStr & ")"
            cd = New OleDbCommand(reqs, cnx)
            cd.ExecuteNonQuery()
            cnx.Close()
            MessageBox.Show("La moyenne a été enregistrée.")

            cboMatricule.Text = ""
            txtINecrite.Clear()
            txtINoral.Clear()
            txtANecrite.Clear()
            txtANoral.Clear()

            cboMatricule.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then cnx.Close()
        End Try
    End Sub
End Class
