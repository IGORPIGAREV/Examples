double time = 0, distanse  =1000;
int count = 1,
friend =2,
firstFriendSpeed = 1,
secondFriendSpeed = 2,
dogSpeed=5;

while(distanse > 10)
{
    if (friend==1)
    {
        time = distanse/ (dogSpeed-firstFriendSpeed);
        friend = 2;
    }
    else
    {
        time = distanse/ (dogSpeed+secondFriendSpeed);
        friend = 1;
    }
    distanse = distanse - ((secondFriendSpeed - firstFriendSpeed) *  time);
    count++;
}
Console.Write("Собака, чуть, не померла. Кругов "+count+" проебежала.");
