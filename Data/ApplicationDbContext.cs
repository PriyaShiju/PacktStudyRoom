using Microsoft.EntityFrameworkCore;
using PacktStudyRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktStudyRoom.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            { }

        //public List<StudyRoom> StudyRooms = new ()
        //{ 
        //    new StudyRoom { Id = 1, RoomName = "Everest", RoomNumber = "AK47" },
        //    new StudyRoom { Id = 2, RoomName = "Google", RoomNumber = "AK72" },
        //    new StudyRoom { Id = 3, RoomName = "Apple", RoomNumber = "AK83" }
        //};

        public DbSet<StudyRoom> StudyRooms { get; set; } 

        public DbSet<StudyRoomBooking> StudyRoomBookings { get; set; }

        


    }
}
