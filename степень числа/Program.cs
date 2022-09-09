//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b =Convert.ToInt32(Console.ReadLine());
int result = 1;
int count = 1 ;
while ( count <= b )
{
    result = result *a ; 
    count ++;
}
Console.WriteLine( result);