// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.WriteLine("Введите размер масива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];
FillArrayRandomNumbers(array);

Console.WriteLine("Массив: ");
PrintArray(array);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"всего {array.Length} чисел. Максимальное значение -> {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением -> {max - min}");

void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}