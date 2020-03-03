using System;
using System.Collections.Generic;
using ShapeEntities;

namespace ShapeManualTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Erklær variabler
            List<Shape> shapes = new List<Shape>();
            bool done = false;

            //Gentag indtil brugeren vil afslutte
            while(!done)
            {

                Console.WriteLine("\n1: Tilføj ny form\t2: Samlet areal for alle former\t3: Samlet omkreds for alle former\n4: Antal oprettede former\t5: Antal oprettede cirkler\t6: Antal oprettede rektangler\n7: Antal oprettede kvadrater\t8: Afslut");

                //Indlæs en tast og vælg valgmulighed ud fra den
                char menu = Console.ReadKey(true).KeyChar;
                double counter = 0;

                switch(menu)
                {
                    case '1':

                        while(true)
                        {

                            Console.WriteLine("\n1: Cirkel\t2: Rektangel\t3: Kvadrat");

                            //Indlæs en tast og vælg valgmulighed ud fra den
                            char chosenShape = Console.ReadKey(true).KeyChar;

                            switch(chosenShape)
                            {

                                case '1':

                                    while(true)
                                    {

                                        Console.Write("\nRadius: ");

                                        //Indlæs indtastede informationer. Udsrkiv fejlbsked og start forfra hvis det indtastede information ikke er et tal
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

                                        //Erklær ny circel object, vis dens information og tilføj den til listen.
                                        try
                                        {

                                            Shape circle = new Circle(x, y, radius);

                                            Console.WriteLine("\n" + circle.ToString());

                                            shapes.Add(circle);
                                        }
                                        catch(Exception ex)//Hvis de indtastede informationer ikke er gyldige så udskriv en fejlbesked og start forfra
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

                                        //Indlæs indtastede informationer. Udsrkiv fejlbsked og start forfra hvis det indtastede information ikke er et tal
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

                                        //Erklær ny circel rektangel, vis dens information og tilføj den til listen.
                                        try
                                        {

                                            Shape rectangle = new Rectangle(x, y, length, width);

                                            Console.WriteLine("\n" + rectangle.ToString());

                                            shapes.Add(rectangle);
                                        }
                                        catch(Exception ex)//Hvis de indtastede informationer ikke er gyldige så udskriv en fejlbesked og start forfra
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

                                        //Indlæs indtastede informationer. Udsrkiv fejlbsked og start forfra hvis det indtastede information ikke er et tal
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

                                        //Erklær ny kvadrat object, vis dens information og tilføj den til listen.
                                        try
                                        {

                                            Shape square = new Square(x, y, length);

                                            Console.WriteLine("\n" + square.ToString());

                                            shapes.Add(square);
                                        }
                                        catch(Exception ex)//Hvis de indtastede informationer ikke er gyldige så udskriv en fejlbesked og start forfra
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

                        //Læs igennem listen med former og tæl deres areal sammen og udskriv det
                        for(int i = 0; i < shapes.Count; i++)
                        {

                            counter += shapes[i].CalculateArea();
                        }

                        Console.WriteLine("\nAlle formers samlet areal på " + counter);

                        break;

                    case '3':

                        //Læs igennem listen med former og tæl deres omkreds sammen og udskriv det
                        for(int i = 0; i < shapes.Count; i++)
                        {

                            counter += shapes[i].CalculateCircumference();
                        }

                        Console.WriteLine("\nAlle formers samlet omkreds på " + counter);

                        break;
                    case '4':

                        //Udskriv antal af oprettede former
                        Console.WriteLine("\nAntal oprettede former: " + shapes.Count);

                        break;
                    case '5':

                        //Læs igennem listen med former og tæl hvor mange cirkler der er og udskriv det
                        for(int i = 0; i < shapes.Count; i++)
                        {

                            if(typeof(Circle).IsInstanceOfType(shapes[i]))
                                counter++;
                        }

                        Console.WriteLine("\nAntal oprettede cirkler: " + counter);

                        break;
                    case '6':

                        //Læs igennem listen med former og tæl hvor mange rektangler der er og udskriv det
                        for(int i = 0; i < shapes.Count; i++)
                        {

                            if(typeof(Rectangle).IsInstanceOfType(shapes[i]))
                                counter++;
                        }

                        Console.WriteLine("\nAntal oprettede rektangler: " + counter);

                        break;
                    case '7':

                        //Læs igennem listen med former og tæl hvor mange kvadrater der er og udskriv det
                        for(int i = 0; i < shapes.Count; i++)
                        {

                            if(typeof(Square).IsInstanceOfType(shapes[i]))
                                counter++;
                        }

                        Console.WriteLine("\nAntal oprettede kvadrater: " + counter);

                        break;
                    case '8':
                        done = true;

                        break;
                }

            }

        }
    }
}
