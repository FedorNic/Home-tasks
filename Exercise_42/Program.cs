// 42. Определить, сколько чисел больше 0 введено с клавиатуры.
int[] array = new int[5];
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число ");
    array[i] = Convert.ToInt32(Console.ReadLine());
   if (array[i] > 0) result = result + 1;
}
Console.WriteLine("Колличество чисел больше 0 = " + result);