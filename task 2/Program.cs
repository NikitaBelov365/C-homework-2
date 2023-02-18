// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if (num >= 100 || num <= -100)
    {
        return true;
    }
    System.Console.WriteLine("There is no third digit in this number.");
    return false;
}
int thirdDigit = 0;
int number = Prompt("Input number and i'll show to you third digit of it");
if (Validate(number))
{
    if (number >= 100)
    {
        while (number > 1000)
        {
            number /= 10;
        }
        thirdDigit = number % 10;
    }
    else if (number <= -100)
    {
        while (number < -1000)
        {
            number /= 10;
        }
        thirdDigit = -number % 10;
    }
    System.Console.WriteLine($"Third digit is the {thirdDigit}");
}