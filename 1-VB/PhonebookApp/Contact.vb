Class Contact
    Property Name As string
    Property PhoneNumber As integer
    Public Sub New(ByVal name as string, ByVal number as integer)
        Me.Name = name
        Me.PhoneNumber = number
    End Sub
    Public Sub New()
        ' parameterless constructor
    End Sub

    Overrides Function ToString()  As string
        return $"Name: {Me.Name} Number: {Me.PhoneNumber}"        
    End Function
    
End Class
