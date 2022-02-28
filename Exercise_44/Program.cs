// 44. Найти точку пересечения двух прямых, заданных уравнением y = k1 * x + b1, y = k2 * x + b2, 
//если b1, k1, b2 и k2 заданы
double b1 = 2, k1 = 1, b2 = 3, k2 = 2;
if(k1==k2) Console.WriteLine("Прямые не пересекаются");
double x = (b1-b2)/(k2-k1);
double y = k2*x + b2;
Console.WriteLine("Точка пересечения прямых X = " + x + "\t" + "Y = " + y);