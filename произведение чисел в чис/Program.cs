// Напишите программу , которая принимает на вход число N и выдаёт произведение числе от 1 доN
Console.WriteLine(" Введите число ");
int n = Convert.ToInt32( Console.ReadLine());
int i =1;
int comp = 1;

while(i<=n)
{
    comp= comp*i;
    i++;
}
Console.WriteLine( comp);