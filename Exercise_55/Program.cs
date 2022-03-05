// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Console.WriteLine("Введите число строк = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов = ");
int n = int.Parse(Console.ReadLine());
double result = 0;
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
    result = 0;
    for (int j = 0; j < m; j++)
    {
        result = result + array[j, i];
    }
    result = result / m;
    Console.WriteLine();
    Console.WriteLine($"Среднеарифметическое {i+1} столбца = {Math.Round(result,2)}");
    //Просто хочу потренироваться с округлением
}