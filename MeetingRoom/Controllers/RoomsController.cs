using MeetingRoom.Models;
using MeetingRoom.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : EfCoreBaseController<Room, RoomRepository>
    {
        public RoomsController(RoomRepository repository) : base(repository)
        {
        }
    }
}
