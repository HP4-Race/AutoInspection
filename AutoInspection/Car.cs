using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInspection
{
    internal class Car
    {
        public string carName = "Audi";
        public int baujahr = 1995;
        public int lastInspectionYear = 2010;

        // Konstruktor
        public Car(string newName, int newBaujahr)
        {
            carName = newName;
            baujahr = newBaujahr;
        }

        // Methode
        public void Inspect()
        {
            lastInspectionYear = 2020;
        }
    }
}
