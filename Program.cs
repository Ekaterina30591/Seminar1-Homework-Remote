﻿//Seminar 1. Homework Kloss E.
//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.WriteLine("Max: " + num1);
    Console.WriteLine("Min: " + num2);
}
else
{
    Console.WriteLine("Max: " + num2);
    Console.WriteLine("Min: " + num1);
}
*/
//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
  if (num1 > num3)
  {
    Console.WriteLine("Max: " + num1);
  }
  else 
    {
    Console.WriteLine("Max: " + num3);
    }
} 
else
{
    if (num2 > num3)
    {
        Console.WriteLine("Max: " + num2);
    }
    else
    {
        Console.WriteLine("Max: " + num3);
    }
}