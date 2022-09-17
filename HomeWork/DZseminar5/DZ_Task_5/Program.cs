//Задача со звездочкой: Заполнить массив четной длины таким образом, чтобы значение элемента массива повторялось ровно 2 раза.
//1,1,2,3,3,2,4,5,4,5
//или
//1,1,2,2,4,4,5,5
//или
//1,2,3,3,2,1

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

//Заполнение массива числами с клавиатуры - это числа, для которых будем делать пары
int[] GenerateArray(int length)
{
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = Prompt($"Введите {i+1} число -> ");
    }
    return answer;
}
//Генерация массива парами 
//В int[] numArray находятся сами числа для которых нужно сделать пары
int[] GenerateArrayRndPair(int length, int[] numArray)
{
    Random rnd = new Random(); //для генерации случайных чисел предназначен класс «Random». 
    
    int[] answer = new int[length];
    
    int i = rnd.Next(0, length); //генерируем случайно индекс первого числа 
    
    for (int k = 0; k < numArray.Length; k++) //Пока не обработаем массив с числами - первыми половинками пар
    {
        for (int j = 1; j <= 2; j++) // вставляем 2 числа в произвольные ячейки массива
        {
            while (answer[i] != 0) i = rnd.Next(0, length); //Пока не найдем свободное место для вставки числа
            answer[i] = numArray[k]; //Вставляем элемент из массива данных чисел
        }
        PrintArray(answer); //Печатаем для просмотра очередного этапа заполнения массива парами
    }
    return answer;
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
    System.Console.WriteLine();
}


//основная программа
int length = Prompt("Введите количество чисел (без удвоения длины массива) -> ");
int[] numberArray = GenerateArray(length); //заполнение массива числами для которых будем формировать пары
int[] array = GenerateArrayRndPair(2 * length, numberArray);//Формируем массив пар

//PrintArray(array);



