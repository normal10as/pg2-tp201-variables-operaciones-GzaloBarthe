Module semanas
    Sub Main()
        Const dias_sema As Byte = 7
        Const dias_anio As UInteger = 365
        Const dias_lab As Byte = 5
        Dim dias_lab_anio As UInteger
        Dim sem_anio As Byte
        dias_lab_anio = (dias_anio / dias_sema) * dias_lab
        sem_anio = dias_anio / dias_sema
        Console.WriteLine("")
        Console.WriteLine("Semana del año = " & sem_anio)
        Console.WriteLine("Dias laborales = " & dias_lab_anio)
    End Sub
End Module
