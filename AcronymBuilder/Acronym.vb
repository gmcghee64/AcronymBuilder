
Public Class Acronym
    Private _Acronym As String
    Private _Definition As String

    Public Property Acronym As String
        Get
            Return _Acronym
        End Get
        Set(value As String)
            _Acronym = value
        End Set
    End Property

    Public Property Definition As String
        Get
            Return _Definition
        End Get
        Set(value As String)
            _Definition = value
        End Set
    End Property
End Class
