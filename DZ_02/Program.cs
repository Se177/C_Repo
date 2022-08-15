// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // Нужно сделать через числа, без индексов строк.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Console.Write("Введите трехзначное число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(number);
// System.Console.WriteLine("Вторая цифра этого числа: " + stringNumber[1]);

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string numberText = Convert.ToString(number);
// if (numberText.Length > 2){
//   Console.WriteLine("третья цифра: " + numberText[2]);
// }
// else {
//   Console.WriteLine("третьей цифры нет");
// }

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет

// Console.Write("Введите цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void TheDayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("(этот день выходной) -> да");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("это не день недели");
//   }
//   else Console.WriteLine("(этот день не выходной) -> нет");
// }

// TheDayOfTheWeek(dayNumber);
