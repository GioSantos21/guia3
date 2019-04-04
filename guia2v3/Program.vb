Imports System

Module Program
    Sub Main()
        While True
            Console.WriteLine("" + vbCrLf + "Elija un opci�n <1-5>: ")
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
                    Console.WriteLine("" + vbCrLf + "�Quiere volver al men� principal? " + vbCrLf + "Presione la tecla <Y> para continuar, de lo contrario presione la tecla <N>:")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    ElseIf sigo = "n" Or sigo = "N" Then
                        Continue While
                    Else
                        Console.WriteLine("" + vbCrLf + "ERROR. Letra invalida, vuelvalo a intentar.")
                    End If
                End While
            ElseIf desicion = 2 Then
                Console.WriteLine("" + vbCrLf + "Ingrese unicamente los nombres del estudiante :")
                Dim nombres As String = Console.ReadLine()
                Console.WriteLine("" + vbCrLf + $"Ingrese los apellidos del estudiante {nombres} :")
                Dim apellidos As String = Console.ReadLine()
                Dim calificacion As Double = 0
                Dim resultadoC As String = "NADA"
                While True
                    Console.WriteLine("" + vbCrLf + $"Ingrese la calificaci�n final de {nombres} :")
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
                        Console.WriteLine("" + vbCrLf + "ERROR. Dato no valido, ingrese una calificaci�n entre <0-10>")
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
                Console.WriteLine("" + vbCrLf + $"{nombres} {apellidos} tiene una califaci�n de {calificacion} y un asistencia de %{asistencia} y  un resultado de :{resultadoT}")
                'ElseIf desicion = 3 Then
                'ElseIf desicion = 4 Then
                'ElseIf desicion = 5 Then
            Else
                Console.WriteLine("" + vbCrLf + "ERROR. opci�n invalida, vuelva a intentarlo.")
            End If
        End While
    End Sub
End Module
