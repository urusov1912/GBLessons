﻿Console.Clear();

int xa = 1, ya = 1,
    xb = 1, yb = 20,
    xc = 80, yc = 1;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int i = 0;

while(i < 10000)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }              
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    i++;
}