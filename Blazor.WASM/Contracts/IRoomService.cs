using Blazor.WASM.Models;
using System.Collections.Generic;

namespace Blazor.WASM.Contracts
{
    public interface IRoomService
    {
        List<Room> GetRooms();
        Room GetRoomById(int id);
    }
}
