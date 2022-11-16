// Задача 26. - HARD необязательная Напишите программу, 
// которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4
Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
while(num > 0)
{
    num/=10;
     i++;
}
Console.WriteLine("Количество цифр введенного числа : {0}", i);
Console.ReadKey();
return 0;

