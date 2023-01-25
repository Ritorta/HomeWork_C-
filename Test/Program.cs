// THES IS TESTING ROOM!

// // https://www.youtube.com/watch?v=g4nGMWwf7OQ

Console.WriteLine("Enter n:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter m:");
int clouns = Convert.ToInt32(Console.ReadLine());
int [,]arr=new int [rows, clouns];
int []sum=new int [clouns];
Random ran = new Random();

for (int i=0; i<rows; i++)
{
    for(int j=0; j<clouns; j++)
    {
        arr[i, j] = ran.Next(0, 100);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<clouns; i++)
{
    for(int j=0; j<rows; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i=0; i<clouns; i++)
{
    Console.Write((sum[i] / rows)  + " ");
}
Console.ReadLine();
