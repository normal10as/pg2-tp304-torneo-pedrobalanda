Public Class Equipos

    Public _nombre As String

    Public Sub New(Nombre As String)
        Me.Nombre = Nombre

    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

End Class
