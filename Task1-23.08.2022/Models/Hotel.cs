using System;
using System.Collections.Generic;
using System.Text;
using Task1_23._08._2022.Utilies.Exceptions;

namespace Task1_23._08._2022.Models
{
    class Hotel
    {
        
        private Room[] _rooms;
        public string Name { get; set; }
        public Room this[int index]
        { 
            get 
            {
                if (index < _rooms.Length) return _rooms[index];
                throw new Exception();
            }
            set 
            {
                if (index < _rooms.Length) 
                { 
                    _rooms[index] = value;
                    return;
                }
                throw new Exception();
            } 
        }
        
        public Hotel(string Name, int length)
        {
            this.Name = Name;
            _rooms = new Room[length];
        }
        int cnt=0;
        public void AddRoom(Room room)
        {
            _rooms[cnt]= room;
            cnt++;
        }
        public void Reserve(int? roomId)
        {
            foreach (var item in _rooms)
            {
                if (item.Id == roomId)
                {
                    if (item.IsAvailable == true) 
                    { 
                        item.IsAvailable = false;
                        return; 
                    }
                    throw new NotAvailableException("The Room is not Available");
                }
            }
            throw new NotFoundException("The Room couldn't be found");
            
            
            
        }

    }
}
