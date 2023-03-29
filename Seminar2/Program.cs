// Возвращающие и невозвращающие (void) методы

// Task 1.
// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;
//     // 372 - > 3 7 2 - > 3 2
//     int result = hundreds * 10 + units;  
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int newNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {newNumber}");

// Task 2.
// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

// int MaxDigit(int num)
// {
//     int num1 = num / 10;
//     int num2 = num % 10;
//     if (num1 > num2)
//     {
//         return num1;
//     }
//     else
//     {
//         return num2;
//     }
// }

// int randNumber = new Random().Next(10, 100);
// int newNumber = MaxDigit(randNumber);

// Console.WriteLine($"The greater number of {randNumber} is {newNumber}");


// task 3.
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно a и b.

// bool MultipleNumber(int num, int a, int b)  // кратное число
// {
//     if (num % a == 0 && num % b == 0)  // && - и, || - или
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Inpute a number: ");
// int myNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Inpute a number a: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Inpute a number b: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// bool newNumber = MultipleNumber(myNum, numA, numB);
// Console.WriteLine(newNumber);

// Task 4.
// Напишите программу, которая принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого.

// bool SquareNumber(int num1, int num2)
// {
//     if (num1 * num1 == num2 || num2 * num2 == num1)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Input a number: ");
// int numSq1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number: ");
// int numSq2 = Convert.ToInt32(Console.ReadLine());

// bool newNumber = SquareNumber(numSq1, numSq2);
// Console.WriteLine(newNumber);