Module concatencion
    Sub Main()
        Dim empresa As String
        Dim calle As String
        Dim altura As UInteger
        Dim fIncioAct As String
        Dim frase As String
        Console.WriteLine("ingrese empresa")
        empresa = Console.ReadLine()
        Console.WriteLine("ingrese calle")
        calle = Console.ReadLine()
        Console.WriteLine("ingrese altura")
        altura = Console.ReadLine()
        Console.WriteLine("ingrese fecha de inicio de actividades")
        fIncioAct = Console.ReadLine()
        frase = "Empresa:" + empresa + vbCrLf + "Calle:" + calle + vbCrLf + "Altura:" + Convert.ToString(altura) + vbCrLf + "Fecha de Inicio de Actividades: " + Convert.ToString(fIncioAct)
        Console.WriteLine(frase)
        Console.WriteLine("-------------------------------------")
        Console.Write("Empresa:" & empresa & vbCrLf & "Calle:" & calle & vbCrLf & "Altura:" & altura & vbCrLf & "Fecha de Inicio de Actividades: " & fIncioAct & vbCrLf)
    End Sub
End Module
