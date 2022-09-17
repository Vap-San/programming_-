//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

const int MIN_ELEMENTS = -100;
const int MAX_ELEMENTS = 100;


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

//Сумма элементов массива, стоящих на нечетных местах
int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i+1) % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
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

System.Console.WriteLine("Сумма элементов массива, стоящих на нечетных местах");
PrintArray(array);
System.Console.WriteLine($" -> {SumOddIndex(array)}");