// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void RandomDoubleArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double number = random.Next(0, 100) / 1.3;
        array[i] = Math.Round(number, 2);

    }
    System.Console.WriteLine(string.Join(" ", array));
}

double DifferenceMaxMin(double[] array)
{
    double max = array[0];

    double min = array[0];

    double result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
        result = max - min; 
    }
    return result;
}

double[] array = new double[10];

RandomDoubleArray(array);

double result = DifferenceMaxMin(array);

System.Console.WriteLine(result);
