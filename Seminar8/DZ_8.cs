// HomeWork 8.

// Task 1.
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandom2dArray()
// {
//     // это исключение
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int[,] array = new int[rows, columns];

//     for (int i= 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
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

// void ElementsDescendingArray(int[,] array)
// {    
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1 - i; k++)
//                 {
//                     if (array[j, k] < array[j, k+1])
//                     {
//                         int temp = array[j, k];
//                         array[j, k] = array[j, k+1];
//                         array[j, k+1] = temp;
//                     }
//                 }
//         }
//     }
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// ElementsDescendingArray(myArray);
// Show2dArray(myArray);

// Task 2.
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// int[,] CreateRandom2dArray()
// {   
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns less rows: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
        
//     int[,] array = new int[rows, columns];
   
//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);

//     return array;    
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

// int[] SumElementsRow(int[,] array)
// {    
//     int[] sumArray = new int[array.GetLength(0)];
//     int sum = 0;

//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         sumArray[i] = sum;
//         sum = 0;
//     }
//     return sumArray;
// }

// int IndexSmallestRow(int[] sumArray)
// {
//     int index = 0;
//     int min = sumArray[0];
//     for(int i = 1; i < sumArray.Length; i++)
//         if(sumArray[i] < min)
//         {
//             sumArray[i] = min;
//             index = i;
//         }
//     return index;
// }

// void ShowArray(int[] newArray)
// {
//     for (int i = 0; i < newArray.Length; i++)
//         Console.Write(newArray[i] + " ");
//     Console.WriteLine();
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// int[] res = SumElementsRow(myArray);
// ShowArray(res);

// int indexRow = IndexSmallestRow(res);
// Console.WriteLine($"The row with the smallest sum of elements is {indexRow}");

// Task 3.
// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

// int[,] CreateRandom2dArray1()
// {   
//     Console.Write("Input a quantity of rows1: ");
//     int rows1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns1: ");
//     int columns1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue1 = Convert.ToInt32(Console.ReadLine());
        
//     int[,] firstArray = new int[rows1, columns1];
   
//     for(int i = 0; i < firstArray.GetLength(0); i++)
//         for(int j = 0; j < firstArray.GetLength(1); j++)
//             firstArray[i,j] = new Random().Next(minValue1, maxValue1 + 1);

//     return firstArray;    
// }

// int[,] CreateRandom2dArray2()
// {   
//     Console.Write("Input a quantity of rows2: ");
//     int rows2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns2: ");
//     int columns2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue2 = Convert.ToInt32(Console.ReadLine());
        
//     int[,] secondArray = new int[rows2, columns2];
   
//     for(int i = 0; i < secondArray.GetLength(0); i++)
//         for(int j = 0; j < secondArray.GetLength(1); j++)
//             secondArray[i,j] = new Random().Next(minValue2, maxValue2 + 1);

//     return secondArray;    
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

// int[,] ProductTwoMatrices(int[,] firstArray, int[,] secondArray)
// {
//     int[,] newArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
//     if (firstArray.GetLength(1) == secondArray.GetLength(0))
//     {
//         for (int i = 0; i < firstArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < secondArray.GetLength(1); j++)
//             {
//                 newArray[i, j] = 0;
//                 for(int k = 0; k < firstArray.GetLength(1); k++)
//                 {
//                     newArray[i, j] += firstArray[i, k] * secondArray[k, j];
//                 }
//             }
//         }
//     }
//     return newArray;
// }

// int[,] myArray1 = CreateRandom2dArray1();
// Show2dArray(myArray1);

// int[,] myArray2 = CreateRandom2dArray2();
// Show2dArray(myArray2);

// int[,] res = ProductTwoMatrices(myArray1, myArray2);
// Show2dArray(res);

// Task 4.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// int[,,] CreateRandom3dArray()
// {   
//     Console.Write("Input a quantity of size1: ");
//     int size1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of size2: ");
//     int size2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of size3: ");
//     int size3 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,,] array = new int[size1, size2, size3];

//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(2); k++)
//                 array[i, j, k] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void Show3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//                 Console.Write($"{array[i, j, k]}({i},{j},{k})" + " ");
//             Console.WriteLine();
//         }
//     Console.WriteLine();
// }

// int[,,] myArray = CreateRandom3dArray();
// Show3dArray(myArray);
