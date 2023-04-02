// HomeWork 3.

// Task 1.
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// Сделал только с 5-ти значным числом. Пытался и другие варианты сделать: 
// не переводя с строку подсчитывал количество букв с помощью цикла, затем
// первую и последнюю цифры сравнивал и т.д.

// bool PalindromeNumber(int num)
// {
//     int num1 = num % 10;
//     num = num / 10;
//     int num2 = num % 10;
//     num = num / 10;
//     int num3 = num % 10;
//     num = num / 10;
//     int num4 = num % 10;
//     num = num / 10;
//     int num5 = num;

//     if (num1 == num5 && num2 == num4)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }

// }

// Console.Write("Input a five-digit number: ");
// int newNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PalindromeNumber(newNumber));

// Task 2.
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// double DistanceSpace(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double x1x2 = x2 - x1;
//     double y1y2 = y2 - y1;
//     double z1z2 = z2 - z1;

//     double len_xyz = Math.Sqrt(x1x2 * x1x2 + y1y2 * y1y2 + z1z2 * z1z2);
//     return len_xyz;
// }

// Console.Write("Input x1: ");
// int numX1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input y1: ");
// int numY1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input z1: ");
// int numZ1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input x2: ");
// int numX2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input y2: ");
// int numY2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input z2: ");
// int numZ2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(DistanceSpace(numX1, numY1, numZ1, numX2, numY2, numZ2), 2));

// Task 3.
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// void CubesNumbers(int N)
// {
//     int count = 1;
//     while (count <= N)
//     {
//         Console.WriteLine($"The cube of the number {count} is equal to {count * count * count}");
//         count++;
//     }
// }

// Console.Write("Input a number N: ");
// int newNumber = Convert.ToInt32(Console.ReadLine());

// CubesNumbers(newNumber);