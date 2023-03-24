void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}
int summa(int[] array)
{
int sum = 0;
int i = 1;
while (i < array.Length)
{
sum = sum + array[i];
i = i + 2;
}
return sum;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write($"Cумма элементов, стоящих на нечётных позициях: {summa(array)}");