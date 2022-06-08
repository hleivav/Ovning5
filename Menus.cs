using garaget;
using System;

namespace garaget
{
    internal class Menus
    {
        private static string? menuChoice;
        private static int noOfVehicles;
       // private static string? parkVehicles; 

        public static void ShowMainMenu()
        {
            
            Console.WriteLine("***************************************");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*                                     *"); 
            Console.WriteLine("*        Välkommen till garaget!      *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("*                                     *");
            Console.WriteLine("***************************************");
            Console.WriteLine("Vi börjar med att skapa ett garage. ");
            Console.WriteLine("Hur många fordon ska garaget innehålla?");
            try
            {
                 noOfVehicles = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Du måste välja antalet fordon som garaget ska innehålla.");
                ShowMainMenu(); 
            }
            var garage = new Garage<Vehicle>((noOfVehicles));//---Häääääääääääääääääääääääääääääääär
            
            
            Console.WriteLine("Ska vi lägga till några fordon till garaget? (J/N");
            string? parkVehicles = Console.ReadLine();
            switch (parkVehicles.ToUpper())
            {
                case "J":
                    // anropa parkeringsmetoden

                    break;
                case "N":
                    Console.WriteLine("Det finns inga bilar på parkeringen.");
                    break; 
                    default:
                    Console.WriteLine("välj 'J' eller 'N'. ");
                    ShowMainMenu(); 
                    break; 
            }
            
            Menus.ShowSubMenu();
        }
        public static void ShowSubMenu()
        {
            
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("P - Parkera fordon");
            Console.WriteLine("T - Ta bort fordon");
            Console.WriteLine("S - Statistik");
            Console.WriteLine("F - Fordonsök");
            Console.WriteLine("A - Avsluta applikation");
            try
            {
                menuChoice = Console.ReadLine();
            }
            catch
            {
                ShowSubMenu(); 
            }
            Console.WriteLine(menuChoice);
            switch (menuChoice.ToUpper())
            {
                case "P": 
                        //anropa parkera
                        
                        break;
                case "T": 
                        //anropa ta bort
                        break;
                case "S":
                        //anropa statistik
                        break;
                case "F":
                        //anropa fordonsök, 
                        break;
                case "A": 
                        Environment.Exit(0);
                        break; 
                    default: Console.WriteLine("Fel val. Försök igen.");
                    ShowSubMenu();  
                    break;

            }
        }
    }
}