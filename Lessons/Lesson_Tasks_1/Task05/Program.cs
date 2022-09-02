//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4-> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2-> " -2, -1, 0, 1, 2"

int Promt(string message)
{
    System.Console.Write(message);
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    int value = int.Parse(strValue); //Преобразование строки в целое число 
    return value;
}


void Vyvod(int inNumber)
{
    for (int i = -inNumber; i <= inNumber; i += 1)
    {
        System.Console.Write($"{i} ");
    }
}

int Number = Promt("Введите целое число N -> ");

if (Number != 0)
{
    Vyvod(Math.Abs(Number));    
}
else
{
    System.Console.WriteLine("0");
}