//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int number;

Console.WriteLine("Введите число:");
while (! int.TryParse(Console.ReadLine(), out number))
{
    System.Console.WriteLine("Введите корректное значение:");
}

int n = 0;
int number1 = number;

if (number >= 100)
{
    while (number1 >= 10)
    {
        number1 = number1 / 10;
        n++;
    }

    int index = 0;
    int[] array = new int[n];

    while (number > 10)
    {
        array[index] = number % 10;
        index++;
        number = number / 10;
    }
    
    System.Console.WriteLine(array[n - 2]);
}

else
{
    Console.WriteLine("третьей цифры нет");
}