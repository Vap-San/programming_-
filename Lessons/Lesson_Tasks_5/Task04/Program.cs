//Задача 4: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


const int MIN_ELEMENTS = 1;
const int MAX_ELEMENTS = 1000;
const int START_ELEMENTS = 10;
const int END_ELEMENTS = 99;

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
int CountElement(int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end)
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

System.Console.WriteLine($"Количество элементов массива лежащих в отрезке [{START_ELEMENTS},{END_ELEMENTS}]");
PrintArray(array);
System.Console.WriteLine($" -> {CountElement(array, START_ELEMENTS, END_ELEMENTS)}");


