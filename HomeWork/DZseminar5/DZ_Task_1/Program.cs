//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


const int MIN_ELEMENTS = 100;
const int MAX_ELEMENTS = 1000;


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

//Подсчет количества четных элементов массива
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 ==0)
        {
            count++;
        }
    }
    return count;
}

//Вывод массива на экран
void PrintArray(int[] array)
{
    System.Console.Write("Массив: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.Write("]");
}


//основная программа
int length = Prompt("Введите длину массива -> ");
int[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);

System.Console.WriteLine("Количество четных элементов массива");
PrintArray(array);
System.Console.WriteLine($" -> {CountEvenNumbers(array)}");


