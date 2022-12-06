﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа

//Ввод переменной и проверяем на ноль
int inputNum = int.Parse(Console.ReadLine() ?? "0");

//Проверяем является ли число трехзначным
if (inputNum < 1000 && inputNum > 99)
{
    //Вычисляем вторую цифру числа и выводим на консоль
    Console.WriteLine((inputNum / 10) % 10);
}
else
{
    Console.WriteLine("Число не трехзначное");
}