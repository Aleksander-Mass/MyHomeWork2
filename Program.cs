/*
Знакомство с языками программирования (семинары)
Урок 2. Массивы и функции в программировании
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
// РЕШЕНИЕ:
Console.Write("Input three-digit integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
void SecondNumber()
{
    if(n > 99 && n < 999)
    {
        Console.WriteLine(n + " -> " +(n / 10) % 10);
    }
    else
    {
        Console.Write("Input three-digit integer number: ");
    }
}
SecondNumber();
*/

/*
Знакомство с языками программирования (семинары)
Урок 2. Массивы и функции в программировании
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
// РЕШЕНИЕ:
Console.Write("Input positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
void ThirdDigit()
{
    if(n > 99)
    {
        //Console.WriteLine(n>99 ? n.ToString()[2] : '-');
        Console.WriteLine(n + " -> " + (n>99 ? n.ToString()[2] : '-'));
    }
    else
    {
        Console.Write(n + " -> " + "There is no third digit");
    }
}
ThirdDigit();
*/

/*
Знакомство с языками программирования (семинары)
Урок 2. Массивы и функции в программировании
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
// РЕШЕНИЕ:
Console.Write("Input positive integer from 1 to 7 number: ");
int n = Convert.ToInt32(Console.ReadLine());
void Weekends()
{
    if(n >= 1 && n <= 7)
        {
            if(n == 6)
                {
                    Console.WriteLine(n + " -> да");
                }
            if(n == 7)
                {
                    Console.WriteLine(n + " -> да");
                }
            if(n >= 1 && n <= 5)
                {
                    Console.WriteLine(n + " -> нет");
                }
        }
    else
        {
            Console.Write("Input positive integer from 1 to 7 number: ");
        }
}
Weekends();
*/
