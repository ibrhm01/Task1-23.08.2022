using System;
using Task1_23._08._2022.Models;
using Task1_23._08._2022.Utilies.Exceptions;

namespace Task1_23._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Room Room0 = new Room("Room0", 200, 7);
            Room Room1 = new Room("Room1", 140, 5);
            Room Room2 = new Room("Room2", 130, 4);
            
           
            Hotel CaspianSea = new Hotel("CaspianSea", 3);
            CaspianSea.AddRoom(Room0);
            CaspianSea.AddRoom(Room1);
            CaspianSea.AddRoom(Room2);
            try
            {
                CaspianSea.Reserve(1);
                //CaspianSea.Reserve(2);
                //CaspianSea.Reserve(3);
                Console.WriteLine(CaspianSea[0]);
                Console.WriteLine(CaspianSea[1]);
                Console.WriteLine(CaspianSea[2]);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            


            
        }
    }
}
