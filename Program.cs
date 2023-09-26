// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// using System;

// class Program
// {
//     static void PrintNaturalNumbers(int N)
//     {
//         if (N == 0)
//             return;

//         Console.Write(N);

//         if (N > 1)
//             Console.Write(", ");

//         PrintNaturalNumbers(N - 1);
//     }

//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение N: ");
//         int N = int.Parse(Console.ReadLine());

//         Console.Write("Натуральные числа в промежутке от " + N + " до 1: ");
//         PrintNaturalNumbers(N);

//         Console.WriteLine();
//     }
// }

// ----------------------------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение M: ");
//         int M = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int N = int.Parse(Console.ReadLine());

//         int sum = CalculateSumOfNaturalNumbers(M, N);

//         Console.WriteLine("Сумма натуральных чисел в промежутке от " + M + " до " + N + " равна " + sum);
//     }

//     static int CalculateSumOfNaturalNumbers(int M, int N)
//     {
//         int sum = 0;
//         for (int i = M; i <= N; i++)
//         {
//             sum += i;
//         }
//         return sum;
//     }
// }

//----------------------------------------------------------------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int m1 = 2, n1 = 3;
//         int result1 = Ackermann(m1, n1);
//         Console.WriteLine($"A({m1}, {n1}) = {result1}");

//         int m2 = 3, n2 = 2;
//         int result2 = Ackermann(m2, n2);
//         Console.WriteLine($"A({m2}, {n2}) = {result2}");
//     }

//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (m > 0 && n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }
// }
