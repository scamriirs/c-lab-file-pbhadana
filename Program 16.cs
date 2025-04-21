using System;

namespace BoilerMonitoringSystem
{
    // Event arguments to pass alert details
    public class AlertEventArgs : EventArgs
    {
        public string Message { get; }
        public AlertEventArgs(string message) => Message = message;
    }

    // Boiler class with event handling
    public class Boiler
    {
        // Thresholds
        private const int MAX_TEMP = 100;   // Maximum temperature in °C
        private const int MAX_PRESSURE = 200;  // Maximum pressure in PSI
        private const int MAX_WATER_LEVEL = 80; // Maximum water level percentage

        // Event declaration
        public event EventHandler<AlertEventArgs> Alert;

        // Function to check boiler parameters
        public void CheckBoiler(int temp, int pressure, int waterLevel)
        {
            if (temp > MAX_TEMP)
                OnAlert(new AlertEventArgs($"⚠️ Temperature too high! ({temp}°C)"));

            if (pressure > MAX_PRESSURE)
                OnAlert(new AlertEventArgs($"⚠️ Pressure exceeded limit! ({pressure} PSI)"));

            if (waterLevel > MAX_WATER_LEVEL)
                OnAlert(new AlertEventArgs($"⚠️ Water level too high! ({waterLevel}%)"));
        }

        // Event trigger function
        protected virtual void OnAlert(AlertEventArgs e)
        {
            Alert?.Invoke(this, e); // Raise the event
        }
    }

    class Program
    {
        static void Main()
        {
            Boiler boiler = new Boiler();

            // Subscribe to Alert event
            boiler.Alert += (sender, e) => Console.WriteLine(e.Message);

            // Get user input
            Console.Write("Enter Temperature (°C): ");
            int temp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Pressure (PSI): ");
            int pressure = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Water Level (%): ");
            int waterLevel = Convert.ToInt32(Console.ReadLine());

            // Check boiler safety
            boiler.CheckBoiler(temp, pressure, waterLevel);

            Console.WriteLine("Monitoring complete.");
        }
    }
}
