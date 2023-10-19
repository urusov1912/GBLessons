 // Первое задание: Нахождение второй цифры из трёхзначного числа

int number = Prom("Введите значение: ");

int Prom(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

if (number < 100)
{
    Console.WriteLine("Введите трёхзначное число");
}
else
{
    number %= 10;
    Console.WriteLine("Третья цифра - " + number);
}        

// Второе задание: Программа по нахождению третьей цифры заданного числа

number = Prom("Введите значение: ");

if (number < 100) Console.WriteLine("Третьей цифры нету");
else
{
    while(number > 999)
    {
        number /= 10;
    }
    Console.WriteLine("Третья цифра данного числа: " + number % 10);
}

// Третье задание: Программа на проверку, является ли задданая цифра выходным днём

number = Prom("Введите цифру дня недели: ");

if (number > 7) Console.WriteLine("Такого дня не существует");
else 
{
    if (number == 6 || number == 7) Console.WriteLine("Этот день является выходным");
    else Console.WriteLine("Этот день не является выходным");
}

