// HomeWork 4.

// Task 1.
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// int NaturalNumber(int num1, int num2)
// {
//     int num = num1;
//     for (int i = 1; i < num2; i++)
//     {
//         num1 = num1 * num;
//     }
//     return num1;
// }

// Console.Write("Input a first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(NaturalNumber(a, b));

// Task 2.
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// int SumNumber(int num)
// {
//     int res = 0;
//     while (num > 0)
//     {
//         res = res + num % 10;
//         num = num / 10;
//     }
//     return res;
// }

// Console.Write("Input a number: ");
// int newNumber = Convert.ToInt32(Console.ReadLine());

// int sumDigits = SumNumber(newNumber);
// Console.WriteLine($"The sum of digits in a number {newNumber} is {sumDigits}");

// Task 3.
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// int[] CreateArray(int size, int value)
// {
//     int[] array = new int[size];
//     array[0] = value;
//     for (int i = 1; i < size; i++)
//     {   
//         Console.Write("Input a value for array: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine(); 
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a value for array: ");
// int newNumber = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateArray(size, newNumber);
// ShowArray(newArray);

