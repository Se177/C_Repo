// // Урок 7. Как не нужно писать код. Часть 1
// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9


// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[m, n];

// CreateRandomArray(array);

// PrintArray(array);

// void CreateRandomArray(double[,] array)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//     }
//   }
// }

// void PrintArray (double[,] array)
// {
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         double evenNumber = Math.Round(array[i, j], 1);
//         Console.Write(evenNumber + " ");
//       }
//       Console.WriteLine();
//   }
// }


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента
// // в двумерном массиве, и возвращает значение этого элемента или же указание, 
// // что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// Console.Write("Введите индекс строки: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[10, 10];
// FillArray(matrix);
// PrintArray(matrix);

// if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) Console.WriteLine(matrix[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого элемента в массиве нет");

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(11);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Random GetArrayy = new Random();
// int[,] matrix = new int[GetArrayy.Next(11), GetArrayy.Next(11)];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = GetArrayy.Next(11);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Write("Всего получившихся строк в массиве: ");
// Console.WriteLine(matrix.GetLength(0));

// Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: ");
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     double middleSum  = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         middleSum += matrix[i, j];
//     }
//     middleSum = Math.Round(middleSum / matrix.GetLength(0), 2);
//     Console.Write($"{ middleSum} ");
// }

 