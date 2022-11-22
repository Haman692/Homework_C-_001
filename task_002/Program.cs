// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine ("Напишите число A ");
int numberA = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Напишите число B ");
int numberB = Convert.ToInt32(Console.ReadLine ());
if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше числа {numberB}");
}
else
{
    Console.WriteLine($"Число {numberB} больше числа {numberA}");
}