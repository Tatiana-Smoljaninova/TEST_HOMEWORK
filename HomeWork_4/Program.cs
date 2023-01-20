// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

if(N <= 0)
Console.Write("Укажите число больше 0");

else
while(i <= N)
{
if(i%2 == 0)
Console.Write($"{i} ");
i++;
}