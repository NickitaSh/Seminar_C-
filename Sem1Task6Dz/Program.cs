// Задача 6. Ввод- число. Вывод- является ли число четным.

//Считываем данные с консоли
string? inputLineNum = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLineNum != null)
{
    //Парсим введенное число
    int inputNum = int.Parse(inputLineNum);

    //Вводим новую переменную равную остатку при делении на два
    int remainder = inputNum % 2;
    if (remainder == 0)
    {
       //Если остаток равен нулю, вывод на консоль "Четное число"
       Console.WriteLine(inputNum+"-Четное число"); 
    }
    else
    {
        //Если остаток не равен нулю, вывод на консоль "Нечетное число"
        Console.WriteLine(inputNum+"-Нечетное число");
    }
}