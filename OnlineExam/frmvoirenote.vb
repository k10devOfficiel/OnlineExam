Imports System.Data.OleDb
Public Class frmvoirenote
    Private Sub frmvoirenote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtANecrite_TextChanged(sender As Object, e As EventArgs) Handles txtANecrite.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtINecrite_TextChanged(sender As Object, e As EventArgs) Handles txtINecrite.TextChanged

    End Sub

    Private Sub txtANoral_TextChanged(sender As Object, e As EventArgs) Handles txtANoral.TextChanged

    End Sub

    Private Sub txtINoral_TextChanged(sender As Object, e As EventArgs) Handles txtINoral.TextChanged

    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click

        Try

            If txtc.Text = "" Then
                MessageBox.Show("Veuillez saisir un matricule")
                Exit Sub
            End If

            If cnx.State = ConnectionState.Closed Then
                cnx.Open()
            End If

            Dim req As String =
            "select * from NoteC where matCand = '" & txtc.Text & "'"

            cd = New OleDbCommand(req, cnx)

            cr = cd.ExecuteReader()

            If cr.Read Then

                txtINecrite.Text = cr("NoteIE").ToString
                txtINoral.Text = cr("NoteIO").ToString
                txtANecrite.Text = cr("NoteAE").ToString
                txtANoral.Text = cr("NoteAO").ToString

            Else

                txtINecrite.Text = ""
                txtINoral.Text = ""
                txtANecrite.Text = ""
                txtANoral.Text = ""

                MessageBox.Show("Aucune note trouvée")

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmResultat.Show()
    End Sub
End Class