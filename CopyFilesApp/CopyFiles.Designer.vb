<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopyFiles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBrowseBackupFolder = New System.Windows.Forms.Button()
        Me.lblFolderToBackupTo = New System.Windows.Forms.Label()
        Me.btnBrowseFileToCopy = New System.Windows.Forms.Button()
        Me.txtFolderToBackupTo = New System.Windows.Forms.TextBox()
        Me.lblFilePathToCopy = New System.Windows.Forms.Label()
        Me.txtFilePathToCopy = New System.Windows.Forms.TextBox()
        Me.FolderBrowserFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserFileToCopy = New System.Windows.Forms.OpenFileDialog()
        Me.btnBackupFile = New System.Windows.Forms.Button()
        Me.btnStartAutomaticBackup = New System.Windows.Forms.Button()
        Me.btnStopBackupAutomatically = New System.Windows.Forms.Button()
        Me.barBackupFrequency = New System.Windows.Forms.TrackBar()
        Me.lblBackupFrequency = New System.Windows.Forms.Label()
        CType(Me.barBackupFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowseBackupFolder
        '
        Me.btnBrowseBackupFolder.Location = New System.Drawing.Point(713, 86)
        Me.btnBrowseBackupFolder.Name = "btnBrowseBackupFolder"
        Me.btnBrowseBackupFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseBackupFolder.TabIndex = 5
        Me.btnBrowseBackupFolder.Text = "Browse"
        Me.btnBrowseBackupFolder.UseVisualStyleBackColor = True
        '
        'lblFolderToBackupTo
        '
        Me.lblFolderToBackupTo.AutoSize = True
        Me.lblFolderToBackupTo.Location = New System.Drawing.Point(18, 68)
        Me.lblFolderToBackupTo.Name = "lblFolderToBackupTo"
        Me.lblFolderToBackupTo.Size = New System.Drawing.Size(103, 15)
        Me.lblFolderToBackupTo.TabIndex = 3
        Me.lblFolderToBackupTo.Text = "Folder Destination"
        '
        'btnBrowseFileToCopy
        '
        Me.btnBrowseFileToCopy.Location = New System.Drawing.Point(713, 32)
        Me.btnBrowseFileToCopy.Name = "btnBrowseFileToCopy"
        Me.btnBrowseFileToCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseFileToCopy.TabIndex = 2
        Me.btnBrowseFileToCopy.Text = "Browse"
        Me.btnBrowseFileToCopy.UseVisualStyleBackColor = True
        '
        'txtFolderToBackupTo
        '
        Me.txtFolderToBackupTo.Location = New System.Drawing.Point(17, 87)
        Me.txtFolderToBackupTo.Name = "txtFolderToBackupTo"
        Me.txtFolderToBackupTo.Size = New System.Drawing.Size(690, 23)
        Me.txtFolderToBackupTo.TabIndex = 4
        '
        'lblFilePathToCopy
        '
        Me.lblFilePathToCopy.AutoSize = True
        Me.lblFilePathToCopy.Location = New System.Drawing.Point(18, 13)
        Me.lblFilePathToCopy.Name = "lblFilePathToCopy"
        Me.lblFilePathToCopy.Size = New System.Drawing.Size(68, 15)
        Me.lblFilePathToCopy.TabIndex = 0
        Me.lblFilePathToCopy.Text = "File to copy"
        '
        'txtFilePathToCopy
        '
        Me.txtFilePathToCopy.Location = New System.Drawing.Point(17, 32)
        Me.txtFilePathToCopy.Name = "txtFilePathToCopy"
        Me.txtFilePathToCopy.Size = New System.Drawing.Size(690, 23)
        Me.txtFilePathToCopy.TabIndex = 1
        '
        'FolderBrowserFolder
        '
        Me.FolderBrowserFolder.RootFolder = System.Environment.SpecialFolder.MyDocuments
        '
        'FolderBrowserFileToCopy
        '
        Me.FolderBrowserFileToCopy.Title = "Select File To Backup"
        '
        'btnBackupFile
        '
        Me.btnBackupFile.Location = New System.Drawing.Point(18, 415)
        Me.btnBackupFile.Name = "btnBackupFile"
        Me.btnBackupFile.Size = New System.Drawing.Size(75, 23)
        Me.btnBackupFile.TabIndex = 10
        Me.btnBackupFile.Text = "Backup File"
        Me.btnBackupFile.UseVisualStyleBackColor = True
        '
        'btnStartAutomaticBackup
        '
        Me.btnStartAutomaticBackup.Location = New System.Drawing.Point(18, 193)
        Me.btnStartAutomaticBackup.Name = "btnStartAutomaticBackup"
        Me.btnStartAutomaticBackup.Size = New System.Drawing.Size(180, 26)
        Me.btnStartAutomaticBackup.TabIndex = 8
        Me.btnStartAutomaticBackup.Text = "Start Backup Automatically"
        Me.btnStartAutomaticBackup.UseVisualStyleBackColor = True
        '
        'btnStopBackupAutomatically
        '
        Me.btnStopBackupAutomatically.Enabled = False
        Me.btnStopBackupAutomatically.Location = New System.Drawing.Point(204, 193)
        Me.btnStopBackupAutomatically.Name = "btnStopBackupAutomatically"
        Me.btnStopBackupAutomatically.Size = New System.Drawing.Size(82, 26)
        Me.btnStopBackupAutomatically.TabIndex = 9
        Me.btnStopBackupAutomatically.Text = "Stop"
        Me.btnStopBackupAutomatically.UseVisualStyleBackColor = True
        '
        'barBackupFrequency
        '
        Me.barBackupFrequency.Location = New System.Drawing.Point(18, 142)
        Me.barBackupFrequency.Name = "barBackupFrequency"
        Me.barBackupFrequency.Size = New System.Drawing.Size(689, 45)
        Me.barBackupFrequency.TabIndex = 7
        Me.barBackupFrequency.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'lblBackupFrequency
        '
        Me.lblBackupFrequency.AutoSize = True
        Me.lblBackupFrequency.Location = New System.Drawing.Point(17, 124)
        Me.lblBackupFrequency.Name = "lblBackupFrequency"
        Me.lblBackupFrequency.Size = New System.Drawing.Size(158, 15)
        Me.lblBackupFrequency.TabIndex = 6
        Me.lblBackupFrequency.Text = "Backup Frequency (Minutes)"
        '
        'CopyFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBackupFrequency)
        Me.Controls.Add(Me.barBackupFrequency)
        Me.Controls.Add(Me.btnStopBackupAutomatically)
        Me.Controls.Add(Me.btnStartAutomaticBackup)
        Me.Controls.Add(Me.btnBackupFile)
        Me.Controls.Add(Me.btnBrowseBackupFolder)
        Me.Controls.Add(Me.lblFolderToBackupTo)
        Me.Controls.Add(Me.btnBrowseFileToCopy)
        Me.Controls.Add(Me.txtFolderToBackupTo)
        Me.Controls.Add(Me.lblFilePathToCopy)
        Me.Controls.Add(Me.txtFilePathToCopy)
        Me.Name = "CopyFiles"
        Me.Text = "CopyFiles"
        CType(Me.barBackupFrequency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowseBackupFolder As Button
    Friend WithEvents lblFolderToBackupTo As Label
    Friend WithEvents btnBrowseFileToCopy As Button
    Friend WithEvents txtFolderToBackupTo As TextBox
    Friend WithEvents lblFilePathToCopy As Label
    Friend WithEvents txtFilePathToCopy As TextBox
    Friend WithEvents FolderBrowserFolder As FolderBrowserDialog
    Friend WithEvents FolderBrowserFileToCopy As OpenFileDialog
    Friend WithEvents btnBackupFile As Button
    Friend WithEvents btnStartAutomaticBackup As Button
    Friend WithEvents btnStopBackupAutomatically As Button
    Friend WithEvents barBackupFrequency As TrackBar
    Friend WithEvents lblBackupFrequency As Label
End Class
