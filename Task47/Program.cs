﻿//Задача 47. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using System;
using static System.Console;
Clear();
Write("Введите размерность m массива: ");
int m = int.Parse (ReadLine());
Write("Введите размерность n массива: ");
int n = int.Parse (ReadLine());
double[,] randomArray = new double[m,n];

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
Write($"{randomArray[i,j]:F1} ");
}

}

}

mas(m,n);