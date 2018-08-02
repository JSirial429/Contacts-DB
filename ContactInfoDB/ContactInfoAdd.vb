'Please include this verbiage at the top As comments In the Main Form code behind For all submitted assignments.

'Affirmation of Authorship
'Name:Jorge Sirias
'Date : 6/30/18
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.
Public Class frmContactInfoAdd

    Private newContact As New Contact

    Private Sub frmContactInfoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboType.Items.Clear()

        'Adding type values to combo box
        With cboType

            .Items.Add("Advising")
            .Items.Add("Customer Service")
            .Items.Add("R and D")
            .Items.Add("Parking")
            .Items.Add("Accounting")

        End With

        'Clear string value in label
        lblEmployeeID.Text = String.Empty

        'Display first assigned employee ID
        lblEmployeeID.Text = newContact.displayEmployeeID()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Hide()

        'frmContactInfoDisplay.btnNextRecord.Enabled = True

    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click

        'Calling class method to add new contact to dataset
        newContact.addToDB(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, lblEmployeeID.Text, cboType.Text, txtTelephone.Text, txtExtension.Text, txtEmail.Text)

        MessageBox.Show("Contact successfully added!", "Success")

        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        cboType.SelectedIndex = -1
        txtTelephone.Clear()
        txtEmail.Clear()
        txtExtension.Clear()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        cboType.SelectedIndex = -1
        txtTelephone.Clear()
        txtEmail.Clear()
        txtExtension.Clear()

    End Sub

    Private Sub frmContactInfoAdd_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        'Display next assigned employee ID
        lblEmployeeID.Text = newContact.displayEmployeeID()

    End Sub
End Class