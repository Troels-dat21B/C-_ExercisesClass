using System;

class Program
{
    static void Main(string[] args)
    {
        CarEngine carEngine = new CarEngine();
        carEngine.EngineStarted += CarEngine_EngineStarted;
        carEngine.EngineStopped += CarEngine_EngineStopped;
        carEngine.EngineSpeedChanged += CarEngine_EngineSpeedChanged;
        carEngine.EngineSpeedChanged += CarEngine_EngineSpeedChanged2;
        carEngine.StartEngine();
        carEngine.SetEngineSpeed(10);
        carEngine.SetEngineSpeed(20);
        carEngine.SetEngineSpeed(30);
        carEngine.StopEngine();
    }

    private static void CarEngine_EngineSpeedChanged(int speed)
    {
        Console.WriteLine($"Engine speed changed to {speed}");
    }
    private static void CarEngine_EngineSpeedChanged2(int speed)
    {
        Console.WriteLine($"Engine speed changed to {speed}");
        TextWriter tw = new StreamWriter("log.txt", true);
        using (tw){
            tw.WriteLine($"Engine speed was changed to {speed}");
        }
    }
    private static void CarEngine_EngineStopped()
    {
        Console.WriteLine("Engine stopped");
    }

    private static void CarEngine_EngineStarted()
    {
        Console.WriteLine("Engine started");
    }

}