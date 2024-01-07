Console.WriteLine("Mis hinde Te saite?");

string userGrade = Console.ReadLine();

switch (userGrade)
{
    case "A":
    case "a":
        Console.WriteLine("Suurepärane!");
        break;
    case "B":
    case "b":
        Console.WriteLine("Väga hea");
        break;
    case "C":
    case "c":
        Console.WriteLine("Hea");
        break;
    case "D":
    case "d":
        Console.WriteLine("Rahuldav");
        break;
    case "E":
    case "e":
        Console.WriteLine("Kasin");
        break;
    case "F":
    case "f":
        Console.WriteLine("Puudulik");
        break;
    default: Console.WriteLine("vale väärtus");
        break;
}
