Module mayor
    Dim A As Integer
    Dim B As Integer
    Dim C As Integer
    Dim mayorcito As Integer
    Sub main()
        Console.writeline("Ingrese un nro...")
        A = Console.ReadLine()
        Console.writeline("Ingrese otro nro...")
        B = Console.ReadLine()
        Console.writeline("Ingrese otro nro...")
        C = Console.ReadLine()
        mayorcito = Math.Max(A, B)
        mayorcito = Math.Max(mayorcito, C)
        Console.Writeline("el mayor nro ingresado es: " & mayorcito)
    End Sub

End Module
