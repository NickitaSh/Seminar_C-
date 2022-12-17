// Задача №37
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

int[] array = GenArray(123,-100,100);//Генерация массива
PrintArray(array);//Печать массива
Console.WriteLine();//Перевод на новую строку печати
int[] result = ConvertArr(array);//Расчета и заполнения нового массива
PrintArray(result);//Печать полученного массива
Console.WriteLine();

//Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

//Метод печатае одномерный массив
void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

//Метод расчета и заполнения нового массива
int[] ConvertArr(int[] array)
{
    int[] outArr = new int[array.Length/2];
    for (int i = 0; i < array.Length/2; i++)
    {
        outArr[i]=array[i]*array[array.Length-1 -i];
    }
    return outArr;
}