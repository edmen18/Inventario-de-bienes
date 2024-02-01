Public Class C_Funcionario
    Private _codEmp As String
    Private _nomEmp As String
    Private _codOfi As String

    Public Property CodOfi() As String
        Get
            Return _codOfi
        End Get
        Set(ByVal value As String)
            _codOfi = value
        End Set
    End Property

    Public Property NomEmp() As String
        Get
            Return _nomEmp
        End Get
        Set(ByVal value As String)
            _nomEmp = value
        End Set
    End Property


    Public Property CodEmp() As String
        Get
            Return _codEmp
        End Get
        Set(ByVal value As String)
            _codEmp = value
        End Set
    End Property

End Class
