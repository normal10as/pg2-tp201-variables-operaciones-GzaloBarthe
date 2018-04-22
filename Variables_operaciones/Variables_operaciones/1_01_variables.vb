Module variables
    Public nombre As String
    Friend tipoDocumento As String
    Friend nroDocumento As UInteger
    Public localidad As String
    Public fechaNacimiento As Date
    Public altura As Decimal
    Public eCivil As String
    Public argentino As Boolean

    Sub Main()
        Dim Edad As Byte
        nombre = "Pedro Lamota"
        tipoDocumento = "DNI"
        nroDocumento = 20300400
        localidad = "Rio Tercero"
        fechaNacimiento = "12/10/69"
        altura = 1.73
        eCivil = "soltero"
        argentino = True
        Edad = 48
        Console.WriteLine("nombre: " & nombre & vbCrLf & "documento: " & tipoDocumento & " " & nroDocumento & vbCrLf & "localidad: " & localidad & vbCrLf & "F.Nacimiento:" & fechaNacimiento & vbCrLf & "edad: " & Edad & vbCrLf & "altura: " & altura & vbCrLf & "estado civil: " & eCivil)
        Console.ReadKey()

    End Sub

End Module