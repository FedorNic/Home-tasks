// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Console.WriteLine("Введите число строк = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов = ");
int n = int.Parse(Console.ReadLine());
double sum = 0;
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
    {
        sum = sum + array[i, 0];
        Console.Write(array[i, 0] + " ");
    }
sum = sum/n;
Console.WriteLine();
Console.WriteLine(sum);