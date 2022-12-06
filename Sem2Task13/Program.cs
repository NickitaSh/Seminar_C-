//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

//Ввод переменной и проверяем на ноль
int inputNum = int.Parse(Console.ReadLine() ?? "0");
if (inputNum > 99)
{
    //Переводим число в массив символов
    char[] digit = inputNum.ToString().ToCharArray();
    Console.WriteLine(digit[2]);
}
else
{
   Console.WriteLine("В этом числе нет третьей цифры"); 
}
