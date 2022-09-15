Console.WriteLine("Мы попали в игру угадай число");
int secret_number = new Random().Next(1, 11);
int attempt = 5;
bool win = false;
while (attempt > 0)
{
    Console.WriteLine("Введите число от 1 до 10");
    int user_number = int.Parse(Console.ReadLine());
    Console.WriteLine(user_number);
    if (user_number > secret_number)
    {
        System.Console.WriteLine("Секретное число меньше");
        attempt--;
    }
    else if (user_number < secret_number)
    {
        System.Console.WriteLine("Секретное число больше");
        attempt--;
    }
    else if (user_number == secret_number)
    {
        System.Console.WriteLine("Мы угадали");
        win = true;
        break;
    }
    System.Console.WriteLine("Попробуй ещ раз, Осталось попыток " + attempt);
}
if (win)
{
    System.Console.WriteLine("Вы победили, увидимся через неделю");
    System.Console.WriteLine("Осталось попыток " + (attempt - 1));
}
else
{
    System.Console.WriteLine("Вы проигралиб секретное число было" + secret_number);
    System.Console.WriteLine("Попробуйте еще раз");
}
