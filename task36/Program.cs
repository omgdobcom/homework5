// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Случаный массив: ");
var array = FillArray(5);
Print(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов на нечётных позициях равна: {SumOddPos(array)}");

int SumOddPos(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {   
        if(i % 2 != 0)
        {
            result= result + arr[i];
        }
    }
    return result;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void Print(int[] arr)
{
    foreach(var item in arr)
    {
        Console.Write($"{item}, ");
    }
}