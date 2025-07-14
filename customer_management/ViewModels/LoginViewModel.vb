Imports System.ComponentModel

Public Class LoginViewModel
    Implements INotifyPropertyChanged
    ' Properties for login data
    Public Property Username As String
    Public Property Password As String
    Public Property UserRoleId As Integer
    ' Add logic for login authentication here
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
