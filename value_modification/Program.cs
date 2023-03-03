using System;


class main
{
    static void Main(string[] args)
    {
        int x = 10;

        int y = 5;

        int z;



        Console.WriteLine($"Before calling ModifyValue: x={x}, y={y}");



        ModifyValues(ref x, y, out z);



        Console.WriteLine($"After calling ModifyValue: x={x}, z={z}");

    }



    public static void ModifyValues(ref int a, in int b, out int c)
    {
        a = a + b;
        c = b - a;
    }


}




