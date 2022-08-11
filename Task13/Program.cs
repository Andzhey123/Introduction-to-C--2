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