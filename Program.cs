// Домашнее задание к 1 семинару по теме "Введение в программирование.

//___________________________________________________

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*

Console.Write(" Пожалуйста введите первое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write(" Пожалуйста введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.WriteLine( num1 + " - самое большое число из двух введенных.");
}
else
{
    Console.WriteLine( num2 + " - самое большое число из двух введенных.");
}

*/



//___________________________________________________


//Задача 4:  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*

Console.Write(" Пожалуйста введите первое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write(" Пожалуйста введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write(" Пожалуйста введите третье число: ");

int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (max > num2) 
{
    max = num1;
}
else 
{
    max = num2;
}

if (max < num3) 
{
    max = num3;
}

Console.WriteLine(max + " - самое большое число из трех.");

*/

//___________________________________________________

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write(" Пожалуйста введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

int ostat = 0;

ostat = num % 2;

if (ostat > 0 ) 
{
    Console.WriteLine(num + " - не является четным числом.");
}
else 
{
    Console.WriteLine(num + " - является четным числом.");
}

*/

//___________________________________________________

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*

Console.Write(" Пожалуйста введите число: ");

int n = Convert.ToInt32(Console.ReadLine());

int ost = n%2;


if (ost == 0)
{
    while (n>1) 
{
        Console.Write(" "+ n + " ");
        n = n-2;
}
}
else 
{
    n=n-1;
    while (n>1) 
{
        Console.Write(" "+ n + " ");
        n = n-2;
}
}
Console.WriteLine (" - Чётные числа. Конец программы");

*/
