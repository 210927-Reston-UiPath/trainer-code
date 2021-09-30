Class MainMenu
    Implements IMenu
    Sub Initial() Implements IMenu.Start
        Console.WriteLine("Hello World!")
        dim repeat as Boolean = true
        Do While repeat
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("[0] Add a friend")
            Console.WriteLine("[x] Exit")
            Dim input as string = Console.ReadLine()
            Select Case input
                Case "0"
                    Console.WriteLine("Hello")
                    AddFriend()
                Case "x"
                    Console.WriteLine("Goodbye")
                    repeat = false
            End Select
        Loop
    End Sub
    Sub AddFriend()
        Console.WriteLine("Name: ")
        dim name as string = Console.ReadLine()
        Console.WriteLine("Phone Number: ")
        dim number as string = Console.ReadLine()
        dim newfriend as Contact = new Contact(name, Int32.Parse(number))
        Console.WriteLine("New Friend Created! " + newfriend.ToString())
    End Sub
    
End Class
