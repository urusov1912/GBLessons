// Работа с числами(Среднее арифметическое, и тд)

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





// Задачи ко второму семинару

using System; 
using System.Collections.Generic;

var array = new List<int>();

int number = 346; // Заданное число 

// Первое задание "Нахождение второй цифры из трёхзначного числа"

int prog1 (string message)
{
    Console.Write(message);
    string value = Console.Readline();
    int 
}

if (number > 99 && number < 1000)
{
    int result = number % 100 / 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введите трёхзначное число");
}


// Второе задание: Нахождение третьей цифры заданного числа

if (number > 99 && number < 100000)
{
    int div = 1;
    int digit_count = 1;

    while(div <= number / 10)
    {
        digit_count++;
        div *= 10;
    }

    int length = digit_count;

    for (int i = 0; digit_count > 0; i++)
    {
        array.Add(number / div);
        number %= div;
        div /= 10;
        digit_count --;
    }
    foreach (int element in array)
    {
       Console.Write(element);
    }
    Console.Write(" Третий элемент: " + array[2]);
}

else
{
    Console.WriteLine("Третьего элемента нет");
}

// Третье задание: Проверить является ли заданная цифра выходным днём

int day = 6;
if (day == 6 || day == 7) Console.WriteLine("Этот день является выходным");
else Console.WriteLine("Этот день не является выходным");
        