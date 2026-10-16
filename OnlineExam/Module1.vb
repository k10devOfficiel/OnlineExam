Imports System.Data.OleDb

Module Module1
    Public cnx As New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\OnlineExam.accdb; Persist Security Info=False")
    Public cd As OleDbCommand
    Public cr As OleDbDataReader
    Public cs As DataSet
    Public ca As OleDbDataAdapter
    Public cb As OleDbCommandBuilder
End Module
