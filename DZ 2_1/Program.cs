/*
 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1


Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int Length = number.ToString().Length;
if (Length == 3) {
	int result = ( number/10 ) % 10;
Console.WriteLine(result);
} 
else 
{
Console.WriteLine("не трехзначное число");
}
*/

Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99) 
{
number = ( number/10 ) % 10;
Console.WriteLine(number);
}
else 
{
Console.WriteLine("не трехзначное число");
}