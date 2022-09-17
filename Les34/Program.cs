// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

int even(int[] arg)
{
    int score = 0;

    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] % 2 == 0)
        {
            score += 1;
        }
    }
    return score;
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

int[] arrya = new int[len];

for (int i = 0; i < arrya.Length; i++)
{
    arrya[i] = new Random().Next(100, 1000);
}

printArrya(arrya);
int count = even(arrya);
Console.WriteLine(count);