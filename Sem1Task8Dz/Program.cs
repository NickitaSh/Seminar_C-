// Задача 8. Ввод- число N. Вывод- все четные числа от 0 до N.

//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLine != null)
{
    //Парсим введенное число
    int inputNum = int.Parse(inputLine);

    //Вводим переменную равную числу с которого начинаем.
    int outputNum = 1;

    //Выполняем цикл пока выполняется условие inputNum > outputNum 
    while (inputNum > outputNum)
    {

        //Проверяем условие, равен ли остаток 0 при делении на 2
        if (outputNum % 2 == 0)
        {
            //Если остаток равен нулю, вывод на консоль 
            Console.Write(outputNum + ", ");

            //Увеличиваем переменную на 1
            outputNum++;
        }
        //Увеличиваем переменную на 1
        outputNum++;
    }
}