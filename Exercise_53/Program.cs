// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.WriteLine("Введите число строк = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число для поиска = ");
int find = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
int count = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i ++)
{
    for (int j = 0; j < n; j ++)
    {
                if (array[i, j] == find) Console.Write($"Позиции числа – ({i},{j})  ");
                else count = count + 1;
    }
}
if (count == m*n) Console.Write($"Такого числа в массиве нет");