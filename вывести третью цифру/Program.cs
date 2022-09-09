Console.WriteLine(" Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
if ( a/100 >0 )
{
    while ( a >= 1000)
    {
        a = a/10;
    }
    Console.WriteLine( a % 10);
}
else 
{
    Console.WriteLine( " Нет третьей цифры ");
}