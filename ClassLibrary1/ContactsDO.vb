﻿'Please include this verbiage at the top As comments In the Main Form code behind For all submitted assignments.

'Affirmation of Authorship
'Name:Jorge Sirias
'Date : 6/30/18
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.

Public Class ContactsDO

    Private adapter As New ContactInfoDataSetTableAdapters.EmployeesTableAdapter

    Public ReadOnly Property items As DataTable

        Get

            Return adapter.GetData

        End Get

    End Property

End Class
