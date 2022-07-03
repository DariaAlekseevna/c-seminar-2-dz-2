// принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
// 7 -> да
// 1 -> нет

int day;

Console.WriteLine("Введите цифру, обозначающую день недели:");

while (!int.TryParse(Console.ReadLine(), out day))
{
    System.Console.WriteLine("Введите корректное значение");
}

while (day > 7 || day < 1)
{
    Console.WriteLine("Введите корректное значение:");
    while (!int.TryParse(Console.ReadLine(), out day))
    {
        System.Console.WriteLine("Введите корректное значение");
    }
}

if (day > 5)
{
    System.Console.WriteLine("да, выходной день");
}
else
{
    System.Console.WriteLine("нет, рабочий день");
}
