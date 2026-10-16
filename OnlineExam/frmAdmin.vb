Imports System.Data.OleDb

Public Class frmAdmin

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CandidatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CandidatToolStripMenuItem.Click
        frmCandidat.Show()
    End Sub

    Private Sub SaisirNoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaisirNoteToolStripMenuItem.Click
        frmNote.Show()
    End Sub

End Class