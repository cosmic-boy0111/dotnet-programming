using System.Drawing;

namespace csharp_programming
{
    internal class Program09
    {
        public class TrafficLight
        {

            private string CurrentColor {
                get { return CurrentColor; }
                set { CurrentColor = value; } 
            }

            private string[] color = new string[3] { 
                "Red",
                "Yellow",
                "Green"
            };
            public TrafficLight() { 
                CurrentColor = color[0];
            }



        }


        public static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight();
        }
    }
}
