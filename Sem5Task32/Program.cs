//Задача №32
//Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.

int[] array = GenArray(10, -9, 9); //Генерация массива
Print1DArr(array);               //Печать массива
int[] newArray = InverseArr(array); //Создание массива с противоположными знаками элементов
Print1DArr(newArray);               //Печать массива с противоположными знаками элементов

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
//Метод печатае одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод меняет знак элементов массива на противоположный
int[] InverseArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[i] * (-1);
    }
    return outArr;
}