﻿/// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
//максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());
int i = x;
if (y>i)
i = y;
if (z>i)
i = z;
Console.WriteLine($"Максимальное число {i}");