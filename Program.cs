/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
/*
Console.Write("первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max;
max = number1;
{
if (number2 > number1) max = number2;
}
Console.Write(max);
*/

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

/*
Console.Write("первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;
max = number1;

{
if (number2 > max) max = number2;
}
{
if (number3 > max) max = number3; 
}

Console.Write(max);
*/

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/
/*
Console.Write("число: ");
int number = Convert.ToInt32(Console.ReadLine());
{
   if (number % 2 == 0)
    Console.Write("число четное");
    else  Console.Write("число нечетное");
}
*/
/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/
Console.Write("число: ");
int number = Convert.ToInt32(Console.ReadLine());
var Numbers = new List<int> {0, number};
int index = 0;
int range = (number - 1);

{
    while (index < range);
        if (index % 2 != 0)
        Numbers.Add(index);
    index++;
}
 foreach (var item in Numbers);
 
    Console.WriteLine(Numbers);