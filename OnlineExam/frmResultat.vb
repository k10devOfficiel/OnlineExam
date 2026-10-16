Imports System.Data.OleDb

Public Class frmResultat

    Private Sub frmResultat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConsulter_Click(sender As Object, e As EventArgs) Handles btnConsulter.Click

        Try

            If txtMatricule.Text = "" Then
                MessageBox.Show("Veuillez saisir un matricule")
                Exit Sub
            End If

            btnVoirNote.Visible = False

            If cnx.State = ConnectionState.Closed Then
                cnx.Open()
            End If

            Dim req As String =
                "SELECT MoyCand FROM Moyenne WHERE matCand='" & txtMatricule.Text & "'"

            cd = New OleDbCommand(req, cnx)

            cr = cd.ExecuteReader()

            If cr.Read Then

                Dim resultat As Double = CDbl(cr("MoyCand"))

                If resultat >= 10 Then

                    lblResultat.Text = "Félicitations, vous êtes admis avec une moyenne de " & resultat & "/20"

                    lblResultat.ForeColor = Color.Green

                Else

                    lblResultat.Text =
                        "Désolé, vous êtes refusé avec une moyenne de " & resultat & "/20"

                    lblResultat.ForeColor = Color.Red

                    btnVoirNote.Visible = True

                End If

                btnvider.Visible = True

            Else

                MessageBox.Show("Ce matricule n'existe pas")

            End If

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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnVoirNote_Click(sender As Object, e As EventArgs) Handles btnVoirNote.Click

        frmvoirenote.txtc.Text = txtMatricule.Text
        frmvoirenote.Show()

    End Sub

    Private Sub btnvider_Click(sender As Object, e As EventArgs) Handles btnvider.Click

        txtMatricule.Text = ""
        lblResultat.Text = "--------------------"
        lblResultat.ForeColor = Color.Black
        btnVoirNote.Visible = False
        btnvider.Visible = False
        txtMatricule.Focus()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

End Class