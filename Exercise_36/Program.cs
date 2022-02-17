// 36. Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечётных/чётных чисел.
int[] mass = new int[8];
int chot = 0, nechot = 0;
for (int count = 0; count < mass.Length; count++)
{
    mass[count] = new Random().Next(100, 999);
    Console.Write(mass[count] + "\t");
    if (mass[count] % 2 == 0)
    {
        chot = chot + 1;
    }
    else nechot = nechot + 1;
}
Console.Write("\nЧисло четных = " + chot + "\tЧисло НЕ четных = " + nechot);