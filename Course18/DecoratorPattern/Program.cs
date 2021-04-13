using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMakeup makeup = new Makeup();
            // Console.WriteLine(makeup.GetMakeup());
            IMakeup illuminator = new IlluminatorDecorator(makeup);
            IMakeup eyeliner = new EyelinerDecorator(illuminator);
            IMakeup mascara = new MascaraDecorator(eyeliner);
            IMakeup lipstick = new LipstickDecorator(mascara);
            Console.WriteLine(lipstick.GetMakeup());

            Console.ReadKey();
        }
    }
}
