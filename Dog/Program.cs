int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
bool friend2 = true;

int count = 0;

int time = 0;

while (distance > 10)
{
    if(true)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend2 = friend1;
    }
    if(friend1)
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend1 = friend2;
    }
  distance = distance -(firstFriendSpeed + secondFriendSpeed)*time;
  count++;  
}
Console.WriteLine(count);