// Seminar 5.

// Задайте массив из 12 элементов, заполненный случайными числами из
// промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

// int[] CreateRandomArray(int size, int minVale, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minVale, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int GetNegativeSum(int[] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sum += array[i]; // sum увеличить на array[i]
//         }
//     }
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

// int result = GetNegativeSum(newArray);
// Console.WriteLine("Sum of negative elements is " + result);

// Task 2.
// Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.

// int[] CreateRandomArray(int size, int minVale, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minVale, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ChengeNegativeElements(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int[] result = ChengeNegativeElements(newArray);
// ShowArray(result);

// Task 3.
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// int[] CreateRandomArray(int size, int minVale, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minVale, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// bool SetNumber(int[] array, int num)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
    
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// Console.Write("Input a number: ");
// int result = Convert.ToInt32(Console.ReadLine());

// bool newNumber = SetNumber(newArray, result);
// Console.WriteLine(newNumber);

// Task 4.
// Задайте одномерный массив из m случайных чисел. Найдите количество
//  элементов массива, значения которых лежат в отрезке [a,b].
// int[] CreateRandomArray(int size, int minVale, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minVale, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int SetNumber(int[] array, int numA, int numB)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//         if (array[i] >= numA && array[i] <= numB)
//         count++;
//     return count;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int newNumber = SetNumber(newArray, a, b);
// Console.WriteLine(newNumber);

// Task 5.
// Найти произведение пар чисел в одномерном массиве
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// int[] CreateRandomArray(int size, int minVale, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minVale, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] FoundArray(int[] array)
// {
//     int[] newArray = new int[array.Length / 2];    
//     for(int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = array[i] * array[array.Length - 1 - i];        
//     }
//     return newArray;
// }

// Console.Write("Input a size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] numArray = CreateRandomArray(size, min, max);
// ShowArray(numArray);

// int[] newResult = FoundArray(numArray);
// ShowArray(newResult);



