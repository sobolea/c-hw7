/* Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] array= new int[4, 4];

for ( int i = 0; i < 4; i++)
{
    for ( int j = 0; j < 4; j++)
    {
        array[i, j]= new Random(). Next(10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int add;
for ( int i = 0; i < 4; i++)
{
    for ( int j = i; j < 4; j++)
    {
        add = array[i, j];
        array[i, j] = array[j, i];
        array[j, i] = add;
    }
}

Console.Write("Среднее арифметическое каждого столбца: ");
double sred;
for ( int i = 0; i < 4; i++)
{
    sred = 0;
    for ( int j = 0; j < 4; j++)
    {
        sred += array[i,j];
    }
    sred /= 4;
    Console.Write($"{sred}; ");
}