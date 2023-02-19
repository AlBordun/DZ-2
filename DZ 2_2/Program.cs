/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Length = number.ToString().Length;

if (Length >= 3){
 while (number > 999)
  number = (number /= 10);
int result = number % 10;
System.Console.WriteLine(result);

} else
{
  Console.WriteLine("Третьего числа нет");
}
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99) {
while (number >= 999)
 number = (number /= 10);
 number = number % 10;
System.Console.WriteLine(number);
}
else
{
  Console.WriteLine("Третьего числа нет");
}