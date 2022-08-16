// int Calculate(int a, int b)
// {
//     int result = 0;
//     result = a + b;
//     return result;
// }

// System.Console.WriteLine(Calculate(5,2);


// Код от Преподавателя

// int Calculate (int a, int b)
// {
//     int result = 0;
//     result = a + b;
//     return result;
// }

// Console.WriteLine(Calculate(5,2));

// Метод Vcoid

// void VoidCalculate (int a, int b)
// {
//     int result = 0;
//     result = a + b;
//     Console.WriteLine(result);
// }
// VoidCalculate(5,2);'
// int Calculate (int a, int b)
// {
//     int result = 0;
//     result = a + b;
//     return result;
// }

// Console.WriteLine(Calculate(5,2));

// void VoidCalculate (int a, int b)
// {
//     int result = 0;
//     result = a + b;
//     Console.WriteLine(result);
// }
// VoidCalculate(5,2);

// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int number = Convert.ToInt32(Console.Readline());
// //PascalCase
// int GetSumNumber (int num)
// { 
//     int start = 1;
//     int sum = 0;
//     while (start <= num)
//     {
//         sum += start;
//         start++;
//     }
//     return sum;

// }
// System.Console.WriteLineСумма чисел от 1 до {number} = {GetSumNumbers(number)}");

// от Преподавателя:

// int number = Convert.ToInt32(Console.ReadLine());
// // PascalCase 
// // type Name (params)
// int GetSumNumbers(int num)
// {
//     int start = 1; // [1;A]
//     int sum = 0; // Суммы еще нет - значение 0
//     while (start <= num)
//     {
//         sum += start;
//         // sum = sum + start
//         // sum *= start => sum = sum * start
//         start++; // start = start + 1
//     }
//     return sum;
// }

// Console.WriteLine($"Сумма чисел от 1 до {number} = {GetSumNumbers(number)}");
// Dторой вариант
// int number = Convert.ToInt32(Console.ReadLine());
// // PascalCase 
// // type Name (params)
// int GetSumNumbers(int num) // PascalCase 
// {
//     int start = 1; // [1;A]
//     int sum = 0; // Суммы еще нет - значение 0
//     while (start <= num)
//     {
//         sum += start;
//         // sum = sum + start
//         // sum *= start => sum = sum * start
//         start++; // start = start + 1
//     }
//     return sum;
// }
// int testNumber = 0; // camelCase

// Console.WriteLine($"Сумма чисел от 1 до {number} = {GetSumNumbers(number)}");

// Задача 26: Напишите программу, которая принимает на вход число
//  и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// string number = Console.Readline();
// Console.WriteLine($"Длина строчки '{number}' = {number.Length}");

// от Преподавателя:

// int number = Convert.ToInt32(Console.ReadLine());

// int GetCountNumbers(int num)
// {
//     int count = 0; // Количество чисел
//     while (number > 0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }

// Console.WriteLine($"Количество цифр в числе {number} = {GetCountNumbers(number)}");


// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int number = Convert.ToInt32(Console.ReadLine());
// int GetUmnNumbers(int num)
// {
//     int start = 1; 
//     int sum = 1; 
//     while (start <= num)
//     {
//         sum *= start;
//         // sum = sum + start
//         // sum *= start => sum = sum * start
//         start++; // start = start + 1
//     }
//     return sum;
// }


// Console.WriteLine($"Сумма чисел от 1 до {number} = {GetUmnNumbers(number)}");

// от преподавателя

// int number = Convert.ToInt32(Console.ReadLine());
// int GetMultiply(int num) // PascalCase 
// {
//     int start = 1; // [1;A]
//     int result = 1; // Произведение
//     while (start <= num)
//     {
//         result *= start;
//         // result = result + start
//         // result *= start => result = result * start
//         start++; // start = start + 1
//     }
//     return result;
// }
// Console.WriteLine($"Сумма чисел от 1 до {number} = {GetMultiply(number)}");



// Задача 30: Напишите программу, которая выводит массив 
// из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
//             for (int i = 0; i < array.Length; i++)
//             {
//                 array[i] =  new Random().Next(0,2);
//                 Console.Write(array[i] + " ");
 
//             }


// от Преподавателя:

// int[] GetBinaryArray(int size) //size - количество элементов
// {
//     int[] result = new int[size]; // Массив, в котором size элементов (размер)
//     // size = 2, result = [0,0]
//     for (int i = 0; i < result.Length; i++) // result.Length = size 
//     {
//         result[i] = new Random().Next(2); // [0;1]
//     }
//     return result;
// }

// int[] array = GetBinaryArray(8);

// Console.WriteLine($"Результат: [ {String.Join(", " ,array )} ]");
