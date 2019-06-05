using System;

namespace inheritance
{
    public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
    public Vehicle(string mainColor)
    {
        MainColor = mainColor;
    }
    public virtual void Drive () {
        Console.WriteLine("Vrooom!");
    }
}
}