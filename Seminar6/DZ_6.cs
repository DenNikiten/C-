// HomeWork 6.

// Task 1.
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Input a size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write("Input a number for array: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());        
//     }

// int count = 0;
// for(int i = 0; i < array.Length; i++)
//     if(array[i] > 0)
//         count++;

// Console.WriteLine($"The user entered {count} numbers greater than zero.");

// Task 2.
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Console.Write("Input a value of k1 for the first staight line: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a value of b1 for the first staight line: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a value of k2 for the second staight line: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a value of b2 for the second staight line: ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
// double y = Math.Round((k1 * x + b1), 2);


// if(k1 == k2)
//     Console.WriteLine("Straight parallel!");
// else if(k1 / k2 == b1 / b2)
//     Console.WriteLine("Straight lines match!");
// else
//     Console.WriteLine($"The intersection point of two straight lines is equal to ({x};{y})");
