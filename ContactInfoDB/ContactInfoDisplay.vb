'Please include this verbiage at the top As comments In the Main Form code behind For all submitted assignments.

'Affirmation of Authorship
'Name:Jorge Sirias
'Date : 6/30/18
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.
Public Class frmContactInfoDisplay

    Private newContact As New Contact

    Private Sub frmContactInfoDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Clear all labels during load time to empty string
        lblOutputID.Text = String.Empty
        lblOutputFirstName.Text = String.Empty
        lblOutputMiddleName.Text = String.Empty
        lblOutputLastName.Text = String.Empty
        lblOutputType.Text = String.Empty
        lblOutputTelephone.Text = String.Empty
        lblOutputExtension.Text = String.Empty
        lblOutputEmail.Text = String.Empty

        'Disable buttons at start up since there are no records displayed 
        btnNextRecord.Enabled = False
        btnPreviousRecord.Enabled = False

    End Sub

    Private Sub AddRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecordToolStripMenuItem.Click

        'Open Add Record form
        frmContactInfoAdd.ShowDialog()

    End Sub

    Private Sub mnuExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExitToolStripMenuItem.Click

        'Exits program
        Me.Close()

    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click

        Dim intIndex As Integer = newContact.nextEntry()

        If intIndex > -2 Then

            lblOutputID.Text = newContact.items.Rows(intIndex)("Employee_Number").ToString
            lblOutputFirstName.Text = newContact.items.Rows(intIndex)("First_Name").ToString
            lblOutputMiddleName.Text = newContact.items.Rows(intIndex)("Middle_Name").ToString
            lblOutputLastName.Text = newContact.items.Rows(intIndex)("Last_Name").ToString
            lblOutputType.Text = newContact.items.Rows(intIndex)("Department").ToString
            lblOutputTelephone.Text = newContact.items.Rows(intIndex)("Telephone").ToString
            lblOutputExtension.Text = newContact.items.Rows(intIndex)("Extension").ToString
            lblOutputEmail.Text = newContact.items.Rows(intIndex)("Email_Address").ToString

            'Enable button for record navigation
            btnNextRecord.Enabled = True
            btnPreviousRecord.Enabled = True

        ElseIf intIndex = -2 Or intIndex = -3 Then

            MessageBox.Show("The are no records in the database to show.", "No records found")

            ''Disable buttons
            'btnNextRecord.Enabled = False
            'btnPreviousRecord.Enabled = False

        End If
    End Sub

    Private Sub btnPreviousRecord_Click(sender As Object, e As EventArgs) Handles btnPreviousRecord.Click

        Dim intIndex As Integer = newContact.previousEntry()

        If intIndex <> -2 Then

            lblOutputID.Text = newContact.items.Rows(intIndex)("Employee_Number").ToString
            lblOutputFirstName.Text = newContact.items.Rows(intIndex)("First_Name").ToString
            lblOutputMiddleName.Text = newContact.items.Rows(intIndex)("Middle_Name").ToString
            lblOutputLastName.Text = newContact.items.Rows(intIndex)("Last_Name").ToString
            lblOutputType.Text = newContact.items.Rows(intIndex)("Department").ToString
            lblOutputTelephone.Text = newContact.items.Rows(intIndex)("Telephone").ToString
            lblOutputExtension.Text = newContact.items.Rows(intIndex)("Extension").ToString
            lblOutputEmail.Text = newContact.items.Rows(intIndex)("Email_Address").ToString

        Else

            MessageBox.Show("There are no more records to show", "Error")

            btnPreviousRecord.Enabled = False
            btnNextRecord.Enabled = True

        End If

    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click

        Dim intIndex As Integer = newContact.nextEntry()

        If intIndex > -2 Then

            lblOutputID.Text = newContact.items.Rows(intIndex)("Employee_Number").ToString
            lblOutputFirstName.Text = newContact.items.Rows(intIndex)("First_Name").ToString
            lblOutputMiddleName.Text = newContact.items.Rows(intIndex)("Middle_Name").ToString
            lblOutputLastName.Text = newContact.items.Rows(intIndex)("Last_Name").ToString
            lblOutputType.Text = newContact.items.Rows(intIndex)("Department").ToString
            lblOutputTelephone.Text = newContact.items.Rows(intIndex)("Telephone").ToString
            lblOutputExtension.Text = newContact.items.Rows(intIndex)("Extension").ToString
            lblOutputEmail.Text = newContact.items.Rows(intIndex)("Email_Address").ToString

        ElseIf intIndex = -2 Or intIndex = -3 Then

            MessageBox.Show("You have reached the end of the list", "Error")

            btnNextRecord.Enabled = False

        End If
    End Sub
End Class
