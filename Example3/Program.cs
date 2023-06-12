// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);
if (number % 2 == 1)
{
 Console.WriteLine("Число нечетное");  
}
else 
{
    Console.WriteLine("Число четное");
}

