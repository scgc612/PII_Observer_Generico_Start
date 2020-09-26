namespace Observer
{
    /// <summary>
    /// Creo un reporter2 para asegurarme que todos los inscriptos en sensor reciben los update
    /// Y creo un StopReporting para verificar que funciona el metodo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {        
            TemperatureSensor sensor = new TemperatureSensor();
            TemperatureReporter reporter = new TemperatureReporter();
            TemperatureReporter reporter2 = new TemperatureReporter();
            reporter.StartReporting(sensor);
            reporter2.StartReporting(sensor);
            sensor.GetTemperature();
            reporter2.StopReporting();
            sensor.GetTemperature();
        }
    }
}