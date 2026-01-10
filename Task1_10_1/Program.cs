namespace Task1_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Building building = new Building("Ул.Нахимова", 200, 2000);
            building.DisplayInfo();
            Console.WriteLine($"Сумма налога: {building.CalculateTax():N2} рублей\n");

            MultiBuilding building2 = new MultiBuilding("ул.Пушкина", 200000, 1898, 20, true);

            building2.DisplayInfo();
            Console.WriteLine($"Сумма налога: {building2.CalculateTax():N2} рублей");
            Console.WriteLine($"Средняя площадь этажа: {building2.AreaPerFloor} м2");

            //upcasting

            Building building3 = building2;
            building3.DisplayInfo();

            //downcasting

            var building4 = building3 as MultiBuilding;
            if(building4 != null)
            {
                
                building4.DisplayInfo();
                
            }

            Console.WriteLine($"Средняя площадь этажа: {building4.AreaPerFloor} м2");



        }
    }
}