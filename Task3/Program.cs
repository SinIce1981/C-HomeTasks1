// Напишите программу, которая на вход принимает число (N > 0),
// а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число больше 0");
int num = Convert.ToInt32(Console.ReadLine());
int min = 0;

while (min <=num-2)
{
    min=min+2;
Console.Write(min + ",");
} 
