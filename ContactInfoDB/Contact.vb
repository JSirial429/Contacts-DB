'Please include this verbiage at the top As comments In the Main Form code behind For all submitted assignments.

'Affirmation of Authorship
'Name:Jorge Sirias
'Date : 6/30/18
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.

Public Class Contact

    Private adapter As New ContactInfoDataSetTableAdapters.EmployeesTableAdapter

    Private Shared EmployeeID As Integer = 1

    Private Shared current As Integer = -1

    Private firstName, lastName, middleName, dptmentType, Telephone, Extension, email As String

    Public ReadOnly Property items As DataTable

        Get

            Return adapter.GetData

        End Get

    End Property

    'Procedure that adds contact info to the database
    Public Sub addToDB(ByVal fName As String, mName As String, ByVal lName As String, ByVal ID As Integer, ByVal dept As String, ByVal Telephone As String,
                            ByVal ext As String, ByVal email As String)

        adapter.Insert(fName, mName, lName, ID, dept, Telephone, ext, email)

        incrementID()

    End Sub

    'procedure that increments ID number by one to help reduce duplicate primary keys
    Private Sub incrementID()

        EmployeeID = EmployeeID + 1

    End Sub

    'Function used to assign automatically employee ID to prevent primary key duplication entered by the user
    Public Function displayEmployeeID()

        Return EmployeeID.ToString()

    End Function

    Public Function nextEntry() As Integer

        'Used to rectify when a user first tries to open DB with no records but then adds records and afterwards tries opening up the records in the DB
        If current = -2 Or current = -3 Then

            current = -1

        End If

        If current < items.Rows.Count - 1 Then

            current = current + 1

        ElseIf current = items.Rows.Count - 1 Then

            current = -3

        Else

            current = -2

        End If

        Return current

    End Function

    Public Function previousEntry() As Integer

        'Once you have reached the end of the list current is set to the last index in the DB
        If current = -3 Then

            current = items.Rows.Count - 1

        End If

        If current > 0 Then

            current = current - 1

        Else

            current = -2

        End If

        Return current

    End Function

End Class
