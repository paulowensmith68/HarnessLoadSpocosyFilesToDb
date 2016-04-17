Imports System.Xml
Imports System.IO
Imports System.Text
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class LocalScoposyFile

    ' Holds the connection string to the database used.
    Public connectionString As String = globalConnectionString

    Private NodeDatabaseList As New List(Of NodeClass)()

    'Vars used for output message
    Private insertCount As Integer = 0
    Private updateCount As Integer = 0

    'List that hold info on which nodes and attributes to use.
    'These lists are populated in populateLists() function
    Private nodeList As String = ""
    Private attribList As New Dictionary(Of String, String)()

    'ID of XML file. This id is generated after push when xml file is saved.
    Public id As Integer = 0

    'String that holds the xml data. Only used in push. When parsed myXml is used.
    Public xmlData As String = ""

    'XmlDocument var that is used for parsing
    Public myXml As New XmlDocument()

    ' Vars used to control cursor
    Public intCursorCount As Integer = 0

    ' List of filenames to process
    Dim fileNameList As New List(Of String)

    Public Sub SelectFiles()
        '-----------------------------------------------------------------------*
        ' Sub Routine parameters                                                *
        '-----------------------------------------------------------------------*
        Dim cno As MySqlConnection = New MySqlConnection(connectionString)
        Dim dr As MySqlDataReader
        Dim cmd As New MySqlCommand

        ' Reset cursor counter
        intCursorCount = 0

        ' /----------------------------------------------------------------\
        ' | MySql Select                                                   |
        ' | Get all rows for nodeName from bookmaker_xml_nodes             |
        ' \----------------------------------------------------------------/
        cmd.CommandText = "Select id from saved_streammed_xml order by id"
        cmd.Connection = cno

        Try
            cno.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then

                While dr.Read()

                    ' Increment counter
                    intCursorCount = intCursorCount + 1

                    Dim id = dr.GetInt32(0)
                    Dim fullFilename As New String(id.ToString + ".xml")
                    fileNameList.Add(fullFilename)

                    ' Leave cursor when we hit limit
                    If intCursorCount >= My.Settings.MaxFilesToLoad Then
                        Exit While
                    End If

                End While ' End: Outer Loop

            End If

            ' Close the Data reader
            dr.Close()

        Finally
            cno.Close()
        End Try



    End Sub

End Class
