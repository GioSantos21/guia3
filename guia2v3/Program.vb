Imports System

Module Program
    Sub Main()
        While True
            Console.WriteLine("Elija un opci�n <1-5>: ")
            Dim desicion As Integer = Console.ReadLine()
            If desicion = 1 Then
                While True
                    Console.WriteLine("" + vbCrLf + "Ingrese un n�mero para saber si el es multiplo de 5 :")
                    Dim mul5 As Integer = Console.ReadLine()
                    If mul5 Mod 5 = 0 Then
                        Console.WriteLine("" + vbCrLf + "Su n�mero si es multiplo de 5")
                    Else
                        Console.WriteLine("" + vbCrLf + "Su n�mero no es multiplo de 5")
                    End If
                    Console.WriteLine("" + vbCrLf + "Ingrese otro n�mero para saber si el es multiplo de 3 :")
                    Dim mul3 As Integer = Console.ReadLine()
                    If mul3 Mod 3 = 0 Then
                        Console.WriteLine("" + vbCrLf + "Su n�mero si es multiplo de 3")
                    Else
                        Console.WriteLine("" + vbCrLf + "Su n�mero no es multiplo de 3")
                    End If
                End While
            ElseIf desicion = 2 Then
                Console.WriteLine("Ingrese unicamente los nombres del estudiante :")
                Dim nombres As String = Console.ReadLine()
                Console.WriteLine($"Ingrese los apellidos del estudiante {nombres} :")
                Dim apellidos As String = Console.ReadLine()
                Console.WriteLine($"Ingrese la calificaci�n final de {nombres} :")
                Dim calificacion As Double = Console.ReadLine()
                Console.WriteLine($"Ingrese la asistencia total de {nombres} :")
                Dim asistencia As Double = Console.ReadLine()
                Console.ReadLine()
                Console.WriteLine($"{nombres} {apellidos} tiene una califaci�n de {calificacion} y un asistencia de {asistencia}")
                'ElseIf desicion = 3 Then
                'ElseIf desicion = 4 Then
                'ElseIf desicion = 5 Then
            Else
                Console.WriteLine("ERROR. opci�n invalida, vuelva a intentarlo.")
            End If
        End While
    End Sub
End Module
