// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if (num >= 1 && num <= 7)
    {
        return true;
    }
    System.Console.WriteLine("There is no days of week after 7 or less than 1. \nRestarting.");
    return false;
}

int number=Prompt("Input day of week and i'll say to you if it a weekend day.");
if (Validate(number))
{
    if(number>=6 && number <=7)
    {
        System.Console.WriteLine("Yeah! That is a weekend day!");
    }
    else
    {
        System.Console.WriteLine("No, it just a weekday.");
    }
}