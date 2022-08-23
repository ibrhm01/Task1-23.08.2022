using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_23._08._2022.Models
{
    class Room
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }

        

        public Room(string Name, float Price, int PersonCapacity)
        {
            _id++;
            Id = _id;
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
            IsAvailable = true;
        }
        public string ShowInfo()
        {
            return $"Name: {Name}\nPrice: {Price}\nPersonCapacity: {PersonCapacity}\nIsAvailable: {IsAvailable}\n";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
        
    }
}
