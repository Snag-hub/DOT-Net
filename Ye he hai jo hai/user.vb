Module user

    Function findMax(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim result As Integer
        If (num1 > num2) Then
            result = num1
        Else
            result = num2
        End If
        findMax = result

    End Function
    Sub main()
        Dim num1, num2, result As Integer
        num1 = 50
        num2 = 100
        result = findMax(num1, num2)
        Console.WriteLine($"Values are: {num1} {num2}")
        Console.WriteLine("Max Value: {0}", result)
        Console.ReadKey()


    End Sub
End Module
