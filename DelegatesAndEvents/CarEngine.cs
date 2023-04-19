using System;

class CarEngine
{
    public delegate void EngineStartHandler();

    public delegate void EngineStopHandler();

    public delegate void EngineSpeedHandler(int speed);

    public event  EngineStartHandler? EngineStarted;

    public event EngineStopHandler? EngineStopped;

    public event EngineSpeedHandler? EngineSpeedChanged;

    //private bool isEngineRunning;
    private int currentEngineSpeed;

    public void StartEngine()
    {
        //isEngineRunning = true;
        EngineStarted?.Invoke();

    }

    public void StopEngine()
    {
        //isEngineRunning = false;
        EngineStopped?.Invoke();
    }

    public void SetEngineSpeed(int speed)
    {
        currentEngineSpeed += speed;
        EngineSpeedChanged?.Invoke(currentEngineSpeed);
    }


}