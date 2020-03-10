Module Module1

    Sub Main()
        Dim c, a, b As Integer
        Randomize()
        For c = 1 To 20
            For a = 1 To 33
                For b = 1 To 100
                    If a + c + b = 100 And 5 * c + 3 * a + 1 / 3 * b = 100 Then
                        Console.Write("公雞" & c & " " & "母雞" & a & " " & "小雞" & b)
                        Console.Read()
                    End If
                Next
            Next
        Next

        If a + c + b = 100 Then

        End If


    End Sub

End Module
