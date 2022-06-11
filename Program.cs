// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Большее число " + number1);
    Console.WriteLine("Меньшее число " + number2);
}
else
{
    Console.WriteLine("Большее число " + number2);
    Console.WriteLine("Меньшее число " + number1);
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

int MaxNumber = number1;
if (MaxNumber < number2)
{
    MaxNumber = number2;
}
if (MaxNumber < number3)
{
    MaxNumber = number3;
}
Console.WriteLine("Максимальное значение из указанных " + MaxNumber);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine(number + " является чётным числом");
}
else
{
    Console.WriteLine(number + " является нечётным числом");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int firstNumber = 2;
while (firstNumber < numberN)
{
    Console.WriteLine(firstNumber);
    firstNumber = firstNumber + 2;
}
*/