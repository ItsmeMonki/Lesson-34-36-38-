// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();

int oddIndexes(int[] arg)
{
    int sum = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += arg[i];
        }
    }
    return sum;
}

void printArrya(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]}, ");
    }
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон случайных чисел от: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон случайных чисел до: ");
int numB = Convert.ToInt32(Console.ReadLine());

int[] arrya = new int[len];

for (int i = 0; i < arrya.Length; i++)
{
    arrya[i] = new Random().Next(numA, numB);
}
printArrya(arrya);
Console.WriteLine(oddIndexes(arrya));