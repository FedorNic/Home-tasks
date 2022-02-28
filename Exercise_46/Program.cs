// 46. Написать программу масштабирования фигуры
Console.WriteLine("Сколько точек нужно ввести?");
int num = Convert.ToInt32(Console.ReadLine());
int k = 2;
for (int i = 0; i < num; i++)
{
    Console.WriteLine("Введите x = ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите y = ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Координаты точки - (" + x + "," + y + ")");
    Console.WriteLine("Координаты точки масштабированной с коэффициентом 2 - (" + x*k + "," + y*k + ")");
}