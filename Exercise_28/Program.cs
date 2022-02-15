// 28. Подсчитайте сумму цифр в числе.
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
int sum = 0;
while (num != 0)
{
    sum = sum + num % 10;
    num = num / 10;
}
Console.WriteLine("Сумма цифр в числе = " + sum);

// Денис, подскажите, пожалуйста.
//Не понимаю, почему не работает код ниже...

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int sum = 0;
// int i = 0;
// while (i < number.Length)
// {
//     sum = sum + number[i];
//     i++;
// }
// Console.WriteLine(sum);