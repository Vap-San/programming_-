﻿//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

const int N = 8;

int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArray(int[] inArray)
{
    int length = inArray.Length;
    for (int i = 0; i < length; i++)
    {
        inArray[i] = Promt($"Введите {i + 1} число -> ");
        // inArray[i] = new Random().Next(1, 11); //случайное число от 1 до 10
    }
    System.Console.WriteLine(); //отделим пустой строкой
}

void PrintArray(int[] outArray)
{
    int length = outArray.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($"{outArray[i]} ");
    }
}


int[] array = new int[N];
FillArray(array);

System.Console.WriteLine("Элементы массива:");
PrintArray(array);
