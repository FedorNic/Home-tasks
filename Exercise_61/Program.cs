// 61. Найти произведение двух матриц.
void FillPrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов = ");
int n = int.Parse(Console.ReadLine());
int[,] array1 = new int[m, n];

Console.WriteLine("Введите число строк = ");
int t = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов = ");
int l = int.Parse(Console.ReadLine());
int[,] array2 = new int[t, l];

if (n != t) Console.WriteLine("Перемножение матриц не возможно");
else
{
    Console.WriteLine();
    Console.WriteLine("Массив №1 - ");
    FillPrintArray(array1);
    Console.WriteLine("Массив №2 - ");
    FillPrintArray(array2);

    int[,] array3 = new int[m, l];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < l; j++)
        {
            for (int k = 0; k < n; k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

    Console.WriteLine("Итоговый массив - ");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < l; j++)
        {
            Console.Write(array3[i, j] + " ");
        }
        Console.WriteLine();
    }
}