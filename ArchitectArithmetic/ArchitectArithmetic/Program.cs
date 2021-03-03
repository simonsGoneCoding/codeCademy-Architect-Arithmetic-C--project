using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate Cost - brake down ancient city in Mexico Teotihuacan to circles, triangles and rect.
            /*
            double cityArea = Rect(1500, 2500) + (Circ(375) / 2) + Tri(750, 500);
            cityArea = Math.Round(cityArea, 2);
            double flooringCost = 180;
            double totalCost = Math.Round(cityArea * flooringCost, 2);

            Console.WriteLine($"Total area of ancient city of Teotihuacan is: {cityArea} square meters.\nFlooring cost of one square meter is: {flooringCost} pesos.\nTotal cost of flooring whole city is: {totalCost}"); 
            
            */

            CalculateTotalCost(1800); 

        }

        // Define Methods
        static double Rect(double length, double width)
        {
            double area = length * width;
            return area; 
        }
        
        static double Circ(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area; 
        }

        static double Tri(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }

        static void CalculateTotalCost(double flooringPrice)
        {
            double cityArea = Rect(1500, 2500) + (Circ(375) / 2) + Tri(750, 500);
            cityArea = Math.Round(cityArea, 2);
            double totalCost = Math.Round(cityArea * flooringPrice, 2);

            Console.WriteLine($"Total area of ancient city of Teotihuacan is: {cityArea} square meters.\nFlooring cost of one square meter is: {flooringPrice} pesos.\nTotal cost of flooring whole city is: {totalCost}");
        }



    }
}
