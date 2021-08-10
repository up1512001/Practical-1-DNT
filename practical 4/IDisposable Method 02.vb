Module IDisposable_Method_02
    Public Class Rec
        Implements IDisposable
        Private len, wid As Integer

        Public Sub New(ByVal a As Integer, ByVal b As Integer)
            len = a
            wid = b
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Console.WriteLine("Disposing rec values...")
            len = 0
            wid = 0
            'GC.SuppressFinalize(Me)
            'Console.ReadLine()
        End Sub


        Public Sub area()
            Console.WriteLine("Area of {0} length and {1} width is {2}", len, wid, len * wid)
        End Sub
        Protected Overrides Sub Finalize()
            Console.WriteLine("Finalize method executed...")
            Console.ReadLine()
        End Sub
    End Class

    Sub Main()
        Dim o1 As Rec = New Rec(15, 12)
        o1.area()
        o1.Dispose()
        o1.area()
        'GC.Collect()
        'Console.ReadLine()
    End Sub
End Module
