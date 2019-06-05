using System;

namespace inheritance
{
public class Ram : Vehicle {  // Gas powered truck
    public double FuelCapacity { get; set; }
    public Ram(string mainColor) : base(mainColor)
    {
        MainColor= mainColor;
    }
    public override void Drive () {
        Console.WriteLine($"The {MainColor} Ram drives Roooooom!");
    }

}
}