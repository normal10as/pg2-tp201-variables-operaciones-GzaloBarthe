Module _1_12_math
    Sub main()
        Dim nro As Single
        Dim defecto As Single
        Dim exceso As Single
        Dim redondeo As Integer
        Console.WriteLine("ingrese un nro")
        nro = Console.ReadLine()
        defecto = Math.Floor(nro)
        exceso = Math.Ceiling(nro)
        redondeo = Math.Round(nro)
        Console.WriteLine("por defecto: " & defecto)
        Console.WriteLine("por exceso: " & exceso)
        Console.WriteLine("redondeo: " & redondeo)

    End Sub



End Module
