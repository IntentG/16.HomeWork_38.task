/*Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.   [3 7 22 2 78] -> 76   */

Console.WriteLine("Укажите длину массива: ");
int sizeArray = int.Parse(Console.ReadLine());

int[] array = new int[sizeArray];
Random arrayRandomValue = new Random();
int temp = 0;
int differenceArrayValue = 0;

///Создание массива с указанной длиной:
Console.WriteLine(" Изначально несортированный массив:");
for (int i = 0; i < sizeArray; i++)
{
    array[i] = arrayRandomValue.Next(-100, 100);
    Console.Write($" | {array[i]}");
}

///Сортировка массива:
Console.WriteLine("\n \n Отсортированный массив массив:");
for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    Console.Write($" | {array[i]}");
}

differenceArrayValue = array[array.Length - 1] - array[0];

Console.WriteLine($"\n \n Разница между максимальным и минимальным элементом массива: ");
Console.WriteLine($" ({array[array.Length - 1]}) - ({array[0]}) = {differenceArrayValue}"); 
