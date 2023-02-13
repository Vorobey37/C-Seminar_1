/*Напишите программу, которая на входе принимает одно натуральное число N,
а на выходе показывает все целые числа от -N до N*/
Console.Clear();
Console.WriteLine("Введите натуральное число: ");
int a = int.Parse(Console.ReadLine());
while (a<=0)
{Console.WriteLine("Это не натуральное число!!!");
Console.WriteLine("Введите НАТУРАЛЬНОЕ число: ");
a = int.Parse(Console.ReadLine());}
int b = -a;
while(b<=a)
{Console.Write($"{b} ");
b++;}






