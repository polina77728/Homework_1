// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);
int numberC = new Random().Next(1, 100);
int max = 0;

if (max < numberA)
{
    max = numberA;


    if (max < numberB)
    {
        max = numberB;
    }

    else if (max < numberC)
    {
        max = numberC;
    }
}
Console.WriteLine("a = " + numberA + ", b = " + numberB + ", c = " + numberC);
Console.WriteLine("max -> " + max);