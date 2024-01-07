
Console.WriteLine("Mis hinde Te saite?");

char userGrade = char.Parse(Console.ReadLine());

if (userGrade == 'A')
{
    Console.WriteLine("Suurepärane!");
}
else if (userGrade == 'B')
{
    Console.WriteLine("Väga hea");
}
else if (userGrade == 'C')
{
    Console.WriteLine("Hea");
}
else if (userGrade == 'D')
{
    Console.WriteLine("Rahuldav");
}
else if (userGrade == 'B')
{
    Console.WriteLine("Kasin");
}
else if (userGrade == 'F')
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.WriteLine("Vale väärtus");
}