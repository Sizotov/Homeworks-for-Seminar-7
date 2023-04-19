//Задача 50. Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();
Write("Введите размерность m массива: ");
int m = int.Parse (ReadLine());
Write("Введите размерность n массива: ");
int n = int.Parse (ReadLine());
double[,] randomArray = new double[m,n];
Write("Введите позицию строки: ");
int m2 = int.Parse (ReadLine());
Write("Введите позицию столбца: ");
int n2 = int.Parse (ReadLine());
void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.NextDouble();
Write($"{randomArray[i,j]:F2} ");
}
WriteLine();
}
}
mas(m,n);
if (m2<1 || n2<1)
Write("Позиции строк не могут быть отрицательными");
else if (m2 <= m+1 && n2 <= n+1)
Write($"Значение элемента равно {randomArray[m2-1,n2-1]:F2} ");
else Write("Такого элемента нет в массиве");
