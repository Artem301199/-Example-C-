//пользователь вводит число и нужно вывести сколько количество цифр в числе 
Console.WriteLine(" Введите число ");
int  N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while ( N >0)
{
   
    count++;
     N= N/10;

}
Console.WriteLine($"в числе {count} цифрa");