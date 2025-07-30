namespace Task1_14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeSystem smart = new SmartHomeSystem();

            smart.DeviceStateChanged += (action, deviceType) =>
            {
                if (action == "Дверь открыта" || action == "Свет включен")
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (deviceType == DeviceType.Thermostat)
                    Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {deviceType}: {action}");
                Console.ResetColor();
            };

            smart.TurnOnLight();
            smart.TurnOffLight();
            try
            {

                smart.SetTemperature(20);
                smart.SetTemperature(200);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            smart.LockDoor();
            smart.UnlockDoor();
            smart.LockDoor();
        }
    }
}