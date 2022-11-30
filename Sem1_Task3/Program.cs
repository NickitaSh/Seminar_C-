//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if (inputLine != null)
{
    //    //Создаем массив с днями недели
    //    string[] dayOfWeek = new string[7];
    //    dayOfWeek[0] = "Понедельник";
    //    dayOfWeek[1] = "Вторник";
    //    dayOfWeek[2] = "Среда";
    //    dayOfWeek[3] = "Четверг";
    //    dayOfWeek[4] = "Пятница";
    //    dayOfWeek[5] = "Суббота";
    //    dayOfWeek[6] = "Воскресенье";
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    //   //Находим название дня недели по введенному номеру
    //   string outDayOfWeek = dayOfWeek[inputNumber-1];

    //Присваеваем переменной пустую строку
    string outDayOfWeek = string.Empty;
    
    //Оператор присваевает переменной имя дня недели взависимости от введенного числа.
    switch (inputNumber)
    {
        case 1: outDayOfWeek = "понедельник"; break;
        case 2: outDayOfWeek = "вторник"; break;
        case 3: outDayOfWeek = "среда"; break;
        case 4: outDayOfWeek = "четверг"; break;
        case 5: outDayOfWeek = "пятница"; break;
        case 6: outDayOfWeek = "суббота"; break;
        case 7: outDayOfWeek = "воскресенье"; break;
        default: outDayOfWeek = "Это не день недели"; break;
    }


    //Выводим день недели в консоль
    Console.WriteLine(outDayOfWeek);
}

