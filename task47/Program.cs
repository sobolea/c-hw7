﻿/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9    */

int m, n;
Console.Write("Введите m: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Введите n: ");
int.TryParse(Console.ReadLine(), out n);

double[,] array = new double[m, n];

for ( int i = 0; i < m; i++)
{
    for ( int j = 0; j < n; j++)
    {
        array[i, j] = new Random().NextDouble() * 20 - 10;
        Console.Write(string.Format("{0:f1}", array[i, j]));
        Console.Write(" ");
    }
    Console.WriteLine();
}
