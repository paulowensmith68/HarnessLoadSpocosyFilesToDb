Public Class frmMain
    Private Sub btnLoadDatabase_Click(sender As Object, e As EventArgs) Handles btnLoadDatabase.Click

        gobjEvent.WriteToEventLog("Windows worker thread :  created.")

        ' Write log entries for configuration settings
        gobjEvent.WriteToEventLog("WorkerThread : Cycle every (secs) : " + My.Settings.ProcessCycleEverySecs.ToString)
        gobjEvent.WriteToEventLog("WorkerThread : Cycle every (millisecs) :")



        Dim xmlData As New LocalScoposyFile()
        For Each XmlItem As LocalScoposyFile In xmlData.newXml()

            XmlItem.parseData()
        Next

    End Sub
End Class