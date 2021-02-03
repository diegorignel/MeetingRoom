using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingRoom.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingRoomController : EfCoreBaseController<Models.MeetingRoom, MeetingRoomRepository>
    {
        public MeetingRoomController(MeetingRoomRepository repository) : base(repository)
        {
        }
    }
}