using System.Security.Cryptography.X509Certificates;

namespace csharp_programming
{
    internal class Program07
    {
        public class TemperatureSensor
        {
            public delegate void Sensor(double temp);
            public static event Sensor TemperatureChanged;

            public static void ReadTemperature()
            {
                Random r = new Random();
                double rand_temp = r.Next(1, 100);
                TemperatureChanged(rand_temp);
            }

        }

        public class Alarm
        {
            private double threshold;

            public Alarm(double threshold)
            {
                this.threshold = threshold;
            }
            
            public void ActivateAlarm(double temp)
            {
                if(temp >= threshold)
                {
                    Console.WriteLine("Alarm is activated popopp!");
                }
                else
                {
                    this.DeactivateAlarm();
                }
            }
            public void DeactivateAlarm()
            {
                Console.WriteLine("Alarm is deactivated");
            }


            public void Subscribe()
            {
                TemperatureSensor.TemperatureChanged += ActivateAlarm;
            }

            public void Unsubscribe()
            {
                TemperatureSensor.TemperatureChanged += null;
            }

        }

        public static void Main()
        {
            Alarm a = new Alarm(75);
            a.Subscribe();

            for(int i = 0; i < 5;i++)
            {
                TemperatureSensor.ReadTemperature();
            }



        }

    }
}
