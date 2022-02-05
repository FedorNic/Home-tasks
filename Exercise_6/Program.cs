// Задача 6: Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
string num1 = Console.ReadLine();
int numer1 = Convert.ToInt32(num1);

if (numer1 % 2 == 0) Console.WriteLine("Число четное");
else Console.WriteLine("Число НЕ четное");