/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2   */

int[] array = GetArray(4, 100, 999);
int count = 0;

foreach (int number in array)
{
    if(number % 2 == 0)
    {
        count ++;
    }
}

Console.WriteLine($"[{String.Join(",", array)}] -> Количество четных чисел в массиве {count}");

//-----Метод------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;

}

