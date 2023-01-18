/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2   */

/*int[] array = GetArray(4, 100, 999);
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

}*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0    */


/*int[] array = GetArray(5);
int sum = 0;
int size =5;

for (int z = 1; z < size; z+=2)
    sum = sum + array[z];

    Console.WriteLine($"Массив: [{String.Join(",", array)}], сумма элементов на нечётных позициях = {sum}");


//-----Метод------
int[] GetArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(10, 100);
    }
    return Array;
}*/


/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21  */

int[] Array = GetArray(8);
Console.WriteLine($"Исходный Массив: [{String.Join(",", Array)}]");

int[] GetArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1, 10);
    }
    return Array;
}

int[] array2 = GetArray2(Array.Length/2);
int[] GetArray2(int size)
{
    int[] array2 = new int[size];
    for (int i = 0; i < size; i++)
    {
        array2[i] = (Array[i] * Array[Array.Length-i-1]);
    }
    return array2;
}
Console.WriteLine($"Новый Массив: [{String.Join(",", array2)}]");
