Module calc_Intereses
    Sub Main()
        Dim m As Single
        Dim r As Single
        Dim t As UInteger
        Const denominador As UInteger = 360 * 100
        Dim I As Single
        Console.WriteLine("ingrese el monto invertido")
        m = Console.ReadLine()
        Console.WriteLine("ingrese el porcentaje de Interes anual")
        r = Console.ReadLine()
        Console.WriteLine("ingrese el nro de Dias")
        t = Console.ReadLine()
        I = (m * r * t) / denominador
        Console.WriteLine("el interes producido es de " & I)
        Console.WriteLine("el capital acumlado es de  " & m + I)
    End Sub
End Module
