// Seminar 7.

// Task 1.
// [,] - двумерный маассив; [,,] - трехмерный, и т.д.

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

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// Task 2.
// Задайте двумерный массив размером M на N, каждый элемент 
// в массиве которого будет находиться по формуле a[i,j] 
// равно i + j. Выведите полученный массив на экран

// int[,] Create2dArray()
// {
//     // это исключение
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
       
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = i + j;
    
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

// int[,] myArray = Create2dArray();
// Show2dArray(myArray);

// Task 3.
// Задайте двумерный массив. Нийдите элементы у которых оба индекса
// четные и заментие эти элементы на их квадраты

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

//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void FoundElements(int[,] array)
// {
//     for (int i = 2; i < array.GetLength(0); i += 2)
//         for (int j = 2; j < array.GetLength(1); j += 2)
//             array[i,j] = array[i,j] * array[i,j];     
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

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// FoundElements(myArray);
// Show2dArray(myArray);


// Task 4.
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали

// int[,] CreateRandom2dArray()
// {
//     // это исключение
//     Console.Write("Input a side of matrix: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     // Console.Write("Input a quantity of columns: ");
//     // int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     int[,] array = new int[rows, rows];

//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// int SumDiagonalElements(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         sum = sum + array[i,i];

//     return sum;            
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

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// int result = SumDiagonalElements(myArray);
// Console.WriteLine($"The sum of the elements diagonally is {result}");

//_____________________________
