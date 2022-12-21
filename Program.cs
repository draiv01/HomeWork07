﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] Create2dArray(int rows, int cols)
// {
//     double[,] array = new double[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = Create2dArray(m, n);
// Show2dArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



// int[,] Create2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindQuaters(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i > array.GetLength(0) || j > array.GetLength(1))
//             {

//                 Console.WriteLine("такого элемента нет");
//             }
//             else Console.WriteLine($"значение элемента {i} строки и {j} столбца равно {array[i - 1, j - 1]}");
//         }
//         Console.WriteLine();
//     }
// }




// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of min eliment: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of max element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);
// Console.WriteLine();
// FindQuaters(array);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// double FindQuaters(int[,] array)

// {
//     double avarage = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         avarage = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//                 avarage = avarage + array[i, j];
//                 {
//                 avarage = avarage / array.GetLength(1);
//                 }
//                 Console.Write(avarage +"; ");
//         }
//     }
//     return avarage;
// }




// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of min eliment: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter numb of max element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);
// Console.WriteLine();
// double f = FindQuaters(array);
// System.Console.WriteLine($"{f}");

