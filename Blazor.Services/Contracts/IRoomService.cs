using Blazor.Models;
using System.Collections.Generic;

namespace Blazor.Contracts
{
    public interface IRoomService
    {
        List<Room> GetRooms();
        Room GetRoomById(int id);
    }
}
