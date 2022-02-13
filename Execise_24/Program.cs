// Задача 24: Найти кубы чисел от 1 до N
Console.WriteLine("Введите число N: ");
string num1 = Console.ReadLine();
int numer1 = Convert.ToInt32(num1);
Console.WriteLine();
int c = 1;
while (c <= numer1)
{
    Console.Write(c + "\t");
    Console.WriteLine(c * c * c);
    c++;
}