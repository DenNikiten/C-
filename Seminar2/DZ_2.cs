// HomeWork 2.

// Task 1.
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int secondDigit = num % 100 / 10;
//     return secondDigit;
// }

// Console.Write("Input a three-digit number: ");
// int favorNumber = Convert.ToInt32(Console.ReadLine());

// int newNumber = CutNumber(favorNumber);

// Console.WriteLine($"New version of {favorNumber} is {newNumber}");

// Task 2.
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// int ThirdDigit(int num)
// {
//     if (num < 100)
//     {
//         int twoDigits = -1;
//         return twoDigits;
//     }
    
//     while (num > 1000)
//     {
//         int num2 = num / 10;
//         num = num2;
//     }
    
//     int ourNumber = num % 10;
//     return ourNumber;
// }

// Console.Write("Input a number: ");
// int favorNumber = Convert.ToInt32(Console.ReadLine());

// int newNumber = ThirdDigit(favorNumber);
// Console.WriteLine($"The third digit of the number is {newNumber}");

// Task 3.
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли 
// этот день выходным.

// bool DayWeek(int num)
// {
//     if (num == 6 || num == 7)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Enter the number of the day of the week: ");
// int dWeek = Convert.ToInt32(Console.ReadLine());

// bool newDay = DayWeek(dWeek);
// Console.WriteLine($"The {dWeek} day of the week and it is a day off - {newDay}!");