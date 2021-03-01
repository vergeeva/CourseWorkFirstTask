Public Class Product
    Private Name As String
    Private Price As Double
    Private Count As Integer
    Public Sub New(Name As String, Price As Double, Count As Integer)
        Me.Name = Name
        Me.Price = Price
        Me.Count = Count
    End Sub
    Public Sub New(Obj As Product)
        Name = Obj.Name
        Price = Obj.Price
        Count = Obj.Count
    End Sub
    Public Property Get_Name() As String
        Get
            Return Name
        End Get
        Set(Value As String)
            Name = Value
        End Set
    End Property

    Public Property Get_Count() As Integer
        Get
            Return Count
        End Get
        Set(Value As Integer)
            Count = Value
        End Set
    End Property
    Public Property Get_Price() As String
        Get
            Return Price
        End Get
        Set(Value As String)
            Price = Value
        End Set
    End Property

    Public Shadows Function ToString() As String
        Dim Line As String
        Line = Name + "; Цена: " + Convert.ToString(Price) + "; Кол-во: " + Convert.ToString(Count)
        Return Line
    End Function
End Class

Public Class MyPredicate
    Private Name As String
    Private Price As Double
    Public Sub New(Value As Product)
        Name = Value.Get_Name
        Price = Value.Get_Price
    End Sub

    Public Function IsProduct(Value As Product) As Boolean
        Return Name = Value.Get_Name And Price = Value.Get_Price
    End Function
End Class

