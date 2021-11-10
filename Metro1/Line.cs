using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Line
{
	public List<Station> stations;
	public string name;
	public string color;
	public Line(string name, string color)
    {
		this.name = name; this.color = color;
    }
	public Station GetStation(string station)
    {
        foreach (Station i in stations)
        {
            if (i.name == station)
            {
                return i;
            }
        }
        return null;
    }
    public string GetName()
    {
        return name;
    }
    public string GetColor()
    {
        return color;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    public List<Station> GetStationList(string name)
    {
        return stations;
    }
    public void AddStation(string name, string color)
    {
        stations.Add(new Station(name, color));
    }
    public void AddStation(string name, string color, List<Station> transfers)
    {
        stations.Add(new Station(name, color, transfers));
    }
    public void RemoveStation(string name)
    {
        stations.Remove(new Station(name, color));
    }
    public Station FindStationByName(string name)
    {
        foreach(Station i in stations)
        {
            if (i.name == name)
                return i;
        }
        return null;
    }
}
