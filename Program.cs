using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           Zero fxs = new Zero ("white");
            Tesla modelS = new Tesla ("red");
            Cessna mx410 = new Cessna ("blue");
            Ram ram = new Ram("black"); 

                fxs.Drive();
                modelS.Drive();
                mx410.Drive();
                ram.Drive();
        }
    }
}
