// Задача 8: Показать чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
string num1 = Console.ReadLine();
int numer1 = Convert.ToInt32(num1);
Console.WriteLine();
for (int c = 2; c <= numer1; c = c + 2)
    if (c % 2 == 0)
        Console.WriteLine(c);