// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите целое число A: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int y = Convert.ToInt32(Console.ReadLine());
int count = y;
int z = 1;
void DegNumbers(int z) 
{
    for (int i = 0; i <= y-1; i++)
        z = z * x;
    Console.WriteLine($"Число -A- возведенное в натуральную степень -B- ровно: {z}");
}
DegNumbers(z);

