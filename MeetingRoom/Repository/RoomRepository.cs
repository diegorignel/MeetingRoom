using MeetingRoom.Models;
using MeetingRoom.Repository.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoom.Repository
{
    public class RoomRepository : EfCoreRepository<Room, DatabaseContext>
    {
        public RoomRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
