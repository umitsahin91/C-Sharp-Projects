using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldMeasurement
{
    class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine("Daire (1)");
            Console.WriteLine("Kare (2)");
            Console.WriteLine("Dikdörtgen (3)");
            Console.WriteLine("Üçgen (4)");
            Console.Write("Geometrik şekli seçin :  ");
            string choice = Console.ReadLine();
            SwitchChoice(choice);
        }

        private void SwitchChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    CircleMenu();
                    break;
                case "2":
                    SquareMenu();
                    break;
                case "3":
                    RectangleMenu();
                    break;
                case "4":
                    TriangleMenu();
                    break;
                default:
                    break;
            }
        }

        private void CircleMenu()
        {
            Circle circle = new Circle();
            Console.Write("Lütfen dairenin yarıçapını girin : ");
            circle.Radius = double.Parse(Console.ReadLine());
            circle.CalculateArea();
            circle.CalculatePerimeter();
            Console.WriteLine("Dairenin alanı = " + circle.Area);
            Console.WriteLine("Dairenin çevresi = " + circle.Perimeter);
        }
        private void SquareMenu()
        {
            Square square = new Square();
            Console.Write("Lütfen karenin kenar uzunluğunu girin : ");
            square.Side = double.Parse(Console.ReadLine());
            square.CalculateArea();
            square.CalculatePerimeter();
            Console.WriteLine($"Karenin Alanı : {square.Area}");
            Console.WriteLine($"Karenin Çevresi : {square.Perimeter}");
        }

        private void RectangleMenu()
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("Lütfen dikdörgenin uzun kenar uzunluğunu girin : ");
            rectangle.Width = double.Parse(Console.ReadLine());
            Console.Write("Lütfen dikdörgenin uzun kenar uzunluğunu girin : ");
            rectangle.Height = (double.Parse(Console.ReadLine()));
           
            rectangle.CalculatePerimeter();
            rectangle.CalculateArea();
            Console.WriteLine($"Dikdörtgenin Alanı : {rectangle.Area}");
            Console.WriteLine($"Dikdörtgenin Çevresi : {rectangle.Perimeter}");
        }

        private void TriangleMenu()
        {
            Triangle triangle = new Triangle();
            Console.Write("Üçgenin 1. Kenar Uzunluğunu Girin : ");
            triangle.SideA = double.Parse(Console.ReadLine());
            Console.Write("Üçgenin 2. Kenar Uzunluğunu Girin : ");
            triangle.SideB = double.Parse(Console.ReadLine());
            Console.Write("Üçgenin 3. Kenar Uzunluğunu Girin : ");
            triangle.SideC = double.Parse(Console.ReadLine());       
            triangle.CalculatePerimeter();
            triangle.CalculateArea();
            Console.WriteLine($"Dikdörtgenin Alanı : {triangle.Area}");
            Console.WriteLine($"Dikdörtgenin Çevresi : {triangle.Perimeter}");
        }
    }
}
