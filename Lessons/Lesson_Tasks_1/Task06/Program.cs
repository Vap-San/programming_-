//. Напишите программу вычисления модуля числа.
// 2-> 2
// - 3-> 3
// - 7-> 7


int Promt(string message)
{
    System.Console.Write(message);
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    int value = int.Parse(strValue); //Преобразование строки в целое число 
    return value;
}


int Abs(int inNumber)
{
    if (inNumber < 0)
    {
        return -inNumber;
    }
    else
    {
        return inNumber;
    }

}

int Number = Promt("Введите целое число N -> ");

System.Console.WriteLine(Abs(Number));

