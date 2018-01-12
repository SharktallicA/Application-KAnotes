Public Class frmMain
    'globals
    Dim strFile As String 'stores currently-processing file

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hide status bar by default
        barStatus.Hide()
    End Sub

    Private Sub itmNew_Click(sender As Object, e As EventArgs) Handles itmNew.Click
        'clears current document
        editor.Clear()
        strFile = Nothing
    End Sub

    Private Sub itmOpen_Click(sender As Object, e As EventArgs) Handles itmOpen.Click
        'opens new file
        Dim dlgOpenFile As New Ookii.Dialogs.VistaOpenFileDialog
        dlgOpenFile.Title = "Open File..."
        dlgOpenFile.Filter = "Rich Text Format|*.rtf"
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            editor.LoadFile(dlgOpenFile.FileName)
            strFile = dlgOpenFile.FileName
        End If
    End Sub

    Private Sub itmSave_Click(sender As Object, e As EventArgs) Handles itmSave.Click
        'saves current document
        If strFile Is Nothing Then
            itmSaveAs_Click(itmSaveAs, New EventArgs()) 'calls for a new save if file has not been opened or saved before
        Else
            editor.SaveFile(strFile)
        End If
    End Sub

    Private Sub itmSaveAs_Click(sender As Object, e As EventArgs) Handles itmSaveAs.Click
        'saves document as new file
        Dim dlgSaveFile As New Ookii.Dialogs.VistaSaveFileDialog
        dlgSaveFile.Title = "Save File..."
        dlgSaveFile.Filter = "Rich Text Format|*.rtf"
        If strFile Is Nothing Then
            dlgSaveFile.FileName = ".rtf"
        Else
            dlgSaveFile.FileName = strFile
        End If
        If dlgSaveFile.ShowDialog() = DialogResult.OK Then
            editor.SaveFile(dlgSaveFile.FileName)
            strFile = dlgSaveFile.FileName
        End If
    End Sub

    Private Sub itmPageSetup_Click(sender As Object, e As EventArgs) Handles itmPageSetup.Click

    End Sub

    Private Sub itmPrint_Click(sender As Object, e As EventArgs) Handles itmPrint.Click

    End Sub

    Private Sub itmExit_Click(sender As Object, e As EventArgs) Handles itmExit.Click
        'exit program
        Close()
    End Sub
    Private Sub itmAbout_Click(sender As Object, e As EventArgs) Handles itmAbout.Click
        'open about form as dialog
        Dim dlgNewAbout As New dlgAbout()
        dlgNewAbout.ShowDialog()
    End Sub
End Class