// 63. Сформировать трёхмерный массив с не повторяющимися двузначными числами
// и вывести его на экран построчно, с индексами элементов.
Console.WriteLine("Введите число элементов по оси X = ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов по оси Y = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число элементов по оси Z = ");
int l = int.Parse(Console.ReadLine());
int[,,] array = new int[m, n, l];
int count = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < l; k++)
        {
            array[i, j, k] += 10 + count;
            Console.WriteLine($"Индекс = [ {i}, {j}, {k} ],  Число = {array[i, j, k]}");
            count += 1;
        }
    }
    Console.WriteLine();
}