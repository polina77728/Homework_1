// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 1;

if (number < 1)
{
    Console.Write ("ОШИБКА !!!");
}

else
{
    while (num <= number)
    {
        Console.Write(num + " ");
        num ++;
    }
}
