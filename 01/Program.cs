// Используя определение степени числа, напишите цикл, который принимает на вход 
// два натуральных числа (A и B) и возводит число A в степень B.

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Первое число - {A}, второе число - {B}");

double result = Math.Pow(A, B);
Console.WriteLine($"Если возвести число {A} в степень {B}, то получится {result}");
