//Функция Ввода числа по приглашению (message)
int Promt(string message)
{
    System.Console.Write(message); //Выводим строчку, которую передали из программы
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    int value = int.Parse(strValue); //Преобразование число-строку в целое число 
    return value;                    //Возвращаем в программу целое число
}
int value = Promt("Введите число > ");
int result = value * value;
System.Console.WriteLine($"Квадрат числа {value} равен {result}"); //$ пишется слитно с кавычками, иначе ошибка. $ - автоподстановка, вместо переменных подставляется их значения