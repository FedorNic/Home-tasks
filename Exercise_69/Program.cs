// 69. Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
// M = 1; N = 4 -> 10
// M = 4; N = 8. -> 30
int NumbersSum(int M, int N)
{
    if (M > N) return 0;
    return M + NumbersSum(M + 1, N);
}
Console.WriteLine(NumbersSum(4, 8));