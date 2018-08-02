<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContactInfoAdd
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
        Me.components = New System.ComponentModel.Container()
        Me.gboAddContactInfo = New System.Windows.Forms.GroupBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lbInputlID = New System.Windows.Forms.Label()
        Me.lbInputlFirstName = New System.Windows.Forms.Label()
        Me.lblInputMiddleName = New System.Windows.Forms.Label()
        Me.lblInputLastName = New System.Windows.Forms.Label()
        Me.lbInputlType = New System.Windows.Forms.Label()
        Me.lblInputTelephone = New System.Windows.Forms.Label()
        Me.lblInputExtension = New System.Windows.Forms.Label()
        Me.lbInputlEmail = New System.Windows.Forms.Label()
        Me.btnSaveRecord = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ContactInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.gboAddContactInfo.SuspendLayout()
        CType(Me.ContactInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboAddContactInfo
        '
        Me.gboAddContactInfo.Controls.Add(Me.lblEmployeeID)
        Me.gboAddContactInfo.Controls.Add(Me.cboType)
        Me.gboAddContactInfo.Controls.Add(Me.txtFirstName)
        Me.gboAddContactInfo.Controls.Add(Me.txtMiddleName)
        Me.gboAddContactInfo.Controls.Add(Me.txtLastName)
        Me.gboAddContactInfo.Controls.Add(Me.txtTelephone)
        Me.gboAddContactInfo.Controls.Add(Me.txtExtension)
        Me.gboAddContactInfo.Controls.Add(Me.txtEmail)
        Me.gboAddContactInfo.Controls.Add(Me.lbInputlID)
        Me.gboAddContactInfo.Controls.Add(Me.lbInputlFirstName)
        Me.gboAddContactInfo.Controls.Add(Me.lblInputMiddleName)
        Me.gboAddContactInfo.Controls.Add(Me.lblInputLastName)
        Me.gboAddContactInfo.Controls.Add(Me.lbInputlType)
        Me.gboAddContactInfo.Controls.Add(Me.lblInputTelephone)
        Me.gboAddContactInfo.Controls.Add(Me.lblInputExtension)
        Me.gboAddContactInfo.Controls.Add(Me.lbInputlEmail)
        Me.gboAddContactInfo.Location = New System.Drawing.Point(23, 22)
        Me.gboAddContactInfo.Margin = New System.Windows.Forms.Padding(17, 16, 17, 16)
        Me.gboAddContactInfo.Name = "gboAddContactInfo"
        Me.gboAddContactInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.gboAddContactInfo.Size = New System.Drawing.Size(336, 291)
        Me.gboAddContactInfo.TabIndex = 0
        Me.gboAddContactInfo.TabStop = False
        Me.gboAddContactInfo.Text = "Enter Contact Info"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(142, 153)
        Me.cboType.Margin = New System.Windows.Forms.Padding(2)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(147, 21)
        Me.cboType.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(142, 69)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(147, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(142, 97)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(147, 20)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(142, 125)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(147, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(142, 179)
        Me.txtTelephone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(147, 20)
        Me.txtTelephone.TabIndex = 5
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(142, 207)
        Me.txtExtension.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(147, 20)
        Me.txtExtension.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(142, 237)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(147, 20)
        Me.txtEmail.TabIndex = 7
        '
        'lbInputlID
        '
        Me.lbInputlID.AutoSize = True
        Me.lbInputlID.Location = New System.Drawing.Point(109, 41)
        Me.lbInputlID.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lbInputlID.Name = "lbInputlID"
        Me.lbInputlID.Size = New System.Drawing.Size(21, 13)
        Me.lbInputlID.TabIndex = 25
        Me.lbInputlID.Text = "ID:"
        '
        'lbInputlFirstName
        '
        Me.lbInputlFirstName.AutoSize = True
        Me.lbInputlFirstName.Location = New System.Drawing.Point(69, 71)
        Me.lbInputlFirstName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lbInputlFirstName.Name = "lbInputlFirstName"
        Me.lbInputlFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lbInputlFirstName.TabIndex = 24
        Me.lbInputlFirstName.Text = "First Name:"
        '
        'lblInputMiddleName
        '
        Me.lblInputMiddleName.AutoSize = True
        Me.lblInputMiddleName.Location = New System.Drawing.Point(59, 97)
        Me.lblInputMiddleName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblInputMiddleName.Name = "lblInputMiddleName"
        Me.lblInputMiddleName.Size = New System.Drawing.Size(72, 13)
        Me.lblInputMiddleName.TabIndex = 23
        Me.lblInputMiddleName.Text = "Middle Name:"
        '
        'lblInputLastName
        '
        Me.lblInputLastName.AutoSize = True
        Me.lblInputLastName.Location = New System.Drawing.Point(69, 127)
        Me.lblInputLastName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblInputLastName.Name = "lblInputLastName"
        Me.lblInputLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblInputLastName.TabIndex = 22
        Me.lblInputLastName.Text = "Last Name:"
        '
        'lbInputlType
        '
        Me.lbInputlType.AutoSize = True
        Me.lbInputlType.Location = New System.Drawing.Point(97, 153)
        Me.lbInputlType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lbInputlType.Name = "lbInputlType"
        Me.lbInputlType.Size = New System.Drawing.Size(34, 13)
        Me.lbInputlType.TabIndex = 21
        Me.lbInputlType.Text = "Type:"
        '
        'lblInputTelephone
        '
        Me.lblInputTelephone.AutoSize = True
        Me.lblInputTelephone.Location = New System.Drawing.Point(70, 183)
        Me.lblInputTelephone.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblInputTelephone.Name = "lblInputTelephone"
        Me.lblInputTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblInputTelephone.TabIndex = 20
        Me.lblInputTelephone.Text = "Telephone:"
        '
        'lblInputExtension
        '
        Me.lblInputExtension.AutoSize = True
        Me.lblInputExtension.Location = New System.Drawing.Point(76, 209)
        Me.lblInputExtension.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblInputExtension.Name = "lblInputExtension"
        Me.lblInputExtension.Size = New System.Drawing.Size(56, 13)
        Me.lblInputExtension.TabIndex = 19
        Me.lblInputExtension.Text = "Extension:"
        '
        'lbInputlEmail
        '
        Me.lbInputlEmail.AutoSize = True
        Me.lbInputlEmail.Location = New System.Drawing.Point(49, 237)
        Me.lbInputlEmail.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lbInputlEmail.Name = "lbInputlEmail"
        Me.lbInputlEmail.Size = New System.Drawing.Size(79, 13)
        Me.lbInputlEmail.TabIndex = 18
        Me.lbInputlEmail.Text = "E-mail Address:"
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.Location = New System.Drawing.Point(23, 344)
        Me.btnSaveRecord.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(101, 40)
        Me.btnSaveRecord.TabIndex = 8
        Me.btnSaveRecord.Text = "Save Record"
        Me.btnSaveRecord.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(141, 344)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 40)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(259, 344)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 40)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.Location = New System.Drawing.Point(142, 40)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(147, 23)
        Me.lblEmployeeID.TabIndex = 26
        Me.lblEmployeeID.Text = "lblEmployeeID"
        '
        'frmContactInfoAdd
        '
        Me.AcceptButton = Me.btnSaveRecord
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(381, 412)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveRecord)
        Me.Controls.Add(Me.gboAddContactInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmContactInfoAdd"
        Me.Text = "Add New Contact Record"
        Me.gboAddContactInfo.ResumeLayout(False)
        Me.gboAddContactInfo.PerformLayout()
        CType(Me.ContactInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gboAddContactInfo As GroupBox
    Friend WithEvents lbInputlID As Label
    Friend WithEvents lbInputlFirstName As Label
    Friend WithEvents lblInputMiddleName As Label
    Friend WithEvents lblInputLastName As Label
    Friend WithEvents lbInputlType As Label
    Friend WithEvents lblInputTelephone As Label
    Friend WithEvents lblInputExtension As Label
    Friend WithEvents lbInputlEmail As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSaveRecord As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents ContactInfoBindingSource As BindingSource
    Friend WithEvents lblEmployeeID As Label
End Class
