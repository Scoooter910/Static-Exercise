namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(32); 
            var fahrenheit = TempConverter.CelsiusToFahrenheit(9); 

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
