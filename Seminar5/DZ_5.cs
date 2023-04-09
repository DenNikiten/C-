// HomeWork 5.

// Task 1.
// Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.
// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
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

// int RandomPositiveNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++;
//     }
//     return count;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);

// int result = RandomPositiveNumbers(newArray);
// Console.WriteLine(result);

// Task 2.
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int SumOddPositions(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//         sum += array[i];
//     return sum;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int result = SumOddPositions(newArray);
// Console.WriteLine(result);

// Task 3.
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементом массива.

// double[] CreateRandomArray(int size, int minVale, int maxValue)
// {
//     double[] array = new double[size];

//     for (int i = 0; i < size; i++)
//         array[i] = Math.Round((new Random().Next(minVale, maxValue + 1) + new Random().NextDouble()), 2);        
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// double DifferenceMaxMin(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     double dif;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max)
//             max = array[i];
//         if (array[i] < min)
//             min = array[i];
//     }
//     dif = max - min;
//     return dif;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// double result = Math.Round(DifferenceMaxMin(newArray), 2);
// Console.WriteLine($"The difference between max and min position is {result}");