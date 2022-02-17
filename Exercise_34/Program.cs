// 34. Написать программу для замены элементов массива на противоположные.
int[] array = { 4, 9, -8, 5, 9, -16, 7, 0, 4, -78 };
Console.Write("Элементы с противоположным знаком =    ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + "\t");
}