
// int number1 = 5;   // целые
/*
double number2 = 12.65;  // вещественные
*/
// string word = "my word!";  // в строке могут быть 1@#$456jhjkhjfh
// char symbol = 't'; // символ '?' в единственном лице, все что угодно

// bool check = true;   // false (0)   true (1) 


// int num = 5;
// Console.WriteLine("My number is " + num); // конкатенация


// int num1 = 5;
// int num2 = 7;
// Console.WriteLine("My number is " + num1 + " and " + num2 + " and this is good "); // конкатенация


// int num1 = 5;
// int num2 = 7;
// Console.WriteLine("My number is " + num1 + " and " + num2 + " and this is good "); // конкатенация
// Console.WriteLine($"My number is {num1} and {num2} and this is good"); // форматированный вывод


// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());  // пустая консоль ReadLine()
// // Convert.ToInt32 - преобразование в целое число; ToDouble;

// Console.WriteLine("Your number is " + num);


// HomeWork 1.

// Task 1. Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad2 = num2 * num2;

// if (num1 == quad2)
// {
//     Console.WriteLine("Yes!");
// }
// else
// {
//     Console.WriteLine("No!");
// }

// если единственные строки, то можно вот так записать
// if (num1 == quad2)
//     Console.WriteLine("Yes!");
// else
//     Console.WriteLine("No!");

// Task 2.
// 01:32:45
// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Input a positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = -num;

// while(current <= num)
// {
//     Console.Write(current + " ");
//     current++;
// }

// 32145 / 10 = 3214
// 32145 / 100 = 321
// 32145 / 1000 = 32
// 32145 / 10000 = 3

// 32145 % 10 = 5
// 32145 % 100 = 45
// 32145 % 1000 = 145
// 32145 % 10000 = 2145

// 72635 - > 26   72635/100%100   - > 63 72635/10%100
