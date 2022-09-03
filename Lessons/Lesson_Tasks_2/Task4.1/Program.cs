//4.1. Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, 
//кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
//Введенное число 2
//13 -> нет 
//15 -> нет 
//12 -> да


int Promt(string message)
{
    System.Console.Write(message);
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное число невозможно перевести в целое число");
}

void FillArray(int[] inArray)
{
    int length = inArray.Length;
    int index = 0;
    while (index < length)
    {
        inArray[index] = new Random().Next(1, 1001); //случайное число от 1 до 1000
        index++;
    }
}

void PrintArray(int[] outArray)
{
    int length = outArray.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($"{outArray[i]} ");
    }
}


int count = Promt("Введите количество чисел -> ");
int[] array = new int[count];
FillArray(array);

System.Console.WriteLine("Последовательность случайных чисел:");
PrintArray(array);
System.Console.WriteLine();

int Number = Promt("Введите число -> ");
int index = 0;
int length = array.Length;
while (index < length)
{
    if (array[index] % Number == 0)
    {
        System.Console.WriteLine($"{array[index]} -> да");
        break;
    }
    else
    {
        System.Console.WriteLine($"{array[index]} -> нет");
    }
    index++;
}
