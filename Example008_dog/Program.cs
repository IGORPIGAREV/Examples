// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double distanse  =10000;
int count = 1,
friend =2,
firstFriendSpeed = 1,
secondFriendSpeed = 2,
dogSpeed=5;

while(distanse > 10)
{
    if (friend==1)
    {
        double time = distanse/ (dogSpeed-firstFriendSpeed);
        friend = 2;
    }
    else
    {
        double time = distanse/ (dogSpeed+secondFriendSpeed);
        friend = 1;
    }
    distanse = distanse - (secondFriendSpeed - firstFriendSpeed) * time;
    count++;
}
Console.Write("Собака, чуть, не померла. Кругов");
Console.Write(count);
Console.WriteLine("пробежала.");
