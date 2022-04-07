using System;

namespace ClockDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            while (true)
            {
                int hours;
                int writtenHours;
                int minutes;

                while (true)
                {
                    Console.WriteLine("Enter analogue hours (0-12): ");
                    hours = int.Parse(Console.ReadLine());
                    writtenHours = hours;
                    if (hours < 0 || hours > 12)
                    {
                        Console.WriteLine("Wrong hours, it must be btween 0 and 12");
                    }
                    else
                    {
                        if (hours == 12)
                        {
                            hours = 0;
                            break;                            
                        }
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter minutes (0-59): ");
                    minutes = int.Parse(Console.ReadLine());
                    if(minutes < 0 || minutes >= 60)
                    {
                        Console.WriteLine("Wrong minutes, it must be btween 0 and 59");
                    }
                    else
                    {
                        break;
                    }
                }
               
                double timeee = (double)writtenHours + (double)minutes/60;               
                Console.WriteLine($"Time is: { TimeSpan.FromHours(timeee)}");

                int hoursDegrees = (hours * 30) + (minutes * 1 / 2);
                int minutesDegrees = (minutes * 6);
                Console.WriteLine();
                int degrees;
                if (minutesDegrees > hoursDegrees)
                {
                    degrees = minutesDegrees - hoursDegrees;
                }
                else
                {
                    degrees = hoursDegrees - minutesDegrees;
                }
                if (degrees > 180)
                {
                    degrees = 360 - degrees;
                }
                Console.WriteLine($"Lesser angle between arrows is: {degrees}");

                Console.WriteLine("Dou you want to repeat? (yes/no)");
                if(Console.ReadLine().ToLower() != "yes")
                {
                    break;
                }  
            }   
        }
    }
}
