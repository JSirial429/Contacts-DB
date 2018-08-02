<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactInfoDisplay
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
        Me.gboContactInfo = New System.Windows.Forms.GroupBox()
        Me.lblOutputID = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblOutputFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblOutputMiddleName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblOutputLastName = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblOutputType = New System.Windows.Forms.Label()
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.lblOutputTelephone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblOutputExtension = New System.Windows.Forms.Label()
        Me.lblOutputEmail = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.btnPreviousRecord = New System.Windows.Forms.Button()
        Me.gboContactInfo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboContactInfo
        '
        Me.gboContactInfo.Controls.Add(Me.lblOutputID)
        Me.gboContactInfo.Controls.Add(Me.lblID)
        Me.gboContactInfo.Controls.Add(Me.lblFirstName)
        Me.gboContactInfo.Controls.Add(Me.lblOutputFirstName)
        Me.gboContactInfo.Controls.Add(Me.lblMiddleName)
        Me.gboContactInfo.Controls.Add(Me.lblOutputMiddleName)
        Me.gboContactInfo.Controls.Add(Me.lblLastName)
        Me.gboContactInfo.Controls.Add(Me.lblOutputLastName)
        Me.gboContactInfo.Controls.Add(Me.lblType)
        Me.gboContactInfo.Controls.Add(Me.lblTelephone)
        Me.gboContactInfo.Controls.Add(Me.lblOutputType)
        Me.gboContactInfo.Controls.Add(Me.lblExtension)
        Me.gboContactInfo.Controls.Add(Me.lblOutputTelephone)
        Me.gboContactInfo.Controls.Add(Me.lblEmail)
        Me.gboContactInfo.Controls.Add(Me.lblOutputExtension)
        Me.gboContactInfo.Controls.Add(Me.lblOutputEmail)
        Me.gboContactInfo.Location = New System.Drawing.Point(23, 49)
        Me.gboContactInfo.Margin = New System.Windows.Forms.Padding(17, 16, 17, 16)
        Me.gboContactInfo.Name = "gboContactInfo"
        Me.gboContactInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.gboContactInfo.Size = New System.Drawing.Size(336, 291)
        Me.gboContactInfo.TabIndex = 0
        Me.gboContactInfo.TabStop = False
        Me.gboContactInfo.Text = "Display Contact Info"
        '
        'lblOutputID
        '
        Me.lblOutputID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputID.Location = New System.Drawing.Point(156, 50)
        Me.lblOutputID.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblOutputID.Name = "lblOutputID"
        Me.lblOutputID.Size = New System.Drawing.Size(145, 15)
        Me.lblOutputID.TabIndex = 17
        Me.lblOutputID.Text = "lblOutputID"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(123, 50)
        Me.lblID.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 16
        Me.lblID.Text = "ID:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(83, 80)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 15
        Me.lblFirstName.Text = "First Name:"
        '
        'lblOutputFirstName
        '
        Me.lblOutputFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputFirstName.Location = New System.Drawing.Point(156, 78)
        Me.lblOutputFirstName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblOutputFirstName.Name = "lblOutputFirstName"
        Me.lblOutputFirstName.Size = New System.Drawing.Size(145, 15)
        Me.lblOutputFirstName.TabIndex = 14
        Me.lblOutputFirstName.Text = "lblOutputFirstName"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(73, 106)
        Me.lblMiddleName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(72, 13)
        Me.lblMiddleName.TabIndex = 13
        Me.lblMiddleName.Text = "Middle Name:"
        '
        'lblOutputMiddleName
        '
        Me.lblOutputMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputMiddleName.Location = New System.Drawing.Point(156, 106)
        Me.lblOutputMiddleName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblOutputMiddleName.Name = "lblOutputMiddleName"
        Me.lblOutputMiddleName.Size = New System.Drawing.Size(145, 15)
        Me.lblOutputMiddleName.TabIndex = 12
        Me.lblOutputMiddleName.Text = "lblOutputMiddleName"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(83, 136)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 11
        Me.lblLastName.Text = "Last Name:"
        '
        'lblOutputLastName
        '
        Me.lblOutputLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputLastName.Location = New System.Drawing.Point(156, 134)
        Me.lblOutputLastName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblOutputLastName.Name = "lblOutputLastName"
        Me.lblOutputLastName.Size = New System.Drawing.Size(145, 15)
        Me.lblOutputLastName.TabIndex = 10
        Me.lblOutputLastName.Text = "lblOutputLastName"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(111, 162)
        Me.lblType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 9
        Me.lblType.Text = "Type:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(84, 192)
        Me.lblTelephone.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblTelephone.TabIndex = 8
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblOutputType
        '
        Me.lblOutputType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputType.Location = New System.Drawing.Point(156, 162)
        Me.lblOutputType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblOutputType.Name = "lblOutputType"
        Me.lblOutputType.Size = New System.Drawing.Size(145, 15)
        Me.lblOutputType.TabIndex = 7
        Me.lblOutputType.Text = "lblOutputType"
        '
        'lblExtension
        '
        Me.lblExtension.AutoSize = True
        Me.lblExtension.Location = New System.Drawing.Point(90, 218)
        Me.lblExtension.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(56, 13)
        Me.lblExtension.TabIndex = 6
        Me.lblExtension.Text = "Extension:"
        '
        'lblOutputTelephone
        '
        Me.lblOutputTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputTelephone.Location = New System.Drawing.Point(156, 190)
        Me.lblOutputTelephone.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblOutputTelephone.Name = "lblOutputTelephone"
        Me.lblOutputTelephone.Size = New System.Drawing.Size(145, 15)
        Me.lblOutputTelephone.TabIndex = 5
        Me.lblOutputTelephone.Text = "lblOutputTelephone"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(63, 246)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(79, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "E-mail Address:"
        '
        'lblOutputExtension
        '
        Me.lblOutputExtension.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputExtension.Location = New System.Drawing.Point(156, 218)
        Me.lblOutputExtension.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblOutputExtension.Name = "lblOutputExtension"
        Me.lblOutputExtension.Size = New System.Drawing.Size(145, 15)
        Me.lblOutputExtension.TabIndex = 3
        Me.lblOutputExtension.Text = "lblOutputExtension"
        '
        'lblOutputEmail
        '
        Me.lblOutputEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputEmail.Location = New System.Drawing.Point(156, 246)
        Me.lblOutputEmail.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblOutputEmail.Name = "lblOutputEmail"
        Me.lblOutputEmail.Size = New System.Drawing.Size(145, 15)
        Me.lblOutputEmail.TabIndex = 1
        Me.lblOutputEmail.Text = "lblOutputEmail"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuSearch, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(381, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.mnuExitToolStripMenuItem})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 22)
        Me.mnuFile.Text = "File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(180, 22)
        Me.mnuOpen.Text = "Open"
        '
        'mnuExitToolStripMenuItem
        '
        Me.mnuExitToolStripMenuItem.Name = "mnuExitToolStripMenuItem"
        Me.mnuExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.mnuExitToolStripMenuItem.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRecordToolStripMenuItem})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 22)
        Me.mnuEdit.Text = "Edit"
        '
        'AddRecordToolStripMenuItem
        '
        Me.AddRecordToolStripMenuItem.Name = "AddRecordToolStripMenuItem"
        Me.AddRecordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddRecordToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddRecordToolStripMenuItem.Text = "Add Record"
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(54, 22)
        Me.mnuSearch.Text = "Search"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 22)
        Me.mnuHelp.Text = "Help"
        '
        'btnNextRecord
        '
        Me.btnNextRecord.Location = New System.Drawing.Point(219, 357)
        Me.btnNextRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(101, 40)
        Me.btnNextRecord.TabIndex = 2
        Me.btnNextRecord.Text = "Next Record"
        Me.btnNextRecord.UseVisualStyleBackColor = True
        '
        'btnPreviousRecord
        '
        Me.btnPreviousRecord.Location = New System.Drawing.Point(67, 357)
        Me.btnPreviousRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPreviousRecord.Name = "btnPreviousRecord"
        Me.btnPreviousRecord.Size = New System.Drawing.Size(101, 40)
        Me.btnPreviousRecord.TabIndex = 3
        Me.btnPreviousRecord.Text = "Previous Record"
        Me.btnPreviousRecord.UseVisualStyleBackColor = True
        '
        'frmContactInfoDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 412)
        Me.Controls.Add(Me.btnPreviousRecord)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.gboContactInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmContactInfoDisplay"
        Me.Text = "Contact Info"
        Me.gboContactInfo.ResumeLayout(False)
        Me.gboContactInfo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gboContactInfo As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents lblOutputID As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblOutputFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblOutputMiddleName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblOutputLastName As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblOutputType As Label
    Friend WithEvents lblExtension As Label
    Friend WithEvents lblOutputTelephone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblOutputExtension As Label
    Friend WithEvents lblOutputEmail As Label
    Friend WithEvents btnNextRecord As Button
    Friend WithEvents btnPreviousRecord As Button
End Class
