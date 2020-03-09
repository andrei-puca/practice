using System;
using System.Collections.Generic;
using System.Collections;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            var users = new List<User>();
            users.Add(new User { username = "John", pin = "1234", balance = 100, surname = "ion", name = "faranume", phone = "0722993322" });
            users.Add(new User { username = "Kevin", pin = "4321", balance = 200, surname = "john", name = "kevinache", phone = "0799123123" });

            //var pinCode = "1234";
            var selectedPin = string.Empty;
            var userIsLogged = false;
            string enteredUsername;
            var userfound = false;
            var mainMenu = false;
        mainMenu:
            while(!mainMenu) 
            {
                var wrongPin = 0;
                Console.WriteLine("Login ---> 1");
                Console.WriteLine("Exit ---> 0");
                var input = Console.ReadLine();

                if(input == "0")
                {
                    Console.WriteLine("Bye");
                    return;
                }
                while (input == "1")
                {
                    if (input == "1" && !userIsLogged)
                    {
                        Console.WriteLine("Please insert your username:");
                        enteredUsername = Console.ReadLine();
                        foreach (var user in users)
                        {

                            if (user.username == enteredUsername)
                            {
                                userfound = true;
                                var goBack = false;
                                Console.WriteLine("\nPlease specify your pincode:");
                                selectedPin = Console.ReadLine();
                                    if (wrongPin == 3)
                                    {
                                        Console.WriteLine("You are banned from this ATM, muhahahahahaah ");
                                        return;
                                    }
                                    if (user.pin == selectedPin)
                                    {
                                        pageAfterLogin:
                                        if (userfound)
                                        {
                                            userIsLogged = true;
                                            Console.WriteLine($"\nHello, {user.username} ......");
                                            Console.WriteLine($"You have available the following amount: {user.balance}");
                                        } 
                                        Console.WriteLine("\nIf you want to print out the user information ---> ENTER 1");
                                        Console.WriteLine("Logout ---> ENTER 2");
                                        Console.WriteLine("Exit ---> ENTER 3");
                                        var option = Console.ReadLine();
                                        if (option == "1")
                                        {
                                            Console.WriteLine($"\nSurname: {user.surname}");
                                            Console.WriteLine($"\nName: {user.name}");
                                            Console.WriteLine($"\nPhone: {user.phone}");
                                            Console.WriteLine("------------------------------------");
                                            Console.WriteLine("RETURN ---> ENTER 1");
                                            var back = Console.ReadLine();

                                            if (back == "1")
                                            {
                                                goto pageAfterLogin;
                                            }
                                            
                                        }
                                        else if (option == "2")
                                        {
                                            userIsLogged = false;
                                            goBack = true;
                                            Console.WriteLine("Logged out\n");
                                            goto mainMenu;
                                        }
                                        else if (option == "3")
                                        {
                                            break;
                                        }
                                    }
                                    else if (selectedPin != user.pin)
                                    {
                                        wrongPin++;
                                        Console.WriteLine($"\nYour pin is incorrect, number of retries left: {3 - wrongPin}");
                                    }
                                
                            }
                        }
                    }
                    else if (input != "1" && !userIsLogged)
                    {
                        Console.WriteLine("Wrong choice, please enter another option");
                        input = Console.ReadLine();
                    }
                }
            }
                Console.WriteLine("Application its closing now, see yah....");
                return;
        }
    }
}