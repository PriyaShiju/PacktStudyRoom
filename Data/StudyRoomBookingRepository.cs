using PacktStudyRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktStudyRoom.Data
{
    public interface IStudyRoomBookingRepository
    {
        public void Book(StudyRoomBooking booking);
        public IEnumerable<StudyRoomBooking> GetAll(DateTime? date);
    }
    public class StudyRoomBookingRepository : IStudyRoomBookingRepository
    {
        private readonly ApplicationDbContext _db;

        private IEnumerable<StudyRoomBooking> StudyRoomBookings;

        public IEnumerable<StudyRoomBooking> GetAll(DateTime? date)
        {
            if (date != null)
            {
                StudyRoomBookings = _db.StudyRoomBookings.Where(x => x.BookingDate == date).OrderBy(x => x.BookingDate).ToList(); 
                
            }
            else
                StudyRoomBookings = _db.StudyRoomBookings.OrderBy(x => x.BookingId).ToList();

            return StudyRoomBookings;

        }

        public void Book(StudyRoomBooking booking)
        {
            _db.StudyRoomBookings.Add(booking);
            _db.SaveChanges();
        }

    }
}
