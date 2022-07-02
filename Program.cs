/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*Console.WriteLine("Введите число");
string number = Console.ReadLine();

if (number.Length-1 >= 2)
{
    Console.WriteLine ($"Третья цифра {number [2]}"); 
}

else
{
    Console.WriteLine ("Третьй цифры нет"); 
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье", };
if (day-1 == week.Length-1 || day-1 == week.Length-2)
{
    Console.WriteLine ($"Да, {week [day-1]} это выходной");   
}
else if (day-1 < week.Length-2)
{
    Console.WriteLine ($"Нет, {week [day-1]} это рабочий день"); 
}
else 
{
    Console.WriteLine ("Такого дня недели нет");  
}

