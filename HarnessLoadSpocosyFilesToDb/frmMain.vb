Public Class frmMain
    Private Sub btnLoadDatabase_Click(sender As Object, e As EventArgs) Handles btnLoadDatabase.Click


        Dim xmlData As New LocalScoposyFile()
        For Each XmlItem As LocalScoposyFile In xmlData.newXml()

            XmlItem.parseData()
        Next

    End Sub
End Class