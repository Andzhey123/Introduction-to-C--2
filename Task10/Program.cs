Console.WriteLine ("Программа вывода второй цифры из введенного трехзначного числа.");

Console.Write ("Введите целое, трехзначное число: ");

string? NumberString = Console.ReadLine();

int number = int.Parse (NumberString!);

int secondnumber = (number % 100) / 10;

Console.WriteLine("Вторая цифра введенного вами числа: "+secondnumber);