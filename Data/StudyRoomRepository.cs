using PacktStudyRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktStudyRoom.Data
{
    public interface IStudyRoomRepository
    {
        public IEnumerable<StudyRoom> GetAll();
    }   

    public class StudyRoomRepository : IStudyRoomRepository
    {
        private readonly ApplicationDbContext _db;

        private IEnumerable<StudyRoom> StudyRooms;

        public StudyRoomRepository(ApplicationDbContext DbContext)
        {
            this._db = DbContext;
        }
        public IEnumerable<StudyRoom> GetAll()
        {
            //Fetches StudyRoom data from the DB to the StudyRooms List;
             
            return _db.StudyRooms.ToList();
        }

    }
}
