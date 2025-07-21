using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_10_1
{
    internal class Building
    {
        protected string _address;
        protected double _area;
        protected int _yearBuilt;
        protected int _buildingAge;


        public int BuildingAge
        {
            get
            {

                _buildingAge = DateTime.Now.Year - _yearBuilt;
                return _buildingAge;

            }
        }


        public Building(string address, double area, int yearBuilt)
        {
            if (area <= 0)
                throw new ArgumentException("Площадь должна быть > 0");

            if (yearBuilt <= 0)
                throw new ArgumentException("Год постройки должен быть > 0");

            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;

        }

        public virtual decimal CalculateTax()
        {
            decimal tax = (decimal)_area * 1000;
            return tax;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"\nЗдание расположено по адресу: {_address}, \nплощадь здания: {_area} м2, \nгод постройки: {_yearBuilt} г., \nвозраст здания: {BuildingAge} л.");
            Console.WriteLine("-------------------");
        }
    }
}
