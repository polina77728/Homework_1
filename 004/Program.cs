// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 1;
int evenNum = num % 2;

if (number < 1)
{
    Console.Write ("ОШИБКА !!!");
}

else
{
    if (evenNum == 0)
    {
        while (num <= number)
        {
            Console.Write(num + " ");
            num+=2;
        }
    }

    else
    {
        num++;
        while (num <= number)
        {
            Console.Write(num + " ");
            num+=2;
        }
    }

}
