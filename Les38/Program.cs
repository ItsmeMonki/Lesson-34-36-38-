// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();

double posMax(double[] arg)
{
    double max = arg[0];
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] > max) max = arg[i];
    }
    return max;
}

double posMin(double[] arg)
{
    double min = arg[0];
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] < min) min = arg[i];
    }
    return min;
}

void printArrya(double[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]}, ");
    }
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());

double[] arrya = new double[len];

for (int i = 0; i < arrya.Length; i++)
{
    arrya[i] = new Random().Next(1, 101);
}

double diff = posMax(arrya) - posMin(arrya);

printArrya(arrya);
Console.WriteLine(posMax(arrya));
Console.WriteLine(posMin(arrya));
Console.WriteLine(diff);