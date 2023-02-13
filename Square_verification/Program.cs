/*Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго*/
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine ());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine ());
if (a==b*b)
{
    Console.WriteLine("Танечка, ты молодец!");
    Console.WriteLine($"Ведь число {a} - это {b} в квадрате!");
}
else 
{
   Console.WriteLine($"Мне жаль, но число {a} - это не {b} в квадрате");
}





