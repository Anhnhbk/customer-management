Imports System.ComponentModel

Public Class CustomerViewModel
    Implements INotifyPropertyChanged
    ' Properties for customer data
    Public Property CustomerName As String
    Public Property Address As String
    Public Property Phone As String
    Public Property Email As String
    Public Property Gender As String
    ' Add logic for Add, Update, Delete, Search here
    ' Raise PropertyChanged event for data binding
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
