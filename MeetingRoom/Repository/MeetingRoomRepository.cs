using MeetingRoom.Models;
using MeetingRoom.Repository.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoom.Repository
{
    public class MeetingRoomRepository : EfCoreRepository<Models.MeetingRoom, DatabaseContext>
    {
        public MeetingRoomRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
