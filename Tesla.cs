using System;

namespace inheritance
{
public class Tesla : Vehicle {  // Electric car
    public double BatteryKWh { get; set; }
   public Tesla(string mainColor) : base(mainColor)
    {
        MainColor= mainColor;
    }
    public override void Drive () {
        Console.WriteLine($"The {MainColor} Tesla drives Voooooom!");
    }

}
}