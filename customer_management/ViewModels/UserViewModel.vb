Imports System.ComponentModel

Public Class UserViewModel
    Implements INotifyPropertyChanged
    ' Properties for user data
    Public Property UserName As String
    Public Property Email As String
    Public Property RoleId As Integer
    ' Add logic for Add, Update, Delete, Search user here
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
