//Задача №20
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод расчета расстояния между точками
double CalculateLength(int x1, int x2, int y1, int y2)
{
    double res = 0;

    //Расчет расстояния между точками
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

    //Возвращаем значение расстояния в переменную res
    return res;
}

//Метод вывода значения расстояния между точками
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//Вывод координат с помощью метода ReadData
int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");

//Вывод расстояния между точками с помощью метода PrintData
//(внутри обращение к методу расчета расстояния)
PrintData("Расстояние между точками ", CalculateLength(x1, y1, x2, y2));




