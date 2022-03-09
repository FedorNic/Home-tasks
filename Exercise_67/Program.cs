// 67. Показать натуральные числа от N до 1, N задано. N = 5. -> "5, 4, 3, 2, 1"
string NumbersRec(int N)
{
    if (N < 1) return String.Empty;
    return N + " " + NumbersRec(N - 1);
}
Console.WriteLine(NumbersRec(5));