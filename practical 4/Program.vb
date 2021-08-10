Imports System

Module Program

    Class DemoOverload
        Public Overloads Sub Add(ByVal a As Integer, ByVal b As Integer)
            Console.WriteLine("Adding Integers :-> {0} + {1} = {2}", a, b, a + b)
            'Console.ReadLine()
        End Sub
        Public Overloads Sub Add(ByVal a As String, ByVal b As String)
            Console.WriteLine("Adding Strings :-> {0}+ {1} = {2}", a, b, a + b)
            Console.ReadLine()
        End Sub
    End Class
    Class DemoOverride
        Public Overridable Sub Talk()
            Console.WriteLine("DemoOverride Is Talking...")
            'Console.ReadLine()
        End Sub
    End Class

    Class ImplementDemo
        Inherits DemoOverride
        Public Overrides Sub Talk()
            Console.WriteLine("ImplementDemo Is Talking...")
            MyBase.Talk()
            Console.ReadLine()
        End Sub
    End Class

    Sub Main(args As String())

        Dim o1 As DemoOverride
        o1 = New DemoOverride
        Dim o2 As New ImplementDemo
        o1.Talk()
        o2.Talk()

        Dim o3 As New DemoOverload
        o3.Add(15, 23)
        o3.Add("Utsav ", "Patel")

    End Sub
End Module
