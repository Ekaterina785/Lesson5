int[] array = new int[10];
int y = 0;
int x = 0;
while(y <10)
{
     array[y] = new Random().Next(100, 1000);
     Console.WriteLine(array[y]);
     if(array[y]%2==0)
     {
        x++;
     } 
     y++;
}
Console.WriteLine(x);