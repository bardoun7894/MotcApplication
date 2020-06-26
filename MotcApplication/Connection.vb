
Imports System.Configuration
Imports System.Data.OleDb
Module Connection

    Dim ConString As String = ConfigurationManager.ConnectionStrings("ConString").ConnectionString

    Public conn As New OleDbConnection(ConString)
    Public adaterReciepient, adaterDonor, adapterTransplantList, adaterNote As OleDbDataAdapter
    Public dr As OleDbDataReader

    Public adater As OleDbDataAdapter
    Public cmd As OleDbCommand
End Module
