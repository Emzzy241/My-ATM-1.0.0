// APPLICATION AIMS:
/*
* Checking whether An Input --such as an ATM card(debit/credit card number) -- is recorded correctly
* Verifying the user by asking for a PIN
* In case of negative verification, logging out the user
* In case of positive verification, showing multiple options, including cash availability, the previous five transactions made, and cash withdrawal
* Giving the user the ability to withdraw up to $1000 worth of cash in one transaction, with total transactions limited to ten per day.

For a more complicated Program include the ability to register a new PIN and mobile Number, a detailed Bank statement, and a "fast" cash withdrawal system for quickly withdrawing $20, $50, $100


*/






using System;
using System.Collections.Generic;

class MyAtm
{
    static void Main()
    {
        Console.WriteLine("Welcome To the ATM APP; THis App is currently being built and this is not the final Product");

        // for adding line spaces in code seen on git bash Terminal
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("So here is a brief info on how this Application works");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("First, you as a user input your Credit card or Debit Card into our Application. NOTE: its a 10 digit Number for Credit cards and its a 15 digit number for Debit cards");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Then you will be Prompted to enter in your PIN. NOTE: Every PIN is 4 digits both for Debit and Credit Cards");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("After user input's a wrong PIN three times, The Account will be Temporarily Down Until the Real User is available");
        Console.WriteLine("All Users can apply for a Forgot Password where they will be given an hint on their Password ONLY");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Having said all of that, Please Input 'Y' if you fully understood or input 'N' to come again with the Instructions");

        // as you can see here, I useed the .TOUpper() method straight on the value I got from my user instead of having to do it later where I would be writing in more code

        string userAnswer = Console.ReadLine().ToUpper();

        // running a switch case statement to determine if user understands or not
        // why I used "Y" in my case statement nstead of 'Y'("Y" is a string and 'Y' is a character); My code is unaware of what me user would input, and that is why It needs to be a string instead of a character.... This is basically to avoid my Application from breaking

        switch (userAnswer)
        {
            case "Y":
                Console.WriteLine("Great, now its time to input the 10 digits of your Credit card or 15 digits of your Debit Card... And again we still need to Determine if its a Credit Card or a Debit Card");
                Console.WriteLine();
                Console.WriteLine();

                // capturing whether me user uses a debit or a credit card

                Console.WriteLine("Please Input a 'C' for a credit Card and a 'D' for a debit card");
                string usersCard = Console.ReadLine().ToUpper();


                // having another switch case statement inside this case statement
                switch (usersCard)
                {
                    case "C":
                        Console.WriteLine("You have just indicated that you would be using a Credit card");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Please input the 10 digits of your Credit card");

                        // Another string variable to take the 10 digit for me User's credit card
                        string userCreditCardString = Console.ReadLine();

                        // I want to use this string to determine if I was given a 10 digit value by me user before I convert it to a double
                        // the .Length Property counts the strng for me and gives me how many chaacters exist in a string

                        int checkUserCreditCardStringDigitIsTen = userCreditCardString.Length;

                        switch (checkUserCreditCardStringDigitIsTen)
                        {
                            case 10:
                                // Immediately My users digit is 10; I know its a Credit card and I also need to change it into a double right away
                                // double userCreditCardNumber = double.Parse(userCreditCardString);

                                // Now I have a 10 digit Number for my Users Credit Card

                                Console.WriteLine("You have successfully inputted a valid Credit card");
                                Console.WriteLine("Please input your 4 digit PIN");

                                string userPinInString = Console.ReadLine();

                                int checkUserPinIsFourDigit = userPinInString.Length;

                                switch (checkUserPinIsFourDigit)
                                {
                                    case 4:
                                        Console.WriteLine("Yay! You have just Inputted in the right Pin");
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Welcome User, What would you like to do today?");
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        // due to App not having a deatabase, Users can only withdraw and deposit for now
                                        Console.WriteLine("Enter 'W' for Withdrawal, Enter 'D' to Deposit.");
                                        string userActivity = Console.ReadLine().ToUpper();

                                        // Now if my user's Pin is a 4 digit, they can use Me ATM Application now

                                        switch (userActivity)
                                        {
                                            case "W":
                                                Console.WriteLine("How Much would you Like to Withdraw today?");
                                                string userWithdrawal = Console.ReadLine();

                                                Console.WriteLine("You have successfully Withdrawn $" + userWithdrawal + ".Thank you very much :) ");

                                                break;

                                            case "D":
                                                Console.WriteLine("How Much would you Like to Deposit today?");
                                                string userDeposit = Console.ReadLine();

                                                Console.WriteLine("You have successfully Deposited $" + userDeposit + ".Thank you very much :) ");

                                                break;
                                        }


                                        break;

                                    default:
                                        break;
                                }

                                break;
                               
                                default: 
                                    // running the Main() method again if user enters a credit card digit thats either more than 10 or less than 10
                                    Main();
                                break;
                        }

                        // using a double datatype and converting the string to store me users 10 digit credit card
                        // double userCreditCardNumber = double.Parse(userCreditCardString);

                        // determining whether I was given a 10 digit value so I can proceed with the next step of my application

                        break;


                    default:

                        break;
                }

                break;

            default:
                // running the Main() method if user enters another value apart from "Y" it can be either an "N" or any other thing
                Main();

                break;

        }
    }
}