
Console.WriteLine ("Программа програма проверки на выходной день по цифре обозначающей день недели");

Console.Write ("Введите целую цифру: ");

string? numberString = Console.ReadLine ();

int number =  int.Parse (numberString!);

if (number == 6 || number == 7)
    Console.Write ("Сегодня выходной день.");

else if (number < 1 || number >7)
{
    Console.WriteLine ("Введенная цифра не обозначает день недели");
}
else 
    Console.Write ("Сегодня будний день.");