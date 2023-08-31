// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void AdditArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    System.Console.WriteLine(string.Join(" ", array));
}

int Counter(int[] array)
{
    int counetr = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counetr++;
        }
    }
    return counetr;
}

int[] array = new int[7];
AdditArray(array);
int counter = Counter(array);
System.Console.WriteLine(counter);