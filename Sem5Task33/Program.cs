//Задача №33
//Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

// // Заполняем массив
// int[] GenArray(int len, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return arr;
// }
// //Печатае одномерный массив
// void Print1DArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1]);
// }
// // Чтение данных из консоли
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.WriteLine(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }
// // Печать результата
// void PrintData(string res, int value)
// {
//     Console.WriteLine(res + value);
// }

int[] array = GenArray(10, -9, 10);//Генерация массива
Print1DArr(array);//Печать массива
int num = ReadData("Введите число");//Ввод числа
int result = SearchElem(array, num);//Поиск числа

if (result >= 0)
{
    PrintData("Элемент найден в позиции: " + result);
}
else
{
    PrintData("В массиве элемент не найден!");
}

//Метод чтения данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод печати введенных данных
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод печатает массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод ищет заданный элемент
int SearchElem(int[] arr, int elem)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elem)
        {
            res = i;
            break;
        }
    }
    return res;
}