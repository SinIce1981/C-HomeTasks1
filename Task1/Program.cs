// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) 
{
    Console.WriteLine(" Число 1 больше числа 2 ");
}
else
{
    Console.WriteLine(" Число 2 больше числа 1 ");
}