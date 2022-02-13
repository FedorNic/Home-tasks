// Задача 20: Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти (1-4): ");
string num1 = Console.ReadLine();
int numer1 = Convert.ToInt32(num1);
if (numer1==1) Console.WriteLine("Диапазон координат: х > 0, y > 0");
else if (numer1==2) Console.WriteLine("Диапазон координат: х < 0, y > 0");
else if (numer1==3) Console.WriteLine("Диапазон координат: х < 0, y < 0");
else if (numer1==4) Console.WriteLine("Диапазон координат: х > 0, y < 0");
else
{
    Console.WriteLine("Неправильно введен номер четверти =)");
}