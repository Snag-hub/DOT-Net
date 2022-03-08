Module ifElse
    Sub main()
        Dim num1 As Integer = 10
        Dim num2 As Integer = 10
        If num1 > num2 Then
            Console.WriteLine($"{num1 } is greater Than {num2 }")
        ElseIf num1 = num2 Then
            Console.WriteLine($"Both {num1}, {num2} are Equals")
        Else
            Console.WriteLine($"{num2} is greater Than {num1}")
        End If
    End Sub
End Module
