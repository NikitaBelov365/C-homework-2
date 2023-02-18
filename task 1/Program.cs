// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if(num >= 100 && num < 1000)
    {
        return true;
    }
    System.Console.WriteLine("This number not three-digit mate.");
    return false;
}

int number = Prompt("Input three-digit number");
if(Validate(number))
{
    number = number /10 %10;
    System.Console.WriteLine($"Second digit is the {number}");
}