// 30. Покажите кубы чисел, заканчивающихся на чётную цифру.
Console.WriteLine("Введите число N: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
Console.WriteLine();
Console.Write("Кубы четных чисел от 0 до N =" + "\t" + 0 + "\t"); // Для уменьшения операций в цикле
int count = 2;
while (count <= num)
{
    if (count % 2 == 0)
    {
        Console.Write(count*count*count + "\t");
    }
count++;
}
