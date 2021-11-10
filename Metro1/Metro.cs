using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Metro
{
    public string city;
    public List<Line> lines;
    public Metro(string city)
    {
        this.city = city;
    }
    public string GetCity()
    {
        return city;
    }
    public void AddLine(string name, string color)
    {
        lines.Add(new Line(name, color));
    }
    public void RemoveLine(string name)
    {
        foreach (Line i in lines)
        {
            if (i.name == name)
                lines.Remove(i);
        }
    }
}