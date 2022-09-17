// // Урок 8. Как не нужно писать код. Часть 2
// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// Console.Write("Задайте двумерный массив");
// Console.Write($"\nВведите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// CreateRandomArray(matrix);
// PrintArray(matrix);
// OrganizedArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// void CreateRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(11);
//         }
//     }
// }

// void OrganizedArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // ________________________________________
// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.Write("Задайте двумерный массив");
// Console.Write($"\nВведите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];
// CreateRandomArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// SelectRowMinSumElements(matrix);

// void CreateRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void SelectRowMinSumElements(int[,] array)
// {
//     int minimalRow = 0;
//     int minimalSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         minimalRow += matrix[0, i];
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j];
//         if (sumRow < minimalRow)
//         {
//             minimalRow = sumRow;
//             minimalSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"Номер строки с наименьшей суммой элементов: {minimalSumRow + 1}");
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// // ________________________________________
// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// Console.Write("Задайте размеры двух матриц:");
// Console.Write($"\nВведите количество строк Первой матрицы: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов Первой матрицы: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Внимание! ");
// Console.WriteLine($"Согласно правилу сложения матриц, одну матрицу можно умножить на другую только в том случае, если число столбцов Первой матрицы равняется числу строк Второй матрицы.");
// Console.WriteLine("Поэтому принимаем количество строк Второй матрицы равным значению количества столбцов Первой матрицы");
// Console.Write("Введите количество столбцов Второй матрицы: ");
// int p = Convert.ToInt32(Console.ReadLine());

// int[,] firstMartrix = new int[m, n];
// CreateRandomArray(firstMartrix);
// Console.WriteLine($"\nПервая матрица:");
// PrintArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateRandomArray(secomdMartrix);
// Console.WriteLine($"\nВторая матрица:");
// PrintArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"\nПроизведение Первой и Второй матриц:");
// PrintArray(resultMatrix);

// void CreateRandomArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(11);
//     }
//   }
// }

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// ________________________________________
// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)

// Console.Write("Задайте размеры трехмерного массива:");
// Console.Write($"\nВведите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество слоев: ");
// int p = Convert.ToInt32(Console.ReadLine());

// int[,,] matrix3D = new int[m, n, p];
// CreateArray(matrix3D);
// PrintArray(matrix3D);

// void CreateArray(int[,,] array)
// {
//     int count = 10;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < matrix3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < matrix3D.GetLength(2); k++)
//             {
//                 Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// // ___________________________________________
// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

// int lenght = 4;
// int[,] matrix = new int[lenght, lenght];
// FillSpiralArray(matrix, lenght);
// PrintArray(matrix);

// void FillSpiralArray(int[,] array, int n)
// {
//     int i = 0;
//     int j = 0;
//     int temp = 1;
//     for (int p = 0; p < n * n; p++)
//     {
//         int k = 0;
//         do { array[i, j++] = temp++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = temp++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = temp++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = temp++;
//         ++i; ++j;
//         if (n < 0) n = 0;
//         else n = n - 2;
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }