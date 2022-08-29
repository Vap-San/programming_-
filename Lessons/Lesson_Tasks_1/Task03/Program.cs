//2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
// 5 -> Пятница
//Ввод числа по приглашению
int Promt(string message)
{
    System.Console.Write(message);
    string strValue = Console.ReadLine() ?? "0"; //?? "0" - если ничего не ввел, то ставим 0. Вводим числа как строки т.к. это консоль
    int value = int.Parse(strValue); //Преобразование строки в целое число 
    return value;
}
string Day_of_the_week(int day)
{
    string value = " Нет такого дня недели";
    if (day == 1) { value = "Понедельник"; }
    if (day == 2) { value = "Вторник"; }
    if (day == 3) { value = "Среда"; }
    if (day == 4) { value = "Четверг"; }
    if (day == 5) { value = "Пятница"; }
    if (day == 6) { value = "Суббота"; }
    if (day == 7) { value = "Воскресенье"; }
    return value;
}
int DayValue = Promt("Введите номер дня недели> ");

System.Console.WriteLine(Day_of_the_week(DayValue));