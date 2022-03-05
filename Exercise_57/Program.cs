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
int min;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        min = array[i, 0];
        if (array[i, j] > min)
        {
            save = min;
            min = array[i, j];
            array[i, j] = save;

            // save = array[i, j];
            // array[i, j] = array[j, i];
            // array[j, i] = save;
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