Module v_absoluto
    Sub Main()
        Dim b As Boolean = False
        Dim x As Integer
        Dim c As ULong
        Dim r As Single
        Console.WriteLine("Ingrese un numero")
        x = Console.ReadLine()
        If x < 0 Then
            x = x - x * 2
            b = True
        End If
        Console.WriteLine("el valor absoluto es " & x)
        r = x ^ (1 / 2)
        If b Then
            Console.WriteLine("el numero ingresado no posee raiz real, no obstante la raiz de su valor absoluto es " & r)
        Else
            Console.WriteLine("el numero ingresado posee raiz real esta es " & r)
        End If
        c = x ^ 10
        Console.WriteLine("El resultado de elevarlo a la decima potencia es  " & c)
    End Sub

End Module
