namespace csharp_programming
{
    enum MeasurementUnit { Inches, Feet, Yards, Miles };

    class Program
    {
        public class MeasurementConverter
        {
            public double Convert( double val , MeasurementUnit input , MeasurementUnit output )
            {

                switch (input)
                {
                    case MeasurementUnit.Inches:
                        {
                            switch (output)
                            {
                                case MeasurementUnit.Feet:
                                    return val * 0.08333333333;
                                case MeasurementUnit.Yards:
                                    return val * 0.02777777778;
                                case MeasurementUnit.Miles:
                                    return val / (double)63360;
                            }
                        }
                        break;
                    case MeasurementUnit.Feet:
                        {
                            switch (output)
                            {
                                case MeasurementUnit.Inches:
                                    return val * 12;
                                case MeasurementUnit.Yards:
                                    return val / (double)3;
                                case MeasurementUnit.Miles:
                                    return val / (double)5280;
                            }
                        }
                        break;
                    case MeasurementUnit.Yards:
                        {
                            switch (output)
                            {
                                case MeasurementUnit.Inches:
                                    return val * 36;
                                case MeasurementUnit.Feet:
                                    return val * 3;
                                case MeasurementUnit.Miles:
                                    return val / (double)1760;
                            }
                        }
                        break;
                    case MeasurementUnit.Miles:
                        {
                            switch (output)
                            {
                                case MeasurementUnit.Inches:
                                    return val * 63360;
                                case MeasurementUnit.Feet:
                                    return val * 5280;
                                case MeasurementUnit.Yards:
                                    return val * 1760;
                            }
                        }
                        break;
                }

                return 0;
            }
        }

        static void Main()
        {
            MeasurementConverter c = new MeasurementConverter();
            c.Convert(12, MeasurementUnit.Inches, MeasurementUnit.Miles);
            
        }
    }
}