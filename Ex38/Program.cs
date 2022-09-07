int[] array = new int[4];
int y=0;
int max =-1;
int min =100;
while(y<4)
{
    array[y] = new Random().Next(1,100);
    Console.WriteLine(array[y]);
    if(array[y]>max)
    {
        max=array[y];
    }
    else
    {
        if(array[y]<min)
        {
            min=array[y];
        }
    }
    y++;
}
Console.Write("Разность ");
Console.WriteLine(max - min);