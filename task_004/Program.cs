// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine ("Напишите число A ");
int numberA = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Напишите число B ");
int numberB = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Напишите число C ");
int numberC = Convert.ToInt32(Console.ReadLine ());
int max = numberA;
if ((numberB < numberC) && (numberA < numberC)) max = numberC;

if ((numberA < numberB) && (numberC < numberB)) max = numberB;
Console.WriteLine($"Максимальное {max}");