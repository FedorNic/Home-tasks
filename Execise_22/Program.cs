// Задача 22: Найти расстояние между точками в пространстве 2D/3D
double find(int first, int second)
{
    int result = (second - first) * (second - first);
    return result;
}
int x1 = -4, x2 = 2, y1 = 1, y2 = -2, z1 = 1, z2 = 2;
double sum2D = find(x1, x2) + find(y1, y2);
double sum3D = find(x1, x2) + find(y1, y2) + find(z1, z2);
Console.WriteLine("Расстояние между точками в 2D пространстве = " + Math.Sqrt(sum2D));
// Можно и не высчитывать через Math.Sqrt - записать (√ + "sum2D")
Console.WriteLine("Расстояние между точками в 3D пространстве = " + Math.Sqrt(sum3D));
// Можно и не высчитывать через Math.Sqrt - записать (√ + "sum3D")