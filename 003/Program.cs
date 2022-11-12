// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number = new Random().Next(-100, 100);
int num = number % 2;

if (num == 0)
{
    Console.WriteLine("Число " + number + " является четным");
    }

else
{
    Console.WriteLine("Число " + number + " является нечетным");
}
