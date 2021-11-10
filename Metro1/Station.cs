using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Station
{
    public string name;
    public string color;
    public Line line;
    public bool isWheelchairAccessible;
    public bool hasParkandRide;
    public bool hasNearbyCableCar;
    public List<Station> transfers;

    public Station(string name, string color)
    {
        this.name = name; this.color = color;
    }
    public Station(string name, string color, List<Station> transfers)
    {
        this.name = name; this.color = color; this.transfers = transfers;
    }
    public string GetName()
    {
        return this.name;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetLineName()
    {
        return line.name;
    }
    public List<Station> GetTransferList()
    {
        return transfers;
    }
    public bool IsWheelchairAccessible()
    {
        return isWheelchairAccessible;
    }
    public bool HasParkAndRide()
    {
        return hasParkandRide;
    }
    public bool HasNearbyCableCar()
    {
        return hasNearbyCableCar;
    }

}
