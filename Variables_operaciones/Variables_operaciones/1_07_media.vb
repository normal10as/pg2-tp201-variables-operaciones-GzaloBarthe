Module Media
    Sub Main()
        Dim A As Integer
        Dim B As Integer
        Dim C As Integer
        Dim D As Integer
        Dim sum As Single
        Console.WriteLine("Ingrese un Nro")
        A = Console.ReadLine()
        Console.WriteLine("Ingrese otro Nro")
        B = Console.ReadLine()
        Console.WriteLine("Ingrese otro Nro")
        C = Console.ReadLine()
        Console.WriteLine("Ingrese otro Nro")
        D = Console.ReadLine()
        sum = A + B + C + D
        Console.WriteLine("la sumatoria de los nros ingresados es: " & sum)
        Console.WriteLine("la media de los nros ingresados es: " & (sum / 4))
    End Sub
End Module
