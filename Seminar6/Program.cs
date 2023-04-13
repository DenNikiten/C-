// Типы данных
// Значимые и ссылочные

// void ShowNum(int[] array)
// {
//     array[0] +=5;
//     Console.WriteLine(array[0]);
// }

// int[] myArray = {5, 6, 7};

// ShowNum(myArray);
// Console.WriteLine(myArray[0]);
// // 10
// // 10
// // ссылочный тип данных - в массивах, когда мы его отправляем,
// // мы отпарвляем не его самого, а ссылку на него, и все изменения с ним
// // отразятся на выходе

// Task 1.
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void ReverseArray(int[] array)
// {
//     for(int left = 0, right = array.Length - 1; left < right; left++, right--)
//     {
//         int temp = array[left];
//         array[left] = array[right];
//         array[right] = temp;
//     }
// }

// int[] myArray = {1, 2, 3, 4, 5};

// ReverseArray(myArray);

// for(int i = 0; i < myArray.Length; i++)
//     Console.Write(myArray[i] + " ");


// Task 2.
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// bool Triangle(int a, int b, int c)
// {
//     if(a + b > c && a + c > b && b + c > a)
//         return true;
//     return false;
// }

// Console.Write("Input num A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num C: ");
// int numC = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Triangle(numA, numB, numC));


// Task 3.
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// int[] FibonacciArray(int N)
// {
//     int[] array = new int[N];
//     array[0] = 0;
//     array[1] = 1;
//     for(int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i-1] + array[i-2];
//     }
//     return array;
// }

// // void ShowArray(int[] array)
// // {
// //     for(int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write(array[i] + " ");
// //     }
// // }

// Console.Write("Print the first N Fibonnaci numbers: ");
// int numFib = Convert.ToInt32(Console.ReadLine());

// int[] numArray = FibonacciArray(numFib);
// // ShowArray(numArray);

// for(int i = 0; i < numArray.Length; i++)
// {
//     Console.Write($"{i} Fibonnaci numbers equale {numArray[i]}");
//     Console.WriteLine();
// }

// Task 4.
// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

// int[] GenetareNewArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] array = {1, 8, 15, 3, 4, 9};

// int[] res = GenetareNewArray(array);

// ShowArray(res);



// mathprofi