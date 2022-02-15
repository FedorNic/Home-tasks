// 32. Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран
int[] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i] + "\t");
}