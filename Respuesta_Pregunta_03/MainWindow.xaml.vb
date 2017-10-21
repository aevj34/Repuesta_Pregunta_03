Class MainWindow 


    Private Sub btnTest_Click(sender As Object, e As RoutedEventArgs)

        Try
            Dim numbers() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}

            If hasDuplicateValues(numbers) Then
                MsgBox("Si tiene duplicados")
            Else
                MsgBox("No tiene duplicados")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Function hasDuplicateValues(numbers() As Integer)

        If numbers.Count > numbers.Distinct.Count Then
            Return True
        Else
            Return False
        End If

    End Function


    'Versión Anterior
    'Public Function hasDuplicateValues(numbers() As Integer)

    '    Dim steps As Long = 0

    '    For i As Integer = 0 To numbers.Length - 1

    '        For j As Integer = 0 To numbers.Length - 1

    '            steps = steps + 1
    '            If i <> j And numbers(i) = numbers(j) Then
    '                Return True
    '            End If

    '        Next j

    '    Next i

    '    MsgBox(steps & " steps")

    '    Return False

    'End Function


End Class
