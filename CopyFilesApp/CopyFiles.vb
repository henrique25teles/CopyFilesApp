Imports System.IO

Public Class CopyFiles
    Private Sub CopyFiles_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtFilePathToCopy.Text = IniFileSettingsService.GetFileSaveConfigSettings()
        Me.txtFolderToBackupTo.Text = IniFileSettingsService.GetFolderBackupConfigSettings()
    End Sub

    Private Sub btnBrowseFileToCopy_Click(sender As Object, e As EventArgs) Handles btnBrowseFileToCopy.Click
        Dim browseDialogResult = Me.FolderBrowserFileToCopy.ShowDialog()

        If browseDialogResult = DialogResult.OK Then

            Me.txtFilePathToCopy.Text = Me.FolderBrowserFileToCopy.FileName

            IniFileSettingsService.ChangeFileSaveConfigSettings(Me.FolderBrowserFileToCopy.FileName)

        End If

    End Sub

    Private Sub btnBrowseBackupFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseBackupFolder.Click
        Dim browseFolderDialogResult = Me.FolderBrowserFolder.ShowDialog()

        If browseFolderDialogResult = DialogResult.OK Then

            Me.txtFolderToBackupTo.Text = Me.FolderBrowserFolder.SelectedPath

            IniFileSettingsService.ChangeFolderBackupConfigSettings(Me.FolderBrowserFolder.SelectedPath)
        End If
    End Sub

    Private Sub btnBackupFile_Click(sender As Object, e As EventArgs) Handles btnBackupFile.Click
        Try
            If Me.txtFilePathToCopy.Text <> "" And Me.txtFolderToBackupTo.Text <> "" Then

                Dim backupFileDestination = GenerateBackup()

                If (File.Exists(backupFileDestination)) Then
                    MessageBox.Show("Successfull backup created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("File not created", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Backup file and backup folder directory must exist to proceed")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GenerateBackup() As String
        Dim backupFile = txtFilePathToCopy.Text
        Dim backupFolderDestination = txtFolderToBackupTo.Text
        Dim fileNameWithoutExtension = Path.GetFileNameWithoutExtension(backupFile)
        Dim fileExtension = Path.GetExtension(backupFile)
        Dim filename = fileNameWithoutExtension + Date.Now.ToString("yyyy-MM-dd-hh-mm") + fileExtension
        Dim backupFileDestination = Path.Combine(backupFolderDestination, filename)

        If Not File.Exists(backupFile) Then
            Throw New FileNotFoundException("File does Not exists")
        End If

        If Not Directory.Exists(backupFolderDestination) Then
            Directory.CreateDirectory(backupFolderDestination)
        End If

        File.Copy(backupFile, backupFileDestination)

        Return backupFileDestination
    End Function

    Private Sub barBackupFrequency_Scroll(sender As Object, e As EventArgs) Handles barBackupFrequency.Scroll

    End Sub

    Private Sub btnStartAutomaticBackup_Click(sender As Object, e As EventArgs) Handles btnStartAutomaticBackup.Click

    End Sub
End Class