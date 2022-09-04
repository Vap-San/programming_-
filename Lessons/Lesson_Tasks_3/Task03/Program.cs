//Задача 3: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21


//int Promt(string message) ввод целого числа
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


//double Distance(int cx1, int cy1, int cx2, int cy2) - определяет расстояние между двумя точками
double Distance(int cx1, int cy1, int cx2, int cy2)
{
return Math.Sqrt(Math.Pow(cx2-cx1,2)+Math.Pow(cy2-cy1,2));
}

//Основная программа

int x1 = Promt("Введите абциссу х первой точки -> ");
int y1 = Promt("Введите ординату y первой точки -> ");
int x2 = Promt("Введите абциссу х второй точки -> ");
int y2 = Promt("Введите ординату y второй точки -> ");
System.Console.Write($"A({x1},{y1}), B({x2},{y2}) -> {Distance(x1,y1,x2,y2):f2}");
