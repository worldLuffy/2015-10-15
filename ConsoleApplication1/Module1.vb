Module Module1

    Sub Main()
        Console.WriteLine("請使用者先打個數:")
        Dim size As Integer = Val(Console.ReadLine())
        Dim i As Integer = 0
        Dim numberarray(size - 1) As Integer

        Do
            numberarray(i) = Val(Console.ReadLine())
            i = i + 1

        Loop While (i < size)
        Console.WriteLine("最大數{0}", getmax(numberarray))
        Console.WriteLine("最小數{0}", getmin(numberarray))
        Console.ReadLine()
    End Sub


    Function getmax(ByVal ParamArray i() As Integer) As Integer
        Dim max As Integer
        max = i(0)
        For j As Integer = 1 To i.Length - 1
            If i(j) > max Then
                max = i(j)
            End If
        Next
        Return max
    End Function

    Function getmin(ByVal ParamArray i() As Integer) As Integer
        Dim min As Integer
        min = i(0)
        For j As Integer = 1 To i.Length - 1
            If i(j) < min Then
                min = i(j)
            End If
        Next
        Return min
    End Function

End Module



