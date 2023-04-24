// HomeWork 9.

// Task 1.
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// void ShowNums(int num)
// {
//     Console.Write(num + " ");
//     if(num > 1) ShowNums(num - 1);
// }

// ShowNums(8);


// Task 2.
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// int SumNums(int M, int N)
// {
//     if(M < N) return SumNums(M + 1, N) + M;

//     else if(M > N) return SumNums(M, N + 1) + N;

//     else return N;
// }

// Console.WriteLine(SumNums(2, 6));


// Task 3.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// int AckermanFunction(int m, int n)
// {
//     if(m == 0) return n + 1;
//     else if (m != 0 && n == 0) return AckermanFunction(m - 1, 1);
//     else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
// }

// Console.WriteLine(AckermanFunction(3, 2));