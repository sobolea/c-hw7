/* Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] array= new int[3, 3];
Console.Write("Введите позиции элемнтов: ");
int a, b;
int.TryParse(Console.ReadLine(), out a);
b = a % 10;
a = a / 10;

for ( int i = 0; i < 3; i++)
{
    for ( int j = 0; j < 3; j++)
    {
        array[i, j]= new Random(). Next(10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

bool flg = false;
Console.Write($"{a}{b} -> ");
for ( int i = 0; i < 3; i++)
{
    if( i == a) 
    {
        for( int j = 0; j < 3; j ++)
        {        
            if ( j == b) 
            {
                flg = true;
                Console.Write(array[i,j]);
            }
        }
    }
}

if ( flg == false)  Console.Write("такого числа в массиве нет");