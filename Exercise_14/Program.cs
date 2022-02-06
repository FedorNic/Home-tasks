// Задача 14: Найти третью цифру числа или сообщить, что её нет.
Console.WriteLine("Введите число: ");
string num1 = Console.ReadLine();

int n = num1.Length;
if (n < 3) Console.WriteLine("Третьей цифры нет");
else
{
    Console.WriteLine("Третья цифра: " + num1[2]);
}