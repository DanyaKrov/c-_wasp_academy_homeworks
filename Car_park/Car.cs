using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public class Car
    {
        public string label;
        public int power, year_of_comeout;
        public Car(string label, int power, int year)
        {
            this.label = label;
            this.power = power;
            this.year_of_comeout = year;
        }
        public class PassengerCar : Car
        {
            public int num_of_pas;
            public Dictionary<string, int> repair_doc;
            public PassengerCar(string label, int power, int year_of_comeout, int num_of_pas) : base(label, power, year_of_comeout)
            {
                this.num_of_pas = num_of_pas;
                repair_doc = new Dictionary<string, int>();

            }
            public int GetYear(string name)
            {
                return repair_doc[name];
            }
            public void GetFullDoc() // печать всей ремонтной книжки
            {
                foreach (string i in repair_doc.Keys)
                {
                    Console.Write($"{i}: {repair_doc[i]}");
                }
            }
            public string TransToString()
            {
                return $"Марка: {label}\nМощность:{power}\nГод производства: {year_of_comeout}\nКоличество пассажиров: {num_of_pas}\n";
            }
            public void AddPage(string name, int year)
            {
                repair_doc.Add(name, year);
            }
            public class Truck : Car
            {
                public int MaxWeight;
                public string FullName;
                Dictionary<string, int> Cargo; //груз
                public Truck(string label, int power, int year_of_comeout, int MaxWeight, string FullName) : base(label, power, year_of_comeout)
                {
                    this.MaxWeight = MaxWeight;
                    this.FullName = FullName;
                    Cargo = new Dictionary<string, int>();
                }
                public void addCargo(string name, int weight)
                {
                    Cargo.Add(name, weight);
                }
                public void removeCargo(string name)
                {
                    try
                    {
                        Cargo.Remove(name);
                    }
                    catch
                    {
                        Console.WriteLine("Да нет такого груза!");
                    }
                }
                public void printCargo()
                {
                    foreach (string i in Cargo.Keys)
                    {
                        Console.Write($"{i}: {Cargo[i]}");
                    }
                }
                public void NewDriver(string FullName)
                {
                    this.FullName = FullName;
                }
                public string TransToString()
                {
                    return $"Марка: {label}\nМощность:{power}\nГрузоподъемность: {MaxWeight}\nФИ водителя: {FullName}\n";
                }
            }
            public class AutoPark
            {
                private string Name_of_park;
                public List<PassengerCar> PasCars;
                public List<Truck> Trucks;

                public AutoPark()
                {
                    PasCars = new List<PassengerCar>();
                    Trucks = new List<Truck>();
                }
                public string TransToString()
                {
                    string ans = "";
                    ans += "Легковые машины: \n";
                    foreach (PassengerCar car in PasCars)
                    {
                        ans += $"{car.TransToString()}\n";
                    }
                    ans += "Грузовые машины: \n";
                    foreach (Truck truck in Trucks)
                    {
                        ans += $"{truck.TransToString()}\n";
                    }
                    return ans;
                }
            }
        }
    }
}
