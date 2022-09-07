int[] array=new int[10];
int y=0;
int sum=0;
while(y<10)
{
    array[y]= new Random().Next(0,100);
    Console.WriteLine(array[y]);
    if(y%2!=0)
    {
        sum=sum+array[y];
    }
    y++;
    
}
Console.Write("Сумма элементов на нечётных позициях ");
Console.WriteLine(sum);
