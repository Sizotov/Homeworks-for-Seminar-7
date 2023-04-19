//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Clear();
Write("Введите размерность m массива: ");
int m = int.Parse (ReadLine());
Write("Введите размерность n массива: ");
int n = int.Parse (ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1,10);
Write($"{randomArray[i,j]} ");
}
WriteLine();
}
}

void arif(int m, int n)
{
Write("Среднее арифметическое каждого столбца: ");
int i,j;
Random rand = new Random();
for (j = 0; j < n; j++)
{
double sum = 0;
for (i = 0; i < m; i++)
{
sum = sum + randomArray[i,j];
}
Write($"{sum/(i):F1}; ");
}
}
mas(m,n);
arif(m,n);