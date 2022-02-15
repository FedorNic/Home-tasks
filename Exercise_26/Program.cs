// 26. Возведите число А в натуральную степень B, используя цикл.
Console.WriteLine("Введите число A: ");
string a = Console.ReadLine();
int A = Convert.ToInt32(a);
Console.WriteLine("Введите число B: ");
string b = Console.ReadLine();
int B = Convert.ToInt32(b);
int count = 1;
int result = 1;
while (count <= B)
{
    result = result * A;
    count++;
}
Console.WriteLine("Число А в степени В = " + result);