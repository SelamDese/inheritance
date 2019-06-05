using System;

namespace inheritance
{
public class Zero : Vehicle {  // Electric motorcycle
    public double BatteryKWh { get; set; }
    public Zero(string mainColor) : base(mainColor)
    {
        MainColor= mainColor;
    }
    public override void Drive () {
        Console.WriteLine($"The {MainColor} Zero drives Zoooooom!");
    }
}
}