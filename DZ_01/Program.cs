// // Урок 1. Знакомство с языком программирования С#
// // На "5" нужно сделать минимум 3 задачки
// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите два числа : ");

// int num_a = Convert.ToInt32(Console.ReadLine());
 
// int num_b = Convert.ToInt32(Console.ReadLine());
 
// if (num_a > num_b)
// {
//     Console.WriteLine("{0} наибольшее число", num_a);
// }
 
// else
// {
//     Console.WriteLine("{0} наибольшее число ", num_b);
// }
 
// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.WriteLine("Введите три числа : ");

// int num_a = Convert.ToInt32(Console.ReadLine());
// int num_b = Convert.ToInt32(Console.ReadLine());
// int num_с = Convert.ToInt32(Console.ReadLine());

// int num_max = num_a;

// if (num_b > num_a)
// {
//     num_max = num_b;
// }
 
// if (num_с > num_max)
// {
//     num_max = num_с;
// }

// Console.WriteLine("{0} наибольшее число ", num_max);

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// Console.Write("Введите число : ");
 
// int num = int.Parse(Console.ReadLine());
 
// if (num % 2 == 0)
//  {
//  Console.Write("Введенное число является четным");
//  }
//  else
//  {
//  Console.Write("Введенное число нечетное");
//  }

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
        
// for (int i = 1; i <= number; i++)
// {
// if (i % 2 == 0) 
//     {
//     Console.Write(i + " ");
//     }
// }