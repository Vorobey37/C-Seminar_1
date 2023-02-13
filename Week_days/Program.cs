/*Напишите программу, которая будет выдавать 
название дня недели по заданному номеру*/
Console.Clear();
Console.WriteLine("Введите номер: ");
int a = int.Parse(Console.ReadLine());
while (a<1||a>7)
{Console.WriteLine("Дней в неделе всего семь!!!");
Console.WriteLine("Введите правильный номер!: ");
a = int.Parse(Console.ReadLine());
}
if (a==1)
{Console.WriteLine($"{a} - это понедельник!");}
if (a==2)
{Console.WriteLine($"{a} - это вторник!");}
if (a==3)
{Console.WriteLine($"{a} - это среда!");}
 if (a==4)
{Console.WriteLine($"{a} - это четверг!");}
if (a==5)
{Console.WriteLine($"{a} - это пятница!");}
if (a==6)
{Console.WriteLine($"{a} - это суббота!");}
if (a==7)
{Console.WriteLine($"{a} - это воскресенье!");}





