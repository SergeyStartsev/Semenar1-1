// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[5];
// int sumPositive = 0;
// int sumNegative = 0;
// Random rand = new Random();
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9, 10);
// }
// Console.WriteLine('[' + string.Join(", ", array) + ']');
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0)
//     {
//         sumPositive += array[i];
//     }
//     else
//     {
//         sumNegative += array[i];
//     }
// }
// Console.WriteLine($"Сумма положительных чисел = {sumPositive}, отрицательных = {sumNegative}");

//С ипользованием функции

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int [] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void sumPositiveAndsumNegative(int[] arr, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            sumPositive += arr[i];
        }
        else
        {
            sumNegative += arr[i];
        }
    }
}

int[] array = FillArray(5,-9,9);
sumPositiveAndsumNegative(array, out int sumP, out int sumN);
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Сумма положительных чисел = {sumP}, отрицательных = {sumN}");