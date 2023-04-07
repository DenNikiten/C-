// Seminar 4.

// Task 1.
// Необходимо написать программу, которая принимает на вход число (A)
// и выдает сумму чисел от 1 до А.

// int GetSum(int num)
// {
//     int sum = 0;

//     for(int current = 1; current <= num; current++)
//     {
//         sum = sum + current;
//     }
//     return sum;
// }

// Console.Write("Input a number: ");
// int newNumber = Convert.ToInt32(Console.ReadLine());

// int res = GetSum(newNumber);
// Console.WriteLine($"Sum of numbers from 1 to {newNumber} is {res}");

// ++current - сначала она выполняется, потом все остальное
// current++ - последней выполняется

// Task 2.
// Написать программу которая принимает на вход число 
// и возвращает количество цифр в числе

// int NumberDigits(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// Console.Write("Inpute a number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int res = NumberDigits(n);
// Console.WriteLine(res);

// Task 3.
// Написать программу которая принимает на вход число N 
// и выдает произведение чисел от 1 до N

// int ProductNumbers(int num)
// {
//     int pro = 1;
//     for (int current = 1; current < num; current++)
//     {
//         pro = pro * (current + 1);
//     }
//     return pro;
// }

// Console.Write("Inpute a number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int res = ProductNumbers(n);
// Console.WriteLine(res);


// Массив
// 
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)   // i = i + 2 по каждому второму
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     // maxValue + 1 - для того, чтобы включалось значение
//     }
//     return array;
// }
// // вывод массива
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
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

