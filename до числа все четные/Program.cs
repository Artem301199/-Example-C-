//Напишите программу, которая на вход принимает число (N), а на выходе покConsole.WriteLine(" Введите первое число");
Console.WriteLine(" Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
int c = 1;
while ( c < a)
{
    if ( c %2 == 0)
    {
        Console.WriteLine( c + " ");
    }
    c++;

}