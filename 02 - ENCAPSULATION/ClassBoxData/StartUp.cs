using System;

namespace ClassBoxData
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(lenght, width, height);

                Console.WriteLine($"Surface Area - {box.SurfaceArea():F02}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F02}");
                Console.WriteLine($"Volume - {box.Volume():F02}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


        }
    }
}
