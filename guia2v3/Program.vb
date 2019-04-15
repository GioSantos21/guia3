Imports System

Module Program
    Sub Main()
        While True
            Console.Write("" + vbCrLf + "Si deseas salir del programa, presiona la tecla <0>" + vbCrLf + "" + vbCrLf + "1. Múltiplo de 5 y de 3." + vbCrLf + "2. Resultado de materia." + vbCrLf + "3. Consejo sobre la temperatura." + vbCrLf + "4. Ejercicio Tick-Tock." + vbCrLf + "5. Equipo y Personaje favorito." + vbCrLf + "" + vbCrLf + "Elija un opción <1-5>: ")
            Dim desicion As Integer = Console.ReadLine()
            If desicion = 1 Then
                While True
                    Console.Write("" + vbCrLf + "Ingrese un número para saber si el es multiplo de 5 :")
                    Dim mul5 As Integer = Console.ReadLine()
                    If mul5 Mod 5 = 0 Then
                        Console.WriteLine("" + vbCrLf + "Su número si es multiplo de 5")
                    Else
                        Console.WriteLine("" + vbCrLf + "Su número no es multiplo de 5")
                    End If
                    Console.Write("" + vbCrLf + "Ingrese otro número para saber si el es multiplo de 3 :")
                    Dim mul3 As Integer = Console.ReadLine()
                    If mul3 Mod 3 = 0 Then
                        Console.WriteLine("" + vbCrLf + "Su número si es multiplo de 3")
                    Else
                        Console.WriteLine("" + vbCrLf + "Su número no es multiplo de 3")
                    End If
                    Console.Write("" + vbCrLf + "¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>:")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
            ElseIf desicion = 2 Then
                While True
                    Console.Write("" + vbCrLf + "Ingrese unicamente los nombres del estudiante :")
                    Dim nombres As String = Console.ReadLine()

                    Console.Write("" + vbCrLf + $"Ingrese los apellidos del estudiante {nombres.ToUpper()} :")
                    Dim apellidos As String = Console.ReadLine()
                    Dim calificacion As Double = 0
                    Dim resultadoC As String = "NADA"
                    While True
                        Console.Write("" + vbCrLf + $"Ingrese la calificación final de {nombres.ToUpper()} :")
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
                        Console.Write("" + vbCrLf + $"Ingrese la asistencia total de {nombres.ToUpper()} :")
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
                    Console.WriteLine("" + vbCrLf + $"{nombres.ToUpper()} {apellidos.ToUpper()} tiene una califación de {calificacion} y un asistencia de %{asistencia} y  un resultado de :{resultadoT}")
                    Console.Write("" + vbCrLf + "¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>:")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
            ElseIf desicion = 3 Then
                While True
                    Console.Write("" + vbCrLf + "Ingrese la temperatura actual :")
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
                Console.WriteLine("" + vbCrLf + "Tick si es multiplo de 3, Tock si es multiplo de 7 y Tick-Tock si es multiplo de ambos" + vbCrLf + "")
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
            ElseIf desicion = 5 Then
                While True
                    Console.Write("" + vbCrLf + "MEJOR EQUIPO: " + vbCrLf + "" + vbCrLf + "1. THE AVENGERS" + vbCrLf + "2. GUERREROS Z" + vbCrLf + "3. LA LIGA DE LA JUSTICIA" + vbCrLf + "Elija una opción <1-3>: ")
                    Dim equipo As Integer = Console.ReadLine()
                    Dim equipoN As String
                    Dim personajeN As String
                    'equipo = equipo.ToUpper()
                    Dim personaje As String = "Anónimo"
                    If equipo = 1 Then
                        equipoN = "THE AVENGERS"
                        While True
                            Console.Write("" + vbCrLf + "MEJOR PERSONAJE: " + vbCrLf + "" + vbCrLf + "1. Iron man" + vbCrLf + "2. El increible hulk" + vbCrLf + "3. Thor" + vbCrLf + "Elija una opción <1-3>: ")
                            personaje = Console.ReadLine()
                            If personaje = 1 Then
                                personajeN = "IRON MAN"
                                Exit While
                            ElseIf personaje = 2 Then
                                personajeN = "EL INCREIBLE HULK"
                                Exit While
                            ElseIf personaje = 3 Then
                                personajeN = "THOR"
                                Exit While
                            Else
                                Console.WriteLine("" + vbCrLf + "ERROR. Opción fuera de rango." + vbCrLf + "")
                                Continue While
                            End If
                        End While
                        'personaje = personaje.ToUpper
                    ElseIf equipo = 2 Then
                        equipoN = "GUERREROS Z"
                        While True
                            Console.Write("" + vbCrLf + "MEJOR PERSONAJE: " + vbCrLf + "" + vbCrLf + "1. Freezer" + vbCrLf + "2. Androide 17" + vbCrLf + "3. Piccolo" + vbCrLf + "Elija una opción <1-3>: ")
                            personaje = Console.ReadLine()
                            ' personaje = personaje.ToUpper
                            If personaje = 1 Then
                                personajeN = "FREEZER"
                                Exit While
                            ElseIf personaje = 2 Then
                                personajeN = "ANDROIDE 17"
                                Exit While
                            ElseIf personaje = 3 Then
                                personajeN = "PICCOLO"
                                Exit While
                            Else
                                Console.WriteLine("" + vbCrLf + "ERROR. Opción fuera de rango." + vbCrLf + "")
                                Continue While
                            End If
                        End While
                    ElseIf equipo = 3 Then
                        equipoN = "LA LIGA DE LA JUSTICIA"
                        While True
                            Console.Write("" + vbCrLf + "MEJOR PERSONAJE: " + vbCrLf + "" + vbCrLf + "1. Linterna Verde" + vbCrLf + "2. Batman" + vbCrLf + "3. AquaMan" + vbCrLf + "Elija una opción <1-3>: ")
                            personaje = Console.ReadLine()
                            'personaje = personaje.ToUpper
                            If personaje = 1 Then
                                personajeN = "LINTERNA VERDE"
                                Exit While
                            ElseIf personaje = 2 Then
                                personajeN = "BATMAN"
                                Exit While
                            ElseIf personaje = 3 Then
                                personajeN = "AQUAMAN"
                                Exit While
                            Else
                                Console.WriteLine("" + vbCrLf + "ERROR. Opción fuera de rango." + vbCrLf + "")
                                Continue While
                            End If
                        End While
                    Else
                        Console.WriteLine("" + vbCrLf + "ERROR. Opción fuera de rango." + vbCrLf + "")
                        Continue While
                    End If
                    Console.WriteLine("" + vbCrLf + $"Tú equipo favorito es: {equipoN} y tú personaje favorito es: {personajeN}")
                    Console.Write("" + vbCrLf + "¿Quiere volver al menú principal? " + vbCrLf + "Presione la tecla <Y> para continuar, si no preciona cualquier otra letra <X>:")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Exit While
                    Else
                        Continue While
                    End If
                End While
            ElseIf desicion = 0 Then
                Exit While
            Else
                Console.WriteLine("" + vbCrLf + "ERROR. opción invalida, vuelva a intentarlo.")
            End If
        End While
    End Sub
End Module
