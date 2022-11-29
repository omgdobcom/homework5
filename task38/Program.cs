// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

System.Console.WriteLine("Рандомный массив:");
var array = FillArray(10);
Print(array);
System.Console.WriteLine();
System.Console.WriteLine("Разница между максимальным и минимальным  значениями массива: " + (DiffMaxMin(array)));

double DiffMaxMin (double[] arr)
{
    int maxNum = 0;
    int minNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > arr[maxNum])
        {
            maxNum = i;
        }
        else if (arr[i] < arr[minNum])
        {
            minNum = i;
        }
    }    
    double result = arr[maxNum] - arr[minNum];
    return result;
}

double[] FillArray(int length)
{
    double[] array = new double[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void Print(double[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}
