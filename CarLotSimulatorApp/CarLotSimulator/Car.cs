using System;

public class Car
{
    public Car()
    {
        CarLot.numberOfCars++;
    }

    public int Year {get; set;}
    public string Make {get; set;}
    public string Model {get; set;}
    public string EngineNoise {get; set;}
    public string HonkNoise {get; set;}
    public bool IsDriveable {get; set;}

    public void MakeEngineNoise(string noise)
    {
        Console.WriteLine(noise);
    }

    public void MakeHonkNoise(string noise)
    {
        Console.WriteLine(noise);
    }
}