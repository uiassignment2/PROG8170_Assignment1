using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment1
{
    class Program
    {
        static Rectangle rectangleObject = new Rectangle();
        static bool keepRunning = true;
        static void Main(string[] args)
        {
            try
            {
                Program prog = new Program();

                int length = prog.GetLengthFromUser();
                rectangleObject.SetLength(length);

                int width = prog.GetWidthFromUser();
                rectangleObject.SetWidth(width);

                do
                {
                    int option = prog.GetMenuOptionFromUser();
                    switch (option)
                    {
                        case 1:
                            length = rectangleObject.GetLength();
                            Console.WriteLine("Rectangle Length is : " + length);

                            break;
                        case 2:
                            length = prog.GetLengthFromUser();
                            rectangleObject.SetLength(length);
                            Console.WriteLine("Rectangle Length set to : " + length);

                            break;
                        case 3:
                            width = rectangleObject.GetWidth();
                            Console.WriteLine("Rectangle Width is : " + width);

                            break;
                        case 4:
                            width = prog.GetWidthFromUser();
                            rectangleObject.SetWidth(width);
                            Console.WriteLine("Rectangle Width set to : " + width);

                            break;
                        case 5:
                            int perimeter = rectangleObject.GetPerimeter();
                            Console.WriteLine("Rectangle perimeter is : " + perimeter);

                            break;
                        case 6:
                            int area = rectangleObject.GetArea();
                            Console.WriteLine("Rectangle area is : " + area);

                            break;
                        case 7:
                            keepRunning = false;

                            break;

                        default:
                            break;
                    }
                }
                while (keepRunning);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                Console.ReadKey();
            }

        }


        private int GetLengthFromUser()
        {
            string response = string.Empty;
            int output = 0;
            do
            {
                Console.Write("Please enter Length of Rectangle : ");
                response = Console.ReadLine();
            } while (!int.TryParse(response, out output) || output <= 0);
            return output;
        }
        private int GetWidthFromUser()
        {
            string response = string.Empty;
            int output = 0;
            do
            {
                Console.Write("Please enter Width of Rectangle : ");
                response = Console.ReadLine();
            } while (!int.TryParse(response, out output) || output <= 0);
            return output;
        }

        private int GetMenuOptionFromUser()
        {
            string response = string.Empty;
            int output = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                Console.WriteLine();
                response = Console.ReadLine();
            } while (!int.TryParse(response, out output) || output <= 0 || output > 7);

            return output;
        }
    }
}
