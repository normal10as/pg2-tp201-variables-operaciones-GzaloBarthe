Module numeraciones
    Enum Dias_semana
        domingo = 0
        lunes = 1
        martes = 2
        miercoles = 3
        jueves = 4
        viernes = 5
        sabado = 6
    End Enum

    Sub main()
        Dim nombres_de_dias(7) As String
        Dim diaSem As String
        Dim fecha2 As Date
        Dim dia As Byte
        Dim mes As Byte
        Dim anio As Integer
        Dim sumar As Integer
        nombres_de_dias = [Enum].GetNames(GetType(Dias_semana))

        Console.WriteLine("Ingrese un nro de dia:")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese un nro de mes:")
        mes = Console.ReadLine()
        Console.WriteLine("Ingrese un año ")
        anio = Console.ReadLine()
        Dim fecha1 As New DateTime(anio, mes, dia)
        Console.Write("la fecha ingresada es: " & fecha1 & vbCrLf)
        diaSem = nombres_de_dias(fecha1.DayOfWeek)
        Console.WriteLine("el dia es: " & diaSem)
        Console.WriteLine("--------------------")
        Console.WriteLine("Ahora ingrese los dias que desea sumar a esa fecha")
        sumar = Console.ReadLine()
        fecha2 = fecha1.AddDays(sumar)
        Console.Write("la nueva fecha es: " & fecha2 & vbCrLf)
        diaSem = nombres_de_dias(fecha2.DayOfWeek)
        Console.WriteLine("el dia es: " & diaSem)

    End Sub

End Module
