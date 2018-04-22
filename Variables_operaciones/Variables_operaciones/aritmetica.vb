Module aritmetica
    Sub Main()
        Dim entero1 As Int32
        Dim entero2 As Int32
        Dim decimal1 As Single
        Dim decimal2 As Single
        entero1 = 5
        entero2 = 3
        decimal2 = 2.2
        decimal1 = 1.4
        Console.WriteLine("-----------------------------" & vbCrLf & "primer entero = " & entero1 & vbCrLf & "Segundo entero =" & entero2)
        Console.WriteLine("primer flotante = " & decimal1 & vbCrLf & "Segundo flotante =" & decimal2 & vbCrLf & "-----------------------------")
        Console.WriteLine("sumar entero con entero")
        Console.WriteLine(entero1 + entero2)
        Console.WriteLine("restar entero con entero")
        Console.WriteLine(entero1 - entero2)
        Console.WriteLine("multiplicar entero con entero")
        Console.WriteLine(entero1 * entero2)
        Console.WriteLine("dividir entero con entero")
        Console.WriteLine(entero1 / entero2)
        Console.WriteLine("sumar flotante con entero")
        Console.WriteLine(entero2 + decimal1)
        Console.WriteLine("restar flotante con entero")
        Console.WriteLine(decimal1 - entero2)
        Console.WriteLine("multiplicar flotante con entero")
        Console.WriteLine(decimal1 * entero2)
        Console.WriteLine("dividir flotante con entero")
        Console.WriteLine(decimal1 / entero2)
        Console.WriteLine("sumar flotante con flotante")
        Console.WriteLine(decimal1 + decimal2)
        Console.WriteLine("restar flotante con flotante")
        Console.WriteLine(decimal1 - decimal2)
        Console.WriteLine("multiplicar flotante con flotante")
        Console.WriteLine(decimal1 * decimal2)
        Console.WriteLine("dividir flotante con flotante")
        Console.WriteLine(decimal1 / decimal2)
    End Sub
End Module
