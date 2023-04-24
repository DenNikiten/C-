// Seminar 9.

// Рекурсия - самовызов, вызов самого себя внутри реализации
// оптимизация по скорости выполнения, но не по памяти
// алгоритмы сортировок

// Task 1.
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.

// void ShowNums(int num)
// {
//     Console.Write(num + " ");
//     // 5 4 3 2 1 
//     if(num > 1) ShowNums(num - 1);
//     Console.Write(num + " ");
//     // 1 2 3 4 5
// }

// ShowNums(5);

// Task 2.
// Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.

// int SumOfDigits(int num)
// {
//     if(num != 0) return SumOfDigits(num / 10) + num % 10;
//     else return 0;
// }

// Console.WriteLine(SumOfDigits(1234));

// return выполняется в последнюю очередь, после выполнения команды
// справа от нее

// f(1234) -> f(123) + 4
// f(123) -> f(12) + 3
// f(12) -> f(1) + 2
// f(1) -> f(0) + 1
// f(0) -> 0
// f(1) -> 0 + 1 = 1
// f(12) -> 1 + 2 = 3
// f(123) -> 3 + 3 = 6
// f(1234) -> 6 + 4 = 10

// Task 3.
// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

// void ShowNums(int M, int N)
// {    
//     if(M > N) 
//     {   
//        Console.Write(M + " ");
//        ShowNums(M - 1, N);             
//     }
//     if(M < N)
//     {
//         ShowNums(M, N - 1);
//         Console.Write(N + " ");        
//     }

//     if(M == N)
//     {
//         Console.Write(N + " ");
//     }

// }

// ShowNums(7, 2);

// Task 4.
// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B.

// double MathFunc(int A, int B)
// {
//     if(B > 0) return MathFunc(A, B - 1) * A;

//     else if(B < 0) return MathFunc(A, B + 1) / A;

//     else return 1;
// }

// Console.WriteLine(MathFunc(2, -2));