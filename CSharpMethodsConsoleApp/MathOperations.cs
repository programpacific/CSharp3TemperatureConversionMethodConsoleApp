namespace CSharpMethodsConsoleApp
{
    public class CelciusConversion
    {

        public double Celcius(double fahTemp, double num2 = .556, double num3 = 32)
        {
            return (fahTemp - num3) * num2;
        }
    }

    public class KelvinConversion
    {
        public double Kelvin(double fahTemp, double num2 = 273.15, double num3 = 32, double num4 = .556)
        {
            return (fahTemp - num3) * num4 + num2;
        }
    }

    public class RankineConversion
    {
        public double Rankine(double fahTemp, double num2 = 273.15, double num3 = 9, double num4 = 5, double num5 = 32, double num6 = .556)
        {
            return (((fahTemp - num5) * num6) + num2) * (num3 / num4);
        }
    }
}








