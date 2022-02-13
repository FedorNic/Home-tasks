// Задача 18: Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool f1 = false; bool f2 = false; bool f3 = false; bool f4 = false;

bool x = true; bool y = true;
if (!(x || y) == (!x && !y))
{
    f1 = true;
    Console.WriteLine("F1 = " + f1);
}

x = false; y = false;
if (!(x || y) == (!x && !y))
{
    f2 = true;
    Console.WriteLine("F2 = " + f2);
}

x = true; y = false;
if (!(x || y) == (!x && !y))
{
    f3 = true;
    Console.WriteLine("F3 = " + f3);
}

x = false; y = true;
if (!(x || y) == (!x && !y))
{
    f4 = true;
    Console.WriteLine("F4 = " + f4);
}

if (f1 && f2 && f3 && f4)
    Console.WriteLine("Является истиной");
else
{
    Console.WriteLine("Не является истиной");
}