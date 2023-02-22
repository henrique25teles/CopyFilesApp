Imports System.IO
Imports IniFile

Module IniFileSettingsService
    Private Const IniFile = "Settings.ini"
    Private Const FileConfigSection = "FileConfigSection"
    Private Const FileSaveConfig = "FileSaveConfig"
    Private Const FolderBackupConfig = "FolderBackupConfig"

    Private Function GetIniFile() As Ini
        If File.Exists(IniFileSettingsService.IniFile) Then
            Return New Ini(IniFileSettingsService.IniFile)
        Else
            Dim ini As Ini = New Ini

            Dim fileConfigSection = New Section(IniFileSettingsService.FileConfigSection)

            Dim fileSaveConfig = New [Property](IniFileSettingsService.FileSaveConfig, "  ")
            fileConfigSection.Add(fileSaveConfig)

            Dim folderBackupConfig = New [Property](IniFileSettingsService.FolderBackupConfig, "  ")
            fileConfigSection.Add(folderBackupConfig)

            ini.Add(fileConfigSection)

            ini.SaveTo(IniFileSettingsService.IniFile)

            Return ini
        End If
    End Function

    Public Sub ChangeFileSaveConfigSettings(fileSavePath As String)
        Dim ini = GetIniFile()

        Dim section = ini(IniFileSettingsService.FileConfigSection)
        section(IniFileSettingsService.FileSaveConfig) = fileSavePath

        ini.SaveTo(IniFileSettingsService.IniFile)
    End Sub

    Public Function GetFileSaveConfigSettings() As String
        Dim ini = GetIniFile()

        Dim section = ini(IniFileSettingsService.FileConfigSection)

        Return section(IniFileSettingsService.FileSaveConfig)
    End Function

    Public Sub ChangeFolderBackupConfigSettings(folderBackupPath As String)
        Dim ini = GetIniFile()

        Dim section = ini(IniFileSettingsService.FileConfigSection)
        section(IniFileSettingsService.FolderBackupConfig) = folderBackupPath

        ini.SaveTo(IniFileSettingsService.IniFile)
    End Sub

    Public Function GetFolderBackupConfigSettings() As String
        Dim ini = GetIniFile()

        Dim section = ini(IniFileSettingsService.FileConfigSection)

        Return section(IniFileSettingsService.FolderBackupConfig)
    End Function
End Module
