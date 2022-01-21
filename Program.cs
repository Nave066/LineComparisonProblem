using System;

namespace LineComparisonProblem
{
    class Program
    {
        public static double distanceBetweenTwoPoints(PointValue point1, PointValue point2)
        {
            double xDifference = Math.Pow((point2.X - point1.X), 2.0);
            double yDifference = Math.Pow((point2.Y - point1.Y), 2.0);
            return Math.Sqrt(xDifference + yDifference);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine( "-------------Line Comparison Problem--------------" );
            Console.WriteLine("Enter the Starting and ending coordinate points of First Line:");
            Console.WriteLine("Starting Coordinate: x value =");
            double FirstLine_startx= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Starting Coordinate: y value =");
            double FirstLine_starty = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ending Coordinate: x value =");
            double FirstLine_endx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ending Coordinate: y value =");
            double FirstLine_endy = Convert.ToDouble(Console.ReadLine());
            PointValue first_point1 = new PointValue(FirstLine_startx,FirstLine_starty);
            PointValue first_point2 = new PointValue(FirstLine_endx, FirstLine_endy);
            Console.WriteLine("The First Line coordinates are ({0},{1}) and ({2},{3})",
                FirstLine_startx,FirstLine_starty,FirstLine_endx,FirstLine_endy);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Enter the Starting and ending coordinate points of Second Line:");
            Console.WriteLine("Starting Coordinate: x value =");
            double SecondLine_startx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Starting Coordinate: y value =");
            double SecondLine_starty = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ending Coordinate: x value =");
            double SecondLine_endx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ending Coordinate: y value =");
            double SecondLine_endy = Convert.ToDouble(Console.ReadLine());
            PointValue second_point1 = new PointValue(SecondLine_startx, SecondLine_starty);
            PointValue second_point2 = new PointValue(SecondLine_endx, SecondLine_endy);
            Console.WriteLine("The Second Line coordinates are ({0},{1}) and ({2},{3})",
                SecondLine_startx, SecondLine_starty, SecondLine_endx, SecondLine_endy);
            Console.WriteLine("---------------------------------------------------------------");

            double FirstLine_distance = distanceBetweenTwoPoints(first_point1,first_point2);
            double SecondLine_distance = distanceBetweenTwoPoints(second_point1, second_point2);
            Console.WriteLine("Expected Distance: 5.385");
            Console.WriteLine("The Answer is" + FirstLine_distance);
            Console.WriteLine("The Answer is" + SecondLine_distance);

            Console.WriteLine("Comparing First and Second Line....");
            Console.WriteLine("-----------------------------------");
            if(FirstLine_distance > SecondLine_distance)
            {
                Console.WriteLine("The FirstLine is Greater in length");
            }
            else if(FirstLine_distance < SecondLine_distance){
                Console.WriteLine("The SecondLine is greater in length");
            }
            else
            {
                Console.WriteLine("Both are Equal");
            }

        }
        
    }
}