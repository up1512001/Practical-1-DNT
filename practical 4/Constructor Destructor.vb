Module Constructor_Destructor

    Class ConDes
        Private myName As String
        Public Sub New(ByVal name As String)
            myName = name
            Console.WriteLine("Object is initialized... {0}", myName)
        End Sub

        Protected Overrides Sub Finalize()
            Console.WriteLine("Last Use of {0}", myName)
            myName = ""
            Console.WriteLine("Object is destroid...myName Value = {0}", myName)
            Console.ReadLine()
        End Sub
    End Class

    Public Sub CreateObject()
        Dim o1 As ConDes = New ConDes("Utsav")
    End Sub

    Sub Main(args As String())
        CreateObject()
        GC.Collect()
        'Console.ReadLine()
    End Sub
End Module
