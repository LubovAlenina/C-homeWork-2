/*Напишите программу, которая принимает на вход два числа и проверяет, является 
ли одно число квадратом другого. 
5, 25 -> да 
4, 16 -> да 
25, 5 -> да 
8,9 -> нет
*/

void CheckMultiple(int number1, int number2)
{
    if(number2 == number1 * number1)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}
Console.Write("Введите номер 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 < number2)
{
    CheckMultiple(number1, number2);
}
else
{
    CheckMultiple(number2, number1);
}