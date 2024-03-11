// Задача 1: Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.
// int M = 1;
// int N = 5;
// void ShowNumbers(int M, int N)
// {
//     if (M == N)  
//     {
//         Console.Write(M);
//         return;
//     }
//     Console.Write(M + " ");
//     ShowNumbers(M + 1, N);
// }
// ShowNumbers(M, N); 

// int M = 4;
// int N = 8;
// void ShowNumbers(int M, int N)
// {
//     if (M == N)  
//     {
//         Console.Write(M);
//         return;
//     }
//     Console.Write(M + " ");
//     ShowNumbers(M + 1, N);
// }
// ShowNumbers(M, N); 


// // Задача 2: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Ack(int m, int n)
//         {
//             if (n == 0) 
//             {
//                 return m + 1;
//             }
//             else
//             {
//                 if (m == 0) 
//                 {
//                     return Ack(n - 1, 1);
//                 }
//                 else
//                 {
//                     return Ack(n - 1, Ack(n, m - 1));
//                 } 
//             }
//         }


// Задача 3: Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.


//  int [] array = new int[] {1, 2, 5, 0, 10, 34};
//  int Length = array.Length;
//         for (int i = 0; i <array.Length; i++)
//         {
//             Console.Write(array[Length-1] + " ");
//             Length = Length - 1;
//         }
