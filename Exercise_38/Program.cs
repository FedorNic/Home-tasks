// 38. Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
int[] one = new int[10];
int sum = 0;
for (int poz = 0; poz < one.Length; poz++)
{
    one[poz] = new Random().Next(0, 6);
    Console.Write(one[poz] + "\t");

    if (poz % 2 != 0)
    {
        sum = sum + one[poz];
    }
}
Console.Write("\nСумма чисел на нечетной позиции = " + sum);