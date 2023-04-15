// HomeWork 7.

// Task 1.
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];

//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 1);
    
//     return array;
// }

// void Show2dArray(double[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//             for (int j = 0; j < array.GetLength(1); j++)
//                 Console.Write(array[i,j] + " ");
//             Console.WriteLine();
//         Console.WriteLine();
//     }

// Console.Write("Input a quantity of rows for array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);

// Task 2.
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {    
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void PositionElement(int[,] array, int i, int j)
// {
//     if (i < array.GetLength(0) && j < array.GetLength(1))
//         Console.WriteLine($"The value of an element in a two-dimensional array is {array[i,j]}");
//     else
//         Console.WriteLine("There is no such element in the array");
    
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();  
// }

// Console.Write("Input a quantity of rows for array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the position of element i in the two-dimensional array: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the position of element j in the two-dimensional array: ");
// int j = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// PositionElement(myArray, i, j);

// Task 3.
// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {    
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// double[] ArithmeticMeanColumn(int[,] array)
// {
//     double[] newArray = new double[array.GetLength(1)];
//     double sum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//             sum = sum + array[j,i];
//         sum = Math.Round(sum / array.GetLength(0), 1);
//         newArray[i] = sum;
//         sum = 0;
//     }
//     return newArray;            
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();  
// }

// void ShowArray(double[] newArray)
// {
//     for (int i = 0; i < newArray.Length; i++)
//         Console.Write(newArray[i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Input a quantity of rows for array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
    

// int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(myArray);
// double[] result = ArithmeticMeanColumn(myArray);
// ShowArray(result);