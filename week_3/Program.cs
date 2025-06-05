// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("What is your favorite season. Type 0 for Spring, 1 for Summer, 2 for Fall and 3 for Winter");

int userInput = Convert.ToInt16(Console.ReadLine());

switch (userInput)
{
    case (int)Seasons.SUMMER:
        Console.WriteLine("Wow! I love summer too!");
        break;
    case (int)Seasons.SPRING:
        Console.WriteLine("Spring is also my favorite");
        break;
    case (int)Seasons.WINTER:
        Console.WriteLine("Winter is my least favorite");
        break;
    case (int)Seasons.FALL:
        Console.WriteLine("The falling leaves are so pretty");
        break;
    default:
        Console.WriteLine("What was that season? I didn't catch it");
        break;
}

