// // Урок 5. Функции продолжение
// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];

// void FillArray(int[] array, int min, int max){
//   for (int i = 0; i<array.Length; i++ ){
//     array[i] = new Random().Next(min, max);
//   }
// }

// void WriteArray(int[] array){
//     for (int i = 0; i<array.Length; i++ ){
//     Console.Write(array[i] + " ");
//   }
//   Console.WriteLine();
// }

// int QuantityEvenNumber(int[] array){
//     int quantity = 0;
//     for (int i = 0; i<array.Length; i++ ){
//     if (array[i] % 2 == 1)
//     {
//       quantity++;
//     }
//   }
//   return quantity;
// }

// FillArray(numbers, 100, 1000);
// WriteArray(numbers);
// Console.WriteLine();

// int quantityEvenNum = QuantityEvenNumber(numbers);
// Console.WriteLine($"Количество чётных чисел в массиве: {quantityEvenNum}");



// // ________________________________________
// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0
// // 

// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());

// int RandomNum(int size, int min, int max)
//   {
//   int[] randomNumbers = new int[size];
//   int sumOddNum = 0;
//   Console.Write("Заданный массив: ");

//     for (int i = 0; i <randomNumbers.Length; i++ ){
//       randomNumbers[i] = new Random().Next(min, max);

//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 0)
//       {
//         sumOddNum = sumOddNum + randomNumbers[i];
//       }
//     }
//   return sumOddNum;
//   }

// int umOddNum =  RandomNum(size, 1, 10);

// Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {umOddNum}");



// ________________________________________
// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Заданный массив: ");

// double[] array = new double[size];
//   for (int i = 0; i < array.Length; i++ )
//   {
//     array[i] = new Random().Next(1, 10);
//     Console.Write(array[i] + " ");
//   }

// double maxNum = array[0];
// double minNum = array[0];

//   for (int i = 1; i < array.Length; i++)
//   {
//     if (maxNum < array[i])
//     {
//       maxNum = array[i];
//     }
//         if (minNum > array[i])
//     {
//       minNum = array[i];
//     }
//   }

//   double result = maxNum - minNum;

//   Console.WriteLine($"\nРазница между между максимальным и минимальным элементом массива составила: {result}");