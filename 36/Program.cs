// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
    }
    System.Console.WriteLine(string.Join(" ", array));
}

int SumArray(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = new int[10];
RandomArray(array);
int sum = SumArray(array);
System.Console.WriteLine(sum);