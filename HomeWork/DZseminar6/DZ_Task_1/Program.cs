//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


//Формируем массив чисел из строки чисел, введеных через пробел
int[] GenerateArray()
{
    Console.WriteLine("Введите через пробел целые числа и нажмите Enter");
    string[] nums = Console.ReadLine().Split(new char[] { ' ' }); //формируем массив строк, созданный из исходной строки (в качестве аргумента методу  передаем массив символов - разделителей
    int[] intArray = new int[nums.Length]; //создаем массив целых чисел размер которого совпадает с размером массива nums
    for (int i = 0; i < nums.Length; i++)
    {
        intArray[i] = int.Parse(nums[i]); //наполняем массив числами, используя метод Parse() у типа данных int, который возвращает целое число из строки
    }
    return (intArray);
}


//Вывод массива на экран
void PrintArray(int[] intArray)
{
    Console.WriteLine("Массив:");
    foreach (int value in intArray)
    {
        Console.Write($"{value} ");
    }
    Console.WriteLine();
}

int CountPositiveNumbers(int[] intArray)
{
    int count = 0;
    foreach (int value in intArray)
    {
        if (value > 0) count++;
    }
    return count;
}

//основная программа
int[] numbers = GenerateArray();
PrintArray(numbers);
Console.WriteLine($"Количество чисел больше 0 -> {CountPositiveNumbers(numbers)}");


