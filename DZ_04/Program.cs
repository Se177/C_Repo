// Урок 4. Функции продолжение
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int num_A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число B: ");
// int num_B = Convert.ToInt32(Console.ReadLine());

// int GetPowNumbers(int num_A, int num_B)
// {
//   int result = 1;
//   for(int i=1; i <= num_B; i++)
//   {
//     result = result * num_A;
//   }
//   return result;
// }
// int getPow = GetPowNumbers(num_A, num_B);
// Console.WriteLine("Результат: " + getPow);


//  ________________________________________
// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите любое число: ");
// int num_A = Convert.ToInt32(Console.ReadLine());
// int GetSumNumbers(int num_A)
// {
//     int count = Convert.ToString(num_A).Length;
//     int start = 0;
//     int result = 0;
//     for (int i = 0; i < count; i++)
//     {
//     start = num_A - num_A % 10;
//     result = result + (num_A - start);
//     num_A = num_A / 10;
//     }
//    return result;
//   }
//  int Sum = GetSumNumbers(num_A);
// Console.WriteLine("Сумма цифр в числе: " + Sum);
        

// // ________________________________________
// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// // int size = Convert.ToInt32(Console.ReadLine());
// // if (size < 0) size = - size;
//  int[] array = new int[8];
//  for (int i = 0; i < array.Length; i++)
//  {
//     array[i] = new Random().Next(1000);
//     // array[i] = Convert.ToInt32(Console.ReadLine());
//     Console.Write(array[i] + " ");
//  }

