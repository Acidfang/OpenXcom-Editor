Imports System.IO
Public Class frm_main

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        With OpenFileDialog1
            .InitialDirectory = Environ("USERPROFILE") & "\Documents\OpenXcom"
            .Filter = "OpenXcom Save Files (*.sav)|*.sav"
            .FileName = Nothing
            .ShowDialog()
            If Not .FileName Is Nothing Then
                Dim fileReader As StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader(.FileName)
                Dim string_line As String = fileReader.ReadLine()
                string_line = fileReader.ReadLine()

            End If
        End With
    End Sub
End Class
