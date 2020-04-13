using System;
using System.Collections.Generic;
using System.Collections;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var validation = new Validation();
            var users = new List<User>();
            users.Add(new User { username = "John", pin = "1234", balance = 200, surname = "ion", name = "faranume", phone = "0722993322" });
            users.Add(new User { username = "Kevin", pin = "4321", balance = 1000, surname = "john", name = "kevinache", phone = "0799123123" });
            users.Add(new User { username = "Mark", pin = "4321", balance = 300, surname = "john", name = "kevinache", phone = "0799123123" });
            users.Add(new User { username = "Iosif", pin = "4321", balance = 800, surname = "john", name = "kevinache", phone = "0799123123" });
            users.Add(new User { username = "Henry", pin = "4321", balance = 250, surname = "john", name = "kevinache", phone = "0799123123" });
            users.Add(new User { username = "Yan", pin = "4321", balance = 600, surname = "john", name = "kevinache", phone = "0799123123" });
            users.Add(new User { username = "Ming", pin = "4321", balance = 500, surname = "john", name = "kevinache", phone = "0799123123" });
            users.Add(new User { username = "Marius", pin = "4321", balance = 50, surname = "john", name = "kevinache", phone = "0799123123" });
            users.Add(new User { username = "Martin", pin = "4321", balance = 2500, surname = "john", name = "kevinache", phone = "0799123123" });
            users.Add(new User { username = "Ionut", pin = "4321", balance = 500, surname = "john", name = "kevinache", phone = "0799123123" });
            users.Add(new User { username = "Adrian", pin = "4321", balance = 300, surname = "john", name = "kevinache", phone = "0799123123" });


           



            var minimumNumberToFind = users[0].balance;
            var maximumNumberToFind = users[0].balance;
            var sum = 0;
            var totalAmount = 0;
            var whoIsThis = string.Empty;
            var userCounter = 0;
            var arithmeticMean = 0;
            var depositValue = 0;
            var withdrawValue = 0;

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
                            if (validation.pinAttempts(wrongPin))
                            {
                                input = "0";
                                mainMenu = true;
                                break;
                            }

                            if (user.username == enteredUsername)
                            {
                                userfound = true;
                                Console.WriteLine("\nPlease specify your pincode:");
                                selectedPin = Console.ReadLine();
                                      
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
                                        Console.WriteLine("See the minimum balance of your users ---> ENTER 2");
                                        Console.WriteLine("See the maximum balance of your users ---> ENTER 3");
                                        Console.WriteLine("Calculate the arithmetic mean ---> ENTER 4");
                                        Console.WriteLine("Withdraw ---> ENTER 5");
                                        Console.WriteLine("Deposit ---> ENTER 6");
                                        Console.WriteLine("Logout ---> ENTER 7");
                                        Console.WriteLine("Exit ---> ENTER 8");

                                        var option = Console.ReadLine();
                                        if (option == "1")
                                        {
                                            printMenu:
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
                                            else
                                            {
                                                goto printMenu;   
                                            }
                                            
                                        }
                                        else if (option == "2")
                                        {
                                            foreach (var maxBalance in users)
                                            {


                                                if (maxBalance.balance <= minimumNumberToFind)
                                                {
                                                    minimumNumberToFind = maxBalance.balance;
                                                    whoIsThis = maxBalance.username;
                                                }
                                            }
                                        Console.WriteLine($"The minimum balance in you system is: {minimumNumberToFind} in {whoIsThis}'s account");
                                        Console.WriteLine("------------------------------------------");
                                        goto pageAfterLogin;
                                        
                                        }
                                        else if (option == "3")
                                        {
                                            foreach (var maxBalance in users)
                                            {

                                                totalAmount = maxBalance.balance + sum;
                                                if (maxBalance.balance >= maximumNumberToFind)
                                                {
                                                    maximumNumberToFind = maxBalance.balance;
                                                    whoIsThis = maxBalance.username;
                                                }
                                            }
                                            Console.WriteLine($"The maximum balance in you system is: {maximumNumberToFind} in {whoIsThis}'s account");
                                            Console.WriteLine("------------------------------------------");
                                            goto pageAfterLogin;

                                        
                                        }
                                       
                                        else if(option == "4")
                                        {
                                            foreach (var balance in users)
                                            {
                                                userCounter++;
                                                arithmeticMean = arithmeticMean + balance.balance;
                                            }
                                            arithmeticMean = arithmeticMean / userCounter;
                                        Console.WriteLine($"The arithmetic mean is: {arithmeticMean}");
                                        goto pageAfterLogin;
                                        }

                                        else if(option == "7")
                                        {
                                            userIsLogged = false;

                                            Console.WriteLine("Logged out\n");
                                            goto mainMenu;

                                        }
                                        else if(option == "8")
                                        {
                                            input = "0";
                                            mainMenu = true;
                                            break;
                                        }
                                        else if(option == "6")
                                        {
                                            Console.WriteLine("Introduce the amount");
                                            depositValue = Convert.ToInt32(Console.ReadLine());
                                           
                                            user.balance = user.balance + depositValue;

                                        goto pageAfterLogin;
                                        }   
                                        else if(option == "5")
                                        {
                                        withdrawmenu:
                                            Console.WriteLine("Introduce the amount");
                                            withdrawValue = Convert.ToInt32(Console.ReadLine());
                                        if ((user.balance - withdrawValue) < 0)
                                        {
                                            Console.WriteLine("You dont have sufficient funds");
                                            goto withdrawmenu;
                                        }
                                        else
                                        {
                                            user.balance = user.balance - withdrawValue;
                                            goto pageAfterLogin;
                                        }
                                        }

                                        else
                                        {
                                            goto pageAfterLogin;
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