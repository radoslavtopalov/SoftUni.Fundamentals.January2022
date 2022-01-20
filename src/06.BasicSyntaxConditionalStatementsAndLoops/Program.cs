using System;

namespace _06.BasicSyntaxConditionalStatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. Ages
            //var input = int.Parse(Console.ReadLine());
            //var personKind = string.Empty;

            //if (input <= 2)
            //{
            //    personKind = "baby";
            //}
            //else if(input <= 13)
            //{
            //    personKind = "child";
            //}
            //else if (input <= 19)
            //{
            //    personKind = "teenager";
            //}
            //else if (input <= 65)
            //{
            //    personKind = "adult";
            //}
            //else
            //{
            //    personKind = "elder";
            //}

            //Console.WriteLine(personKind);

            //// 2. Divison
            //var input = int.Parse(Console.ReadLine());
            //var divisibleNumber = 0;

            //if (input % 10 == 0)
            //{
            //    divisibleNumber = 10;
            //}
            //else if (input % 7 == 0)
            //{
            //    divisibleNumber = 7;
            //}
            //else if (input % 6 == 0)
            //{
            //    divisibleNumber = 6;
            //}
            //else if (input % 3 == 0)
            //{
            //    divisibleNumber = 3;
            //}
            //else if (input % 2 == 0)
            //{
            //    divisibleNumber = 2;
            //}

            //if (divisibleNumber == 0)
            //{
            //    Console.WriteLine("Not divisible");
            //}
            //else
            //{
            //    Console.WriteLine($"The number is divisible by {divisibleNumber}");
            //}

            //// 3. Vacation
            //var numberOfPeople = int.Parse(Console.ReadLine());
            //var groupType = Console.ReadLine();
            //var dayOfTheWeek = Console.ReadLine();

            //var pricePerDay = 0.00;
            //var totalPrice = 0.00;

            //if (groupType == "Students")
            //{
            //    if (dayOfTheWeek == "Friday")
            //    {
            //        pricePerDay = 8.45;
            //    }
            //    else if (dayOfTheWeek == "Saturday")
            //    {
            //        pricePerDay = 9.80;
            //    }
            //    else if (dayOfTheWeek == "Sunday")
            //    {
            //        pricePerDay = 10.46;
            //    }

            //    if (numberOfPeople >= 30)
            //    {
            //        totalPrice = numberOfPeople * pricePerDay * 0.85;
            //    }
            //    else
            //    {
            //        totalPrice = numberOfPeople * pricePerDay;
            //    }
            //}
            //else if (groupType == "Business")
            //{
            //    if (dayOfTheWeek == "Friday")
            //    {
            //        pricePerDay = 10.90;
            //    }
            //    else if (dayOfTheWeek == "Saturday")
            //    {
            //        pricePerDay = 15.60;
            //    }
            //    else if (dayOfTheWeek == "Sunday")
            //    {
            //        pricePerDay = 16;
            //    }

            //    if (numberOfPeople >= 100)
            //    {
            //        totalPrice = (numberOfPeople - 10) * pricePerDay;
            //    }
            //    else
            //    {
            //        totalPrice = numberOfPeople * pricePerDay;
            //    }
            //}
            //else if (groupType == "Regular")
            //{
            //    if (dayOfTheWeek == "Friday")
            //    {
            //        pricePerDay = 15;
            //    }
            //    else if (dayOfTheWeek == "Saturday")
            //    {
            //        pricePerDay = 20;
            //    }
            //    else if (dayOfTheWeek == "Sunday")
            //    {
            //        pricePerDay = 22.50;
            //    }

            //    if (numberOfPeople >= 10 && numberOfPeople <= 20)
            //    {
            //        totalPrice = numberOfPeople * pricePerDay * 0.95;
            //    }
            //    else
            //    {
            //        totalPrice = numberOfPeople * pricePerDay;
            //    }
            //}

            //Console.WriteLine($"Total price: {totalPrice:F2}");

            //// 4.Print and Sum

            //var startNumber = int.Parse(Console.ReadLine());
            //var endNumber = int.Parse(Console.ReadLine());

            //var sum = 0;

            //for (var i = startNumber; i <= endNumber; i++)
            //{
            //    Console.Write(i + " ");
            //    sum += i;
            //}

            //Console.WriteLine($"\nSum: {sum}");

            //// 5. Login
            //var username = Console.ReadLine();

            //var charArr = username.ToCharArray();
            //Array.Reverse(charArr);
            //var password = new string(charArr);

            //for (int i = 0; i < 4; i++)
            //{
            //    var passInput = Console.ReadLine();
            //    if (password != passInput)
            //    {
            //        Console.WriteLine(i < 3 ? "Incorrect password. Try again." : $"User {username} blocked!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"User {username} logged in.");
            //        break;
            //    }
            //}

            //// 6. Strong Number 

            //var input = Console.ReadLine(); //541
            //long factorialSum = 0;

            //for (var i = 0; i < input.Length; i++)
            //{
            //    char currChar = input[i];
            //    var currDigit = (int) currChar - 48;
            //    long currDigitFactorial = 1;

            //    for (var j = currDigit; j > 1; j--)
            //    {
            //        currDigitFactorial *= j;
            //    }

            //    factorialSum += currDigitFactorial;
            //}

            //if (input == factorialSum.ToString())
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            // // 7. Vending Machine

            // var collectedMoney = 0.00m;
            // var amountOfPurchasedItems = 0.00m;
            // var commandInput = Console.ReadLine();

            // while (commandInput != "Start")
            // {
            //     var moneyInput = decimal.Parse(commandInput);

            //     if (moneyInput == 0.1m || moneyInput == 0.2m || moneyInput == 0.5m || moneyInput == 1m || moneyInput == 2m)
            //     {
            //         collectedMoney += moneyInput;
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Cannot accept {moneyInput}");
            //     }

            //     commandInput = Console.ReadLine();
            // }

            // commandInput = Console.ReadLine();

            // while (commandInput != "End")
            // {
            //     var itemInput = commandInput;

            //     if (itemInput == "Nuts")
            //     {
            //         amountOfPurchasedItems += 2.0m;

            //         if (amountOfPurchasedItems > collectedMoney)
            //         {
            //             amountOfPurchasedItems -= 2.0m;
            //             Console.WriteLine("Sorry, not enough money");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Purchased nuts");
            //         }
            //     }
            //     else if (itemInput == "Water")
            //     {
            //         amountOfPurchasedItems += 0.7m;

            //         if (amountOfPurchasedItems > collectedMoney)
            //         {
            //             amountOfPurchasedItems -= 0.7m;
            //             Console.WriteLine("Sorry, not enough money");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Purchased water");
            //         }
            //     }
            //     else if (itemInput == "Crisps")
            //     {
            //         amountOfPurchasedItems += 1.5m;

            //         if (amountOfPurchasedItems > collectedMoney)
            //         {
            //             amountOfPurchasedItems -= 1.5m;
            //             Console.WriteLine("Sorry, not enough money");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Purchased crisps");
            //         }
            //     }
            //     else if (itemInput == "Soda")
            //     {
            //         amountOfPurchasedItems += 0.8m;

            //         if (amountOfPurchasedItems > collectedMoney)
            //         {
            //             amountOfPurchasedItems -= 0.8m;
            //             Console.WriteLine("Sorry, not enough money");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Purchased soda");
            //         }
            //     }
            //     else if (itemInput == "Coke")
            //     {
            //         amountOfPurchasedItems += 1.0m;

            //         if (amountOfPurchasedItems > collectedMoney)
            //         {
            //             amountOfPurchasedItems -= 1.0m;
            //             Console.WriteLine("Sorry, not enough money");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Purchased coke");
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("Invalid product");
            //     }

            //     commandInput = Console.ReadLine();
            // }

            // Console.WriteLine($"Change: {Math.Abs(collectedMoney - amountOfPurchasedItems):F2}");

            //// 8. Triangle of Numbers

            //var input = int.Parse(Console.ReadLine());

            //for (var i = 0; i < input; i++)
            //{
            //    var num = i + 1;

            //    for (var j = 0; j < num; j++)
            //    {
            //        Console.Write($"{num} ");
            //    }

            //    Console.WriteLine();

            // 9. *Padawan Equipment

            var availableMoney = double.Parse(Console.ReadLine());
            var studentsCount = int.Parse(Console.ReadLine());
            var saberPrice = double.Parse(Console.ReadLine());
            var robePrice = double.Parse(Console.ReadLine());
            var beltPrice = double.Parse(Console.ReadLine());

            int freeBeltsCount = studentsCount / 6;

            var price =
                saberPrice * (Math.Round(studentsCount * 0.10, MidpointRounding.ToPositiveInfinity) + studentsCount)
                + (robePrice * studentsCount)
                + (beltPrice * (studentsCount - freeBeltsCount));

            Console.WriteLine(availableMoney >= price
                ? $"The money is enough - it would cost {price:F2}lv."
                : $"John will need {Math.Abs(availableMoney - price):F2}lv more.");
        }
    }
}