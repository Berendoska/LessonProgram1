int number = 12;
//string name = "Kate";
//float x = 5.1f;
//bool flag = true;
//double b = 1.2; //больше float
//char type = 'g'; //здесь может быть один символ
//var r = "asdaf";
//cw + tab сразу допишет все. 
System.Console.WriteLine("Месяцев в году " + number + number);
string n = number.ToString();
Console.WriteLine("Введите ваше имяЭ");
string name = Console.ReadLine();
Console.WriteLine("Привет, " + name);
Console.WriteLine("Сколько вам лет?");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Вам " + age + "лет");

if(a > b)
{
    Console.WriteLine("Число а больше числа B");
}
else if(a < b) 
{
    Console.WriteLine("Число B больше числа а");
}
else
{
    Console.WriteLine("Число а, равно числу b");
}
