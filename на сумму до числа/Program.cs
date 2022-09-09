// если пользователь вводит число (А) , то нужно найти сумму чисел , стоящих до этого числа
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int sum =0;
int i =1;
while(i<=a)
{
    sum = sum + i;
    
    i++;
}
Console.WriteLine(sum);