'Calvin Coxen
'RCET0265
'Fall 2020
'Say My Name
'https://github.com/CalvinAC/SayMyName/blob/master/SayMyName.vb

Module SayMyName

    Sub Main()

        'Function used to set the users input as a variable
        Dim userNameInput As String

        'Text greeting the user and prompting them to input their name
        Console.WriteLine("Hello, and welcome to jurassic park")
        Console.ReadLine()
        Console.WriteLine("Please enter your name")

        'Text repyling to the user with their name printed
        userNameInput = Console.ReadLine()
        Console.WriteLine("You entered: " + userNameInput)
        Console.WriteLine("Enjoy your stay, " + userNameInput)
        Console.ReadLine()

    End Sub

End Module
