void SredneeArf(int[] collection) 
{
    double sum = 0;

    for (int index = 0; index < collection.Length; index++)
    {
        sum = sum + collection[index];
        index++;
    }
    Console.WriteLine($"Среднее арифметическое данного списка {sum / collection.Length}");
}

void FillArray(int[] collection)
{
    int count = collection.Length;
    for (int index = 0; index < count; index++)
    {
        collection[index] = new Random().Next(1, 100); // Заполнение списка рандомом
    }
}

void FillArrayReadLine (int [] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine()); // Заполнение списка с клавиатуры
    }
}

void PrintArray(int[] col)
{
    for (int index = 0; index < col.Length; index++)
    {
        Console.Write(col[index]);
        Console.Write(",");
    }
}

void maxVolue(int[] collection)
{
    int count = collection.Length;
    int max = 0;
    for(int index = 0; index < count; index++)
    {
        if (collection[index] > max) max = collection[index];
    }
    Console.WriteLine($"Максимально число {max}");
}

void ArrayCorrect(int[] collection)
{
    int count = collection.Length;

    for (int index = 0; index < count; index++)
    {
        for (int i = 0; i < count - 1 - index; i++)
        {
            if (collection[i] > collection[i + 1])
            {
                int temp = collection[i];
                collection[i] = collection[i + 1];
                collection[i + 1] = temp;
            }
        }
    }
    for (int j = 0; j < count; j++)
    {
        Console.Write(collection[j]);
        Console.Write(",");
    }
}

// int[] array = new int[20];
int[] array = new int[10];

// FillArray(array); // Передали значения функции заполнения списка
FillArrayReadLine(array);
PrintArray(array); // Передали значения в функцию для распечатывания списка
Console.WriteLine(); // Пробел
SredneeArf(array); // Среднее арифметическое
maxVolue(array); // Максимальное значение из списка
ArrayCorrect(array); // Скоректированный список
