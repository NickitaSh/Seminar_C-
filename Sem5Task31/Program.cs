//Задача №31
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

{
    int posetivSum = 0;
    int negotivSum = 0;

    int[] testArr = GenArray(12, -9, 9); //Генерация массива
    NegotivPosetivSum(testArr);          //Расчет суммы
    Print1DArr(testArr);                 //Печать массива 
    PrintData("Сумма положительных чисел в массиве: ", posetivSum); //Расчет суммы положительных чисел
    PrintData("Сумма отрицательных чисел в массиве: ", negotivSum); //Расчет суммы отрицательных чисел

    //Метод генерации массива
    int[] GenArray(int len, int minValue, int maxValue)
    {
        Random rnd = new Random();
        int[] arr = new int[len];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(minValue, maxValue + 1);
        }
        return arr;
    }

    //Метод вывода результата
    void PrintData(string res, int value)
    {
        Console.WriteLine(res + value);
    }

    //Метод для нахождения суммы отрицательных и положительных элементов массива.
    void NegotivPosetivSum(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                posetivSum += arr[i];
            }
            else
            {
                negotivSum += arr[i];
            }
        }
    }

    //Печатает одномерный массив
    void Print1DArr(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1]);
    }
}