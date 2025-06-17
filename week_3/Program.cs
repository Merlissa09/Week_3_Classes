// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Console.WriteLine("Hello, World!");

// Console.WriteLine("What is your favorite season. Type 0 for Spring, 1 for Summer, 2 for Fall and 3 for Winter");

// int userInput = Convert.ToInt16(Console.ReadLine());

// switch (userInput)
// {
//     case (int)Seasons.SUMMER:
//         Console.WriteLine("Wow! I love summer too!");
//         break;
//     case (int)Seasons.SPRING:
//         Console.WriteLine("Spring is also my favorite");
//         break;
//     case (int)Seasons.WINTER:
//         Console.WriteLine("Winter is my least favorite");
//         break;
//     case (int)Seasons.FALL:
//         Console.WriteLine("The falling leaves are so pretty");
//         break;
//     default:
//         Console.WriteLine("What was that season? I didn't catch it");
//         break;
// }


// Seasons season = Seasons.SPRING;
// Seasons season1 = Seasons.FALL;

// Console.WriteLine("The season: " + season);
// Console.WriteLine("The season1: " + season1);

Car audi = new(CarMake.AUDI, "R8");
audi.Drive(32);
audi.setModel("Soul");
Console.WriteLine("The model after setting soul " + audi.getModel());
Car nissan = new(CarMake.NISSAN, "Altima");
nissan.Drive(50, 10);
audi.Drive(50, 5);

Car ford = new(CarMake.FORD, "F150");
ford.Drive(20);

Console.WriteLine("Current ford mileage is: " + ford.Odometer);

Car honda = ford;
honda.Drive(32);
Console.WriteLine("Current ford mileage is: " + ford.Odometer);
Console.WriteLine("Current honda mileage is: " + honda.Odometer);

Console.WriteLine("The total car count " + Car.TotalCarCount);
Console.WriteLine(Math.Floor(45.73));
Console.WriteLine("The vin for the ford is: " + ford.VIN);

int value1 = 5;
int value2 = value1;
value2 += 20;

Console.WriteLine(nissan.getModel());