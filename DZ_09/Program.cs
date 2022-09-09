// Урок 9. Как не нужно писать код. Часть 3

// // Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// // M = 4; N = 8. -> ""4, 6, 7, 8""


// Console.Write($"Введите значение числа М: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Введите значение числа N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (M > N) return;
// string PrintNumbers(int start, int end)
// {

//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start +1, end));

// }

// System.Console.WriteLine($"Натуральные числа от {M} до {N}: '{PrintNumbers(M,N)}' ");



// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


// int M = InputNumbers("Введите значение числа М: ");
// int N = InputNumbers("Введите значение числа N: ");
// int start = M;

// if (M > N) 
// {
//   M = N; 
//   N = start;
// }

// PrintSumm(M, N, start=0);

// void PrintSumm(int M, int N, int summ)
// {
//   summ = summ + N;
//   if (N <= M)
//   {
//     Console.Write($"Сумма натуральных элементов в промежутке от M до N:  {summ} ");
//     return;
//   }
//   PrintSumm(M, N - 1, summ);
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }



// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9

// int m = InputNumbers("Введите значение неотрицательного числа m: ");
// int n = InputNumbers("Введите значение неотрицательного числа n: ");
// int resultAkkerman = Akkerman(m, n);

// int Akkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Akkerman(m - 1, 1);
//   else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// Console.Write($"Полученная функця Аккермана: {resultAkkerman} ");