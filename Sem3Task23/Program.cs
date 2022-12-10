//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

//Вывод координат с помощью метода ReadData
int number = ReadData("Введите число: ");

//Сборка строки чисел в первой стпени с помощью метода LineBuilder
string outLine = LineBuilder(number, 1);

//Вывод строки с помощью метода PrintData
PrintData("", outLine);

//Сборка строки чисел во третьей стпени с помощью метода LineBuilder
outLine = LineBuilder(number, 3);

//Вывод строки с помощью метода PrintData
PrintData("", outLine);

// Метод вывода данных
void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}

// Метод сборки строки чисел в n-ой степени
string LineBuilder(int n, int pow)
{
    string line = string.Empty;
    for (int i = 1; i < n; i++)
    {
        line = line + Math.Pow(i, pow) + " ";
    }
    line = line + Math.Pow(n, pow);
    return line;
}

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}