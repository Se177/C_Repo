// Урок 6. Двумерные массивы и рекурсия
// На оценку "5" необходимо использовать PascalCase, camelCase. Будет учитываться чистота программного кода

// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

// Console.Write($"Введите количество М чисел: ");
// int quantity_m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[quantity_m];

// void PositiveNumbers(int quantity_m){
// for (int i = 0; i < quantity_m; i++)
//   {
//     Console.Write($"Введите число {i+1}: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }

// int compare_Num(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if(array[i] > 0 ) count += 1; 
//   }
//   return count;
// }

// PositiveNumbers(quantity_m);

// Console.WriteLine($"Чисел больше 0: {compare_Num(array)} ");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// double[,] ratio = new double[2, 2];
// double[] intersection = new double[2];

// void inputRatio(){
//   for (int i = 0; i < ratio.GetLength(0); i++)
//   {
//     Console.Write($"Введите коэффициенты для {i+1}-й прямой:\n");
//     for (int j = 0; j < ratio.GetLength(1); j++)
//     {
//       if(j==0) Console.Write($"Введите коэффициент k: ");
//       else Console.Write($"Введите коэффициент b: ");
//       ratio[i,j] = Convert.ToInt32(Console.ReadLine());
//     }
//   }
// }

// double[] Result(double[,] ratio)
// {
//   intersection[0] = (ratio[1,1] - ratio[0,1]) / (ratio[0,0] - ratio[1,0]);
//   intersection[1] = intersection[0] * ratio[0,0] + ratio[0,1];
//   return intersection;
// }

// void outputRatio(double[,] ratio)
// {
//   if (ratio[0,0] == ratio[1,0] && ratio[0,1] == ratio[1,1]) 
//   {
//     Console.Write($"\nПрямые совпадают");
//   }
//   else if (ratio[0,0] == ratio[1,0] && ratio[0,1] != ratio[1,1]) 
//   {
//     Console.Write($"\nПрямые параллельны");
//   }
//   else 
//   {
//     Result(ratio);
//     Console.Write($"\nТочка пересечения 1-й и 2-й прямой: ({intersection[0]}, {intersection[1]})");
//   }
// }

// inputRatio();
// outputRatio(ratio);


// Доп. задачка:
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write($"Введите десятичное число: ");
// int decimal_num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Полученное двоичное число: ");
// var stack = new Stack<int>();
// while (decimal_num > 0)
// {
//     stack.Push(decimal_num % 2);
//     decimal_num /= 2;
// }
// foreach (int i in stack)
// {
//   Console.Write(i);
// }