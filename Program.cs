/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке 
от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

 int getFromUserData (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);

    return result;
}
int userNumberStart = getFromUserData ("Введите значение начала ряда");
int userNumberFinish = getFromUserData ("Введите значение границы ряда");
int start = Math.Min(userNumberStart,userNumberFinish); // это для того чтобы если пользователь ввел границы не попорядку
int finish = Math.Max(userNumberStart,userNumberFinish);
int range = getSumRange (start,finish);
Console.WriteLine (range);

int getSumRange (int start, int finish)
{
    if (start == finish)
    {
        return start;
    }
    return start + getSumRange(start+1,finish);

}
