﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//Значения b1, k1, b2 и k2 задаются пользователем.

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(int x ,int y)
{
    if (x != 0)
    {
        Console.WriteLine("Координата точки пересечения: " + "x=" + x + " " + "y=" + y);
    }
    else
    {
       Console.WriteLine("Прямые не пересекаются");
    }
}

//Метод расчета координат точки пересечения прямых
int CrossPointX(int k1, int k2, int b1, int b2)
{
    int x = 0;
    if (k1 == k2) 
    {
        x = 0;
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
    }
    return x;
}

//Метод расчета координат точки пересечения прямых
int CrossPointY(int x, int k1, int b1)
{
    int y = 0;
    if (x != 0) y = k1 * x + b1;
    return y;
}

int k1 = ReadData("Введите параметр k1 для первой прямой: "); //Ввод параметров для прямых
int b1 = ReadData("Введите параметр b1 для первой прямой: "); //Ввод параметров для прямых
int k2 = ReadData("Введите параметр k2 для второй прямой: "); //Ввод параметров для прямых
int b2 = ReadData("Введите параметр b2 для второй прямой: "); //Ввод параметров для прямых
int x = CrossPointX(k1, k2, b1, b2);//Расчет координаты x
int y = CrossPointY(x, k1, b1);//Расчет координаты y
PrintData(x,y);//Печать результата