// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int numberA = new Random().Next(-100, 100);
int numberB = new Random().Next(-100, 100);

if (numberA > numberB)
{
    Console.WriteLine("a = " + numberA + ", b = " + numberB);
    Console.WriteLine("max -> " + numberA + ", min -> " + numberB);
}

else if (numberA < numberB)
{
    Console.WriteLine("a = " + numberA + ", b = " + numberB);
    Console.WriteLine("max -> " + numberB + ", min -> " + numberA);
}

else
{
    Console.WriteLine("a = " + numberA + ", b = " + numberB);
    Console.WriteLine("эти два числа равны");
}
