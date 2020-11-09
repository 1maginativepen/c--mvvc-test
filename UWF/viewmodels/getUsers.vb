Imports System.ComponentModel
Public Class getUsers
    Implements INotifyPropertyChanged

    Private _userList As List(Of users)
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Property userList As List(Of users)
        Get
            Return _userList
        End Get
        Set
            _userList = Value
            NotifyPropertyChanged("userList")
        End Set
    End Property

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub

    Public Sub AddPersons()
        Dim myPersons As New List(Of users)
        For i = 0 To 5
            Dim p As New users With {.names = i.ToString & "name"}
            myPersons.Add(p)
        Next
        userList = myPersons
    End Sub

    Public Sub New()
        AddPersons()
    End Sub

End Class
