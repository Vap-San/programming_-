﻿//Задача 5: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


const int MIN_ELEMENTS = 1;
const int MAX_ELEMENTS = 10;


int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

//Генерация массива числами из диапазона [minRandom .. minRandom]
int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random(); //для генерации случайных чисел предназначен класс «Random». 
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1); //Получить очередное случайное число 
    }
    return answer;
}

//Подсчет количества элементов массива, входящих в диапазон [start, end]
int[] ProductPairsNumbers(int[] array)
{
    int[] arrayProductPairs = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < arrayProductPairs.Length; i++)
    {
        arrayProductPairs[i] = array[i] * array[array.Length - i - 1];
    }
    return arrayProductPairs;
}

//Вывод массива на экран
void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine("] ");
}


//основная программа
int length = Prompt("Введите длину массива -> ");
int[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);

PrintArray(array);
PrintArray(ProductPairsNumbers(array));


