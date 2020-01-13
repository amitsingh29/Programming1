using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class ConvertTemperature
    {
    public void temperature()
        {

            Console.WriteLine("Enter the temperature in Celcius");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Conversion of Celcius to Farenheit");
             double faren= Utility.celToFarenheitConversion(c);
            Console.WriteLine(faren);
            Console.WriteLine("Enter the temperature in Farenheit");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Conversion of Farenheit to Celcius");
            double cel = Utility.farenheitToCelConversion(f);
            Console.WriteLine(cel);
        }
    }

}
