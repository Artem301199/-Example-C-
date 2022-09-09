// посчитать сумму чисел , стоящих до этого числа 

Console.WriteLine("ВВедите число");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
int sum = 1;
while ( count <= a)
{
    sum = sum + count;
    count++;
}
Console.WriteLine(sum);
