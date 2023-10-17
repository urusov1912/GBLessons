
int firstFriendSpeed = 3;
int secondFriendSpeed = 5;
int distance = 10000;
int dogSpeed = 20,
friend = 2;
int time = 0;
int i = 0;

while (distance > 10)
{
        if (friend == 2)    
            time = distance  % (secondFriendSpeed + dogSpeed);
            friend = 1;       
        if (friend == 1)
        {
            time = distance  % (firstFriendSpeed + dogSpeed);
            friend = 2;
        }
    i++;
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
}
Console.Write($"Собака пробежала {i} раз");


