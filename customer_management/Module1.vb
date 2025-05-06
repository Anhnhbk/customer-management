Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text
Module Module1
    Public sql As String
    Public dml As OdbcCommand
    Public dr As OdbcDataReader
    Public connection As OdbcConnection
    Public Sub connect_db()
        If connection Is Nothing Then
            connection = New OdbcConnection("DSN=db_customer;")
        End If
        'connection = New OdbcConnection("DSN=db_customer;")
        'If connection.State = ConnectionState.Closed Then
        '    connection.Open()
        'End If
    End Sub

    ' Hash password using MD5
    Public Function HashPassword(ByVal str As String) As String
        Dim md5 As MD5 = MD5.Create()
        Dim inputBytes As Byte() = Encoding.ASCII.GetBytes(str)
        Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)

        Dim sb As New StringBuilder()
        For i As Integer = 0 To hashBytes.Length - 1
            sb.Append(hashBytes(i).ToString("x2"))
        Next

        Return sb.ToString()
    End Function

    Public Enum FormState
        Adding
        Editing
        Searching
    End Enum
    ' Declare a variable to hold the current state of the form
    'Public currentState As FormState

    'Public Sub UpdateUI(currentState)
    '    Select Case currentState
    '        Case FormState.Searching
    '            Customer.btnSearch.Enabled = True
    '            Customer.btnSave.Enabled = False
    '            Customer.btnDelete.Enabled = True
    '            Customer.btnClear.Enabled = True
    '            Customer.btnExit.Enabled = True
    '            Customer.txtCustomerName.Enabled = True
    '            Customer.txtCustomerName.Enabled = True
    '            Customer.txtAddress.Enabled = True
    '            Customer.txtPhone.Enabled = True
    '            Customer.txtEmail.Enabled = True
    '            Customer.comboGender.Enabled = True
    '            Customer.customerView.Enabled = True

    '        Case FormState.Adding
    '            Customer.btnSearch.Enabled = False
    '            Customer.btnSave.Enabled = True
    '            Customer.btnDelete.Enabled = False
    '            Customer.btnClear.Enabled = True
    '            Customer.btnExit.Enabled = True
    '            Customer.txtCustomerName.Enabled = True
    '            Customer.txtCustomerName.Enabled = True
    '            Customer.txtAddress.Enabled = True
    '            Customer.txtPhone.Enabled = True
    '            Customer.txtEmail.Enabled = True
    '            Customer.comboGender.Enabled = True
    '            Customer.customerView.Enabled = False

    '        Case FormState.Editing
    '            Customer.btnSearch.Enabled = True
    '            Customer.btnSave.Enabled = True
    '            Customer.btnDelete.Enabled = True
    '            Customer.btnClear.Enabled = True
    '            Customer.btnExit.Enabled = True
    '            Customer.txtCustomerName.Enabled = True
    '            Customer.txtCustomerName.Enabled = True
    '            Customer.txtAddress.Enabled = True
    '            Customer.txtPhone.Enabled = True
    '            Customer.txtEmail.Enabled = True
    '            Customer.comboGender.Enabled = True
    '    End Select
    'End Sub

End Module
