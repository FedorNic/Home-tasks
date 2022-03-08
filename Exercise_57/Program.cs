// 57. Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Введите число строк = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов = ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
int save = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = n - 1; k > j; k--)
        {
            if (array[i, k - 1] < array[i, k])
            {
                save = array[i, k];
                array[i, k] = array[i, k - 1];
                array[i, k - 1] = save;
            }
        }
    }
}

Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}