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

    //Выходное значение
    string outLine = string.Empty;

    while (startNum < inputNum)
    {
        outLine = outLine + startNum + ", ";
        //startNum = startNum + 1
        startNum++;
    }
    outLine = outLine + startNum;
    
    //Выводим данные в консоль
    Console.WriteLine(outLine);
}