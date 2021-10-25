using Blazor.Contracts;
using Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Services
{
    public class RoomService : IRoomService
    {
        private static List<Room> rooms = new List<Room>();
        public RoomService()
        {
            for (int i = 0; i <= 50; i++)
            {
                rooms.Add(new Room { Id = i, Name = $"Name- {i} ", Price = 100 * i });
            }
        }

        public List<Room> GetRooms()
        {
            return rooms;
        }

        public Room GetRoomById(int id)
        {
            return rooms.FirstOrDefault(r => r.Id == id);
        }


    }
}
