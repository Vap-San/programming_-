//Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
const int MIN_ELEMENTS = -9;
const int MAX_ELEMENTS = 9;
const int NEGATIVE_VALUE = -1;
const int POSITIVE_VALUE = 1;


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

//Подсчет суммы элементов с флагом, POSITIVE_VALUE - положительных, NEGATIVE_VALUE -отрицательных
int SumElements(int[] array, int sign=POSITIVE_VALUE) //int sign=POSITIVE_VALUE - значение по умолчанию
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]*sign > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

//Вывод массива на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t"); //вставляем знак табуляции после вывода значения элемента массива
}
    System.Console.WriteLine();
}


//основная программа
int length = Prompt("Введите длину массива -> ");
int[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
System.Console.WriteLine($"Сумма положительных элементов масства равна -> {SumElements(array)}"); //Если параметр не задан, то подставляется значение по умолчанию
System.Console.WriteLine($"Сумма отрицательных элементов масства равна -> {SumElements(array, NEGATIVE_VALUE)}");



