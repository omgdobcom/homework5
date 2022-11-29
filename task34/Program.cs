//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Случаный массив: ");
var array = FillArray(10);
Print(array);
Console.WriteLine();
Console.WriteLine($"Количесвто чётных числев в масивве: " + EvenAmount(array));
int EvenAmount(int[] arr)
{
    var amount = 0;
    foreach(var item in arr)
    {
        if(item % 2 ==0)
        {
            amount++;
        }
    }
    return amount;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}