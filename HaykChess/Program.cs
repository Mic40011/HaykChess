

string[,] chess = new string[9, 9];

for (int i = 0; i <= 7; i++)
{
    for (int j = 0; j <= 7; j++)
    {
        chess[0, 0] = "  ";
        ///////////////////////
        chess[0, 1] = " A";
        chess[0, 2] = " B";
        chess[0, 3] = " C";
        chess[0, 4] = " D";
        chess[0, 5] = " E";
        chess[0, 6] = " F";
        chess[0, 7] = " G";
        chess[0, 8] = " H";
      

        chess[1, 0] = " 8";
        chess[2, 0] = " 7";
        chess[3, 0] = " 6";
        chess[4, 0] = " 5";
        chess[5, 0] = " 4";
        chess[6, 0] = " 3";
        chess[7, 0] = " 2";
        chess[8, 0] = " 1";

        chess[i + 1, j + 1] = ("00");


    }
}

for (int i = 0; i <= 8; i++)
{
    for (int j = 0; j <= 8; j++)
    {



        Console.Write($"  {chess[i, j]}");
    }
    Console.WriteLine();
}

Console.ReadLine();
Console.WriteLine("Enter the cordinats where does stay your horse");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
string flag = "right";
for (int i = 1; i <= 8; i++)
{
    for (int j = 1; j <= 8; j++)
    {
        if (a >= 1 && a <= 8 && b >= 1 && b <= 8)
        {
            chess[a, b] = "NN";
        }
        else
        {
            flag = "Note corect";

        }

    }
}
if (string.Equals(flag, "Note corect"))
{
    Console.WriteLine("Note corect");
}
else
{
    for (int i = 0; i <= 8; i++)
    {
        for (int j = 0; j <= 8; j++)
        {



            Console.Write($"  {chess[i, j]}");
        }
        Console.WriteLine();
    }
}