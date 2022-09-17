//Задача со звездочкой: Заполнить массив четной длины таким образом, чтобы значение элемента массива 
//повторялось ровно 2 раза.
//1,1,2,3,3,2,4,5,4,5
//или
//1,1,2,2,4,4,5,5
//или
//1,2,3,3,2,1

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

//Максимальный элемент массива
int MaximumElement(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"max = {max} ");
    return max;
}
//Минимальный элемент массива
int MinimumElement(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    System.Console.WriteLine($"min = {min} ");
    return min;
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

System.Console.WriteLine("Разница между максимальным и минимальным элементами массива");
PrintArray(array);
System.Console.WriteLine($"max - min = {MaximumElement(array) - MinimumElement(array)}");