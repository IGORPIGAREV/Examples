﻿Console.Clear();//команда все стерает
// Console.SetCursorPosition(10,4); команда делает отступы
// Console.WriteLine("+"); рисуем плюсики
int xa = 30,  ya = 1,
    xb = 1,   yb = 20,//почемуто ограничение отступа 20
    xc = 60,  yc = 20;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");


int x = xa, y = ya;

int count = 0;
while(count < 1000)
{
    int what = new Random().Next(0, 3);// случайное число от 0 до 2
    if (what ==0)
    {
        x=(x + xa)/2;
        y=(y + ya)/2;
    }
    if (what ==1)
    {
        x=(x + xb)/2;
        y=(y + yb)/2;
    }
    if (what ==2)
    {
        x=(x + xc)/2;
        y=(y + yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
