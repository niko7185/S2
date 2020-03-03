using System;
using System.Collections.Generic;
using ShapeEntities;

namespace ShapeManualTest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();
            bool done = false;

            while(!done)
            {

                Console.WriteLine("\n1: Tilføj ny form\t2: Samlet areal for alle former\t3: Samlet omkreds for alle former\n4: Antal oprettede former\t5: Antal oprettede cirkler\t6: Antal oprettede rektangler\n7: Antal oprettede kvadrater");

                char menu = Console.ReadKey(true).KeyChar;
                double counter = 0;

                switch(menu)
                {
                    case '1':

                        while(true)
                        {

                            Console.WriteLine("\n1: Cirkel\t2: Rektangel\t3: Kvadrat");

                            char chosenShape = Console.ReadKey(true).KeyChar;

                            switch(chosenShape)
                            {

                                case '1':

                                    while(true)
                                    {

                                        Console.Write("\nRadius: ");

                                        string stringRadius = Console.ReadLine();
                                        bool isNum = Double.TryParse(stringRadius, out double radius);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }
                                        Console.Write("\nX: ");

                                        string stringX = Console.ReadLine();
                                        isNum = Int32.TryParse(stringX, out int x);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }
                                        Console.Write("\nY: ");

                                        string stringY = Console.ReadLine();
                                        isNum = Int32.TryParse(stringY, out int y);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }

                                        try
                                        {

                                            Shape circle = new Circle(x, y, radius);

                                            Console.WriteLine("\n" + circle.ToString());

                                            shapes.Add(circle);
                                        }
                                        catch(Exception ex)
                                        {

                                            Console.WriteLine("\n" + ex.Message);
                                            continue;
                                        }
                                        break;

                                    }

                                    break;
                                case '2':

                                    while(true)
                                    {

                                        Console.Write("\nLængde: ");

                                        string stringlength = Console.ReadLine();
                                        bool isNum = Double.TryParse(stringlength, out double length);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }
                                        Console.Write("\nBredde: ");

                                        string stringWidth = Console.ReadLine();
                                        isNum = Double.TryParse(stringWidth, out double width);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }
                                        Console.Write("\nX: ");

                                        string stringX = Console.ReadLine();
                                        isNum = Int32.TryParse(stringX, out int x);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }
                                        Console.Write("\nY: ");

                                        string stringY = Console.ReadLine();
                                        isNum = Int32.TryParse(stringY, out int y);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }

                                        try
                                        {

                                            Shape rectangle = new Rectangle(x, y, length, width);

                                            Console.WriteLine("\n" + rectangle.ToString());

                                            shapes.Add(rectangle);
                                        }
                                        catch(Exception ex)
                                        {

                                            Console.WriteLine("\n" + ex.Message);
                                            continue;
                                        }
                                        break;

                                    }

                                    break;
                                case '3':

                                    while(true)
                                    {

                                        Console.Write("\nLængde: ");

                                        string stringlength = Console.ReadLine();
                                        bool isNum = Double.TryParse(stringlength, out double length);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }
                                        Console.Write("\nX: ");

                                        string stringX = Console.ReadLine();
                                        isNum = Int32.TryParse(stringX, out int x);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }
                                        Console.Write("\nY: ");

                                        string stringY = Console.ReadLine();
                                        isNum = Int32.TryParse(stringY, out int y);

                                        if(!isNum)
                                        {

                                            Console.WriteLine("\nFejl. Input var ikke et tal");
                                            continue;
                                        }

                                        try
                                        {

                                            Shape square = new Square(x, y, length);

                                            Console.WriteLine("\n" + square.ToString());

                                            shapes.Add(square);
                                        }
                                        catch(Exception ex)
                                        {

                                            Console.WriteLine("\n" + ex.Message);
                                            continue;
                                        }
                                        break;

                                    }

                                    break;
                                default:
                                    continue;

                            }

                            break;
                        }

                        break;

                    case '2':

                        for(int i = 0; i < shapes.Count; i++)
                        {

                            counter += shapes[i].CalculateArea();
                        }

                        Console.WriteLine("\nAlle formers samlet areal på " + counter);

                        break;

                    case '3':

                        for(int i = 0; i < shapes.Count; i++)
                        {

                            counter += shapes[i].CalculateCircumference();
                        }

                        Console.WriteLine("\nAlle formers samlet omkreds på " + counter);

                        break;
                    case '4':

                        Console.WriteLine("\nAntal oprettede former: " + shapes.Count);

                        break;
                    case '5':

                        for(int i = 0; i < shapes.Count; i++)
                        {

                            if(typeof(Circle).IsInstanceOfType(shapes[i]))
                                counter++;
                        }

                        Console.WriteLine("\nAntal oprettede cirkler: " + counter);

                        break;
                    case '6':

                        for(int i = 0; i < shapes.Count; i++)
                        {

                            if(typeof(Rectangle).IsInstanceOfType(shapes[i]))
                                counter++;
                        }

                        Console.WriteLine("\nAntal oprettede rektangler: " + counter);

                        break;
                    case '7':

                        for(int i = 0; i < shapes.Count; i++)
                        {

                            if(typeof(Square).IsInstanceOfType(shapes[i]))
                                counter++;
                        }

                        Console.WriteLine("\nAntal oprettede kvadrater: " + counter);

                        break;
                }

            }

        }
    }
}
