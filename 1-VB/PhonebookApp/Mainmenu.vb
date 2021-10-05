Imports System.IO
Imports System.Text.Json
Class MainMenu
    Implements IMenu
    dim friends as List(of Contact) = new List(of Contact)
    dim filename as string = "friends.json"
    dim jsonstring as string = ""
    Public Sub Initial() Implements IMenu.Start
        Console.WriteLine("Hello World!")
        dim repeat as Boolean = true
        Do While repeat
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("[0] Add a friend")
            Console.WriteLine("[1] Show all friends")
            Console.WriteLine("[x] Exit")
            Dim input as string = Console.ReadLine()
            Select Case input
                Case "0"
                    Console.WriteLine("Hello")
                    AddFriend()
                Case "1"
                    ShowFriends()
                Case "x"
                    Console.WriteLine("Goodbye")
                    repeat = false
            End Select
        Loop
    End Sub
    Private Sub AddFriend()
        Console.WriteLine("Name: ")
        dim name as string = Console.ReadLine()
        Console.WriteLine("Phone Number: ")
        dim number as string = Console.ReadLine()
        dim newfriend as Contact = new Contact(name, Int32.Parse(number))
        AddFriend2File(newfriend)
        Console.WriteLine("New Friend Created! " + newfriend.ToString())
    End Sub
    Private Sub ShowFriends()
        Console.WriteLine("Friend list plus contact info")
        For Each person As Contact In GetContactsFromFile()
            Console.WriteLine(person.ToString())
        Next
    End Sub
    Private Sub AddFriend2File(ByVal person as Contact)
        dim existingContacts as List(of Contact) = GetContactsFromFile()
        existingContacts.Add(person)
        jsonstring = JsonSerializer.Serialize(existingContacts)
        File.WriteAllText(filename, jsonstring)
    End Sub
    Private Function GetContactsFromFile() As List(of Contact)
        Try
            jsonString = File.ReadAllText(filename)
            return JsonSerializer.Deserialize(of List(of Contact))(jsonstring)
        Catch ex As Exception
            return new List(of Contact)
        End Try
        
    End Function
    
End Class
