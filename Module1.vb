Module Module1

    Sub Main()
        Dim Choice As Integer
        Choice = 0

        Do

            Call Options()
            Console.Write("Enter your option choice:....")
            Choice = Console.ReadLine
            Select Case Choice
                Case 1 : Call Task1()
                Case 2 : Call Task2()
                Case 3 : Call Task3()
                Case 0
                Case Else
                    Console.WriteLine("Enter a valid Value!")
                    Console.ReadKey()
            End Select

        Loop Until Choice = 0

    End Sub

    Sub Task1()
        Dim MName As String
        Dim MemID As Integer
        Dim More As Char

        More = ""
        MName = ""
        MemID = 0

        FileOpen(1, "E:\VB Project\filing\MemberInfo.txt", OpenMode.Append)

        Do

            Console.Write("Enter Member Name:") : MName = Console.ReadLine
            Console.Write("Enter Member ID: ") : MemID = Console.ReadLine

            WriteLine(1, MName)
            WriteLine(1, MemID)

            Console.WriteLine("Do you want to enter more records(Y/N) ") : More = Console.ReadLine
        Loop Until UCase(More) = "N"
        FileClose(1)
    End Sub
    Sub Options()

        Console.Clear()
        Console.WriteLine("Menu to choose from:")
        Console.WriteLine("1: Enter member information.")
        Console.WriteLine("2: Show All Records.")
        Console.WriteLine("3: Search for member:")
        Console.WriteLine("0: Exit")

    End Sub
    Sub Task2()
        Dim MemName As String
        Dim MemId As Integer

        MemName = ""
        MemId = 0

        FileOpen(1, "E:\VB Project\filing\MemberInfo.txt", OpenMode.Input)

        While Not EOF(1)

            Input(1, MemName)
            Input(1, MemId)

            Console.WriteLine("Member Name: " & MemName)

            Console.WriteLine("Member ID: " & MemId)

        End While

        FileClose(1)
        Console.ReadKey()
    End Sub
    Sub Task3()
        Dim MemName, searchname As String
        Dim MemId As Integer
        Dim isfound As Boolean

        MemName = ""
        MemId = 0
        isfound = False
        Console.WriteLine("Enter member name to search for:") : searchname = Console.ReadLine

        FileOpen(1, "E:\VB Project\filing\MemberInfo.txt", OpenMode.Input)

        While Not EOF(1)

            isfound = False

            Input(1, MemName)
            Input(1, MemId)

            If MemName = searchname Then
                isfound = True
            End If

            If isfound = True Then

                Console.WriteLine("Member Name: " & MemName)
                Console.WriteLine("Member ID: " & MemId)

            End If

        End While

        If isfound = False Then
            Console.WriteLine("Record not found")
        End If

        FileClose(1)

        Console.ReadKey()
    End Sub
End Module
