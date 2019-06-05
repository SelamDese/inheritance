using System;

namespace inheritance
{
public class Cessna : Vehicle {  // Propellor light aircraft
    public double FuelCapacity { get; set; }
    public Cessna(string mainColor) : base(mainColor)
    {
        MainColor= mainColor;
    }
    public override void Drive () {
        Console.WriteLine($"The {MainColor} Cessna drives Boooooom!");
    }
}
}