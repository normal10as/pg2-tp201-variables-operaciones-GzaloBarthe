Module tablas_verdad
    Sub Main()
        Console.WriteLine("---------AND---------" & vbCrLf & " V  |  V  |   V   " & vbCrLf & " V  |  F  |   F  " & vbCrLf & " F  |  V  |   F   " & vbCrLf & " F  |  F  |   F  ")
        Console.WriteLine("---------OR----------" & vbCrLf & " V  |  V  |   V   " & vbCrLf & " V  |  F  |   V  " & vbCrLf & " F  |  V  |   V   " & vbCrLf & " F  |  F  |   F  ")
        Console.WriteLine("---------NOT---------" & vbCrLf & "    |  V  |  F  |  " & vbCrLf & "    |  F  |  V  |")
        Console.WriteLine("---------Xor---------" & vbCrLf & " V  |  V  |   F   " & vbCrLf & " V  |  F  |   V  " & vbCrLf & " F  |  V  |   V   " & vbCrLf & " F  |  F  |   F  ")
    End Sub

End Module
