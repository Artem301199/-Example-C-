 //напишите программу , котороая выводит массив из 8 элементов , заполненный нулями и единицами 

 
 int[]array=new int[8];
 int it=0;
 while( it < array.Length)
 {
   array[it]=new Random().Next(0,10);
   Console.Write(array[it]);
   it++;
 }