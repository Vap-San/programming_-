//. Напишите программу вычисления модуля числа.
// 2-> 2
// - 3-> 3
// - 7-> 7


double Promt(string message)
{
    System.Console.Write(message);
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    double value = double.Parse(strValue); //Преобразование строки в целое число 
    return value;
}


double Reverse(double inNumber)
{
    return 1/inNumber;    
}

double Number = Promt("Введите целое число N -> ");

if (Number != 0)
{
System.Console.WriteLine(Reverse(Number));    
}
else
{
System.Console.WriteLine("Ошибка! На ноль делить нельзя");    
}


