// Console.WriteLine ("Программа вывода третьей цифры из введенного числа.");

// Console.Write ("Введите целое число: ");

// string? NumberString = Console.ReadLine();

// int number = int.Parse (NumberString!);

// int thirdnumber = number % 10;

// if (thirdnumber<100)
//     Console.WriteLine("Третьей цифры нет");
// else
//     Console.WriteLine("Третья цифра введенного вами числа: "+thirdnumber);
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine ("Программа вывода третьей цифры из введенного числа.");

Console.Write ("Введите целое число: ");

string? numberString = Console.ReadLine ();

int number =  int.Parse (numberString!);

if (number < 0) 
    number = number * -1;
    
if (number > 999)
{
    while (number > 999)
    {
       number = (number / 10);
    }
}
if (number < 0)
    Console.WriteLine ("третьей цифры нет");
else
    Console.WriteLine (number % 10);