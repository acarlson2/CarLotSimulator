using System.Collections.Generic;

public class CarLot
{
    public CarLot()
    {
        Lot = new List<Car>();
    }

    public List<Car> Lot {get; set;}
}