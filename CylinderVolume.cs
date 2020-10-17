using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var Radius = 3;
        var Height = 3;

        var CylinderVolume = (Math.PI * (Math.Pow(Radius, 2)) * Height);

        Console.WriteLine(CylinderVolume);
    }
}

