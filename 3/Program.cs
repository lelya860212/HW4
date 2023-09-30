// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//using System;
Random rand = new Random();
int[] Arr=new int[8];
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i]=rand.Next();
    Console.WriteLine(Arr[i]);
}