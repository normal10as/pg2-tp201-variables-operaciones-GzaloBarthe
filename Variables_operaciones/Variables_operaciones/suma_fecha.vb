Module suma_fecha
    Sub main()
        Dim fecha2 As Date
        Dim dia As Byte
        Dim mes As Byte
        Dim anio As Integer
        Dim sumar As Integer
        Console.WriteLine("Ingrese un nro de dia:")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese un nro de mes:")
        mes = Console.ReadLine()
        Console.WriteLine("Ingrese un año ")
        anio = Console.ReadLine()
        Dim fecha1 As New DateTime(anio, mes, dia)
        Console.Write("la fecha ingresada es: " & fecha1 & vbCrLf)
        Console.WriteLine("--------------------")
        Console.WriteLine("Ahora ingrese los dias que desea sumar a esa fecha")
        sumar = Console.ReadLine()
        fecha2 = fecha1.AddDays(sumar)
        Console.Write("la nueva fecha es: " & fecha2 & vbCrLf)

    End Sub
End Module
