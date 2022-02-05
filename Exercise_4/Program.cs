// Задача 4: Найти максимальное из трёх чисел.
Console.WriteLine("Введите первое число: ");
string num1 = Console.ReadLine();
int numer1 = Convert.ToInt32(num1);
Console.WriteLine("Введите второе число: ");
string num2 = Console.ReadLine();
int numer2 = Convert.ToInt32(num2);
Console.WriteLine("Введите третье число: ");
string num3 = Console.ReadLine();
int numer3 = Convert.ToInt32(num3);
int max = numer1;
if (numer2 > max) max = numer2;
if (numer3 > max) max = numer3;
Console.Write("max = " + max);