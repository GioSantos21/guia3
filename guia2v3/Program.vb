Imports System

Module Program
    Sub Main()
        While True
            Console.WriteLine("" + vbCrLf + "Elija un opción <1-5>: ")
            Dim desicion As Integer = Console.ReadLine()
            If desicion = 1 Then
                While True
                    Console.WriteLine("" + vbCrLf + "Ingrese un número para saber si el es multiplo de 5 :")
                    Dim mul5 As Integer = Console.ReadLine()
                    If mul5 Mod 5 = 0 Then
                        Console.WriteLine("" + vbCrLf + "Su número si es multiplo de 5")
                    Else
                        Console.WriteLine("" + vbCrLf + "Su número no es multiplo de 5")
                    End If
                    Console.WriteLine("" + vbCrLf + "Ingrese otro número para saber si el es multiplo de 3 :")
                    Dim mul3 As Integer = Console.ReadLine()
                    If mul3 Mod 3 = 0 Then
                        Console.WriteLine("" + vbCrLf + "Su número si es multiplo de 3")
                    Else
                        Console.WriteLine("" + vbCrLf + "Su número no es multiplo de 3")
                    End If
                    Console.WriteLine("" + vbCrLf + "¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>:")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
            ElseIf desicion = 2 Then
                While True
                    Console.WriteLine("" + vbCrLf + "Ingrese unicamente los nombres del estudiante :")
                Dim nombres As String = Console.ReadLine()
                Console.WriteLine("" + vbCrLf + $"Ingrese los apellidos del estudiante {nombres} :")
                Dim apellidos As String = Console.ReadLine()
                Dim calificacion As Double = 0
                Dim resultadoC As String = "NADA"
                While True
                    Console.WriteLine("" + vbCrLf + $"Ingrese la calificación final de {nombres} :")
                    calificacion = Console.ReadLine()
                    If calificacion >= 0 And calificacion <= 10 Then
                        If calificacion < 5 Then
                            resultadoC = "REPROBADO"
                        ElseIf calificacion >= 5 And calificacion <= 5.9 Then
                            resultadoC = "COMPLEMENTARIO"
                        ElseIf calificacion >= 6 Then
                            resultadoC = "APROBADO"
                        End If
                        Exit While
                    ElseIf calificacion < 0 Or calificacion > 10 Then
                        Console.WriteLine("" + vbCrLf + "ERROR. Dato no valido, ingrese una calificación entre <0-10>")
                    End If
                End While
                Dim asistencia As Double = 0
                Dim resultadoAs As String = "NADA"
                While True
                    Console.WriteLine("" + vbCrLf + $"Ingrese la asistencia total de {nombres} :")
                    asistencia = Console.ReadLine()
                    If asistencia >= 0 And asistencia <= 100 Then
                        If asistencia < 75 Then
                            resultadoAs = "REPROBADO"
                        ElseIf asistencia >= 75 Then
                            resultadoAs = "APROBADO"
                        End If
                        Exit While
                    ElseIf asistencia < 0 Or asistencia > 100 Then
                        Console.WriteLine("" + vbCrLf + "ERROR. Dato no valido, ingrese una asistencia entre <0-100>")
                    End If
                End While
                Dim resultadoT As String = resultadoC
                If resultadoC = "COMPLEMENTARIO" And resultadoAs = "REPROBADO" Then
                    resultadoT = "REPROBADO"
                ElseIf resultadoC = "APROBADO" And resultadoAs = "REPROBADO" Then
                    resultadoT = "REPROBADO"
                End If
                Console.WriteLine("" + vbCrLf + $"{nombres} {apellidos} tiene una califación de {calificacion} y un asistencia de %{asistencia} y  un resultado de :{resultadoT}")
                Console.WriteLine("" + vbCrLf + "¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>:")
                Dim sigo As String = Console.ReadLine()
                If sigo = "y" Or sigo = "Y" Then
                    Exit While
                Else
                    Continue While
                End If
                End While
        ElseIf desicion = 3 Then
                While True
                    Console.WriteLine("" + vbCrLf + "Ingrese la temperatura actual :")
                    Dim temperatura As Integer = Console.ReadLine()
                    Select Case temperatura
                        Case <= 0
                            Console.WriteLine("" + vbCrLf + "El clima esta FRIO, es hora de ponerte un abrigo.")
                        Case 1 To 20
                            Console.WriteLine("" + vbCrLf + "El clima esta CALIDO, no hay de que preocuparte.")
                        Case 21 To 40
                            Console.WriteLine("" + vbCrLf + "El clima esta CALUROSO, ¿Por qué no compras un helado?")
                        Case >= 41
                            Console.WriteLine("" + vbCrLf + "El clima esta ARDIENTE, Alista el coche y vete a la playa.")
                    End Select
                    Console.WriteLine("" + vbCrLf + "¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>:")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
            ElseIf desicion = 4 Then
                Console.WriteLine()
                For i = 1 To 100
                    If i Mod 3 = 0 And i Mod 7 = 0 Then
                        Console.Write("Tic-Tock, ")
                    ElseIf i Mod 3 = 0 Then
                        Console.Write("Tick, ")
                    ElseIf i Mod 7 = 0 Then
                        Console.Write("Tock, ")
                    Else
                        Console.Write($"{i}, ")
                    End If
                Next
                Console.WriteLine()
                'ElseIf desicion = 5 Then
            Else
                Console.WriteLine("" + vbCrLf + "ERROR. opción invalida, vuelva a intentarlo.")
            End If
        End While
    End Sub
End Module
