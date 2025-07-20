using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_10_1
{
    internal sealed class MultiBuilding : Building
    {
        private int _floors;
        private bool _hasElevator;
        private double _areaPerFloor;
        public double AreaPerFloor
        {
            get 
            {
                _areaPerFloor = _area / _floors;
                return _areaPerFloor; 
            }
        }


        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }

        public override decimal CalculateTax()
        {
            decimal tax;
            if (_hasElevator)
            {
                tax = (decimal)_area * 1000m * (1m + (_floors - 1) * 0.05m) + 5000;
            }

            else
            {
                tax = (decimal)_area * 1000m * (1m + (_floors - 1) * 0.05m);
            }



            return tax;
        }

        public override void DisplayInfo()
        {
            string yesNo = _hasElevator ? "да" : "нет";

            base.DisplayInfo();
            Console.Write($"\nколичество этажей: {_floors}, \nналичие лифта: {yesNo}, \nсредняя площадь этажа: {AreaPerFloor} м2");


            Console.WriteLine("-------------------");
           

        }

    }
}
