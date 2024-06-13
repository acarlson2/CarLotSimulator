using System.Collections.Generic;

public class CarLot
{
    public CarLot()
    {
        Lot = new List<Car>();
    }

    public static int numberOfCars;

    public List<Car> Lot {get; set;}
}