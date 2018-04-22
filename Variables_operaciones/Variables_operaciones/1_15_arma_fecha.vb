Module arma_fecha
    Sub main()
        Dim dia As Byte
        Dim Hora As Byte
        Console.WriteLine("ingrese un nro de dia (1-31)")
        dia = Console.ReadLine()
        Console.WriteLine("ingrese un nro de hora (00-23)")
        Hora = Console.ReadLine()
        Dim fecha As New DateTime(Now.Year, Now.Month, dia, Hora, Now.Minute, Now.Second)
        Console.WriteLine("la fecha es: " & fecha)

    End Sub

End Module
