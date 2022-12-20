// Задача №40 
//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

// int a = ReadData("Введите первое число: ");
// int b = ReadData("Введите второе число: ");
// int c = ReadData("Введите третье число: ");

// if (TriangleTest(a, b, c)) PrintData("Может существовать треугольник сo сторонами такой длины.");
// else PrintData("Треугольник сo сторонами такой длины не существует.");

// //Метод, считывающий данные, введенные пользователем
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод, выводящий на печать данные пользователю
// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }

// Метод проверяет существование треуг. со сторонами a,b,c
// bool TriangleTest(int a, int b, int c)
// {
//     return ((a + b > c) && (a + c > b) && (b + c > a));
// }
int A = ReadData("Enter first number: "); //Ввод данных
int B = ReadData("Enter second number: ");//Ввод данных
int C = ReadData("Enter third number: "); //Ввод данных
PrintData ("Result: "  + TriangleTest(A,B,C)); //Печать результата(внутри метод тест на треуг.)

//Метод считывает  данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод проверяет существование треуг. со сторонами a,b,c
bool TriangleTest (int a, int b, int c)
{
    return ((a+b>c)&& (a+c>b)&& (b+c>a));
}