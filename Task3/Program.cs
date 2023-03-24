void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);
}
double findMin(double[] array)
{
    double min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    return min;
}
double findMax(double[] array)
{
    double max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
    return max;
}
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
findMin(array);
findMax(array);
Console.WriteLine($"[{string.Join("; ", array)}]");
Console.WriteLine($"Минимальное число в массиве: {findMin(array)}");
Console.WriteLine($"Максимальное число в массиве: {findMax(array)}");
Console.WriteLine($"Разница между ними: {Math.Round(findMax(array) - findMin(array),2)}");
