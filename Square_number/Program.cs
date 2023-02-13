/*Напишите программу,
 которая на вход принимает число, 
 а на выходе выдает его квадрат*/

Console.Clear();
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
Console.Write ("Квадрат этого числа будет: ");
Console.WriteLine (a*a);
Console.WriteLine ($"Я же сказал, что квадрат данного числа будет {a*a}");
Console.WriteLine ($"Чего тут не понятного?, {Convert.ToInt32(Math.Pow(a,2))}");


