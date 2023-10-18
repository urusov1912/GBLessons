using System; 
using System.Collections.Generic;

var array = new List<int>();

int number = 346; // Заданное число 

// Первое задание "Нахождение второй цифры из трёхзначного числа"

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
        