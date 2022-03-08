// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.WriteLine("Введите число строк и столбцов = ");
int m = int.Parse(Console.ReadLine());
int sum = 0;
int min = m * 6; //Рандом до 6
int result = 0;
int[,] array = new int[m, m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 7);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum = sum + array[i, j];
    }
    if (min > sum)
    {
        min = sum;
        result = i;
    }
    sum = 0;
}
Console.WriteLine($"Строка с наименьшей суммой элементов = {(result + 1)}");

//По условию нужно выдать номер строки (от 1 до m), а не индекс.