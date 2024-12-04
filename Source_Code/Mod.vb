Imports System
Imports System.Data
Imports Npgsql
Module dbConnection
    Public con As New NpgsqlConnection("Server=127.0.0.1;Port=5432;User ID=postgres;Password=000000;Database=postgres;")
    Public da As New NpgsqlDataAdapter
    Public cmd As New NpgsqlCommand
    Public myDB As String

    Public Sub DoConnect()
        con.ConnectionString = "Server=127.0.0.1;Port=5432;User ID=postgres;Password=000000;Database=postgres;"
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then con.Open()
    End Sub
End Module
