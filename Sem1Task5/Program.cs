// Задача 5. Ввод-число N. Вывод-все целые числа от -N до N

//Считываем данные с консоли
string? inputLineNum = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLineNum != null)
{

    //Парсим введенное число
    int inputNum = int.Parse(inputLineNum);

    //Присваеваем новой переменной значение -N
    int startNum = inputNum * (-1);

    //Выходному значению присваеваем пустую строку
    string outLine = string.Empty;

    //Выполняем цикл пока выполняется условие startNum < inputNum
    while (startNum < inputNum)
    {
        //Меняем выходное значение 
        outLine = outLine + startNum + ", ";

        //Увеличиваем переменную на 1
        //startNum = startNum + 1
        startNum++;
    }

    //Меняем выходное значение 
    outLine = outLine + startNum;

    //Выводим данные в консоль
    Console.WriteLine(outLine);
}