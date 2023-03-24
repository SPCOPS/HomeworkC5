void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
int CheckNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int ost = array[i] % 2;
        if (ost == 0)
            count++;
    }
    return count;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Число элементов: {CheckNumber(array)}");