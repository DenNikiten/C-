// Math work only with double
// Math.Pow(a,b) = a ** b
// Math.Sqrt(a) = корень(a)
// Math.Round(a,b) - округление a - число, b - сколько знаков хотим - 
// - использовать непосредственно перед WriteLine

// Task 1.
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// void ShowRange(int quadrant)
// {
//     if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
//     else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
//     else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
//     else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
//     else Console.WriteLine("Quadrant doesnot exist!");
// }

// Console.Write("Input a number of quadrant: ");
// int quadNum = Convert.ToInt32(Console.ReadLine());

// ShowRange(quadNum);

// Task 2.
// Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.

// void NumberQuadrant(double x, double y)
// {
//     if (x > 0 && y > 0) Console.WriteLine(1);
//     else if (x < 0 && y > 0) Console.WriteLine(2);
//     else if (x < 0 && y < 0) Console.WriteLine(3);
//     else if (x > 0 && y < 0) Console.WriteLine(4);
//     else Console.WriteLine(-1);
// }

// Console.Write("Input the coordinates of the x point not equal to zero: ");
// int numX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the coordinates of the y point not equal to zero: ");
// int numY = Convert.ToInt32(Console.ReadLine());

// NumberQuadrant(numX, numY);

// Task 2.
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.

// double Div(double x1, double y1, double x2, double y2)
// {
//     double x1x2 = x2 - x1;
//     double y1y2 = y2 - y1;

//     double len_xy = Math.Sqrt(x1x2 * x1x2 + y1y2 * y1y2);
//     return len_xy;
// }

// Console.Write("Input x1: ");
// double numX1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input y1: ");
// double numY1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input x2: ");
// double numX2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input y2: ");
// double numY2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Div(numX1, numY1, numX2, numY2));
// Task 3.
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// void Div(int N)
// {   
//     int count = 1;
//     while(count <= N)
//     {
//         // int num1;
//         // num1 = num * num;
//         Console.WriteLine($"The square of the number {count} is {count * count}");
//         count++;
//     }
// }

// Console.Write("Input a number N: ");
// int newNumber = Convert.ToInt32(Console.ReadLine());

// Div(newNumber);

// ------------------------------------------------
// неполное решение 1-го задания DZ_1, не получилось
// int PalindromeNumber(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     // return count;
//     int count2 = 1;
//     while (count2 > count)
//     {
//         firstNumber = num / (10 ** (count - 1));
//         lastNumber = num % 10;
//     }
// }

// Console.Write("Input a five-digit number: ");
// int newNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PalindromeNumber(newNumber));