using PacktStudyRoom.Data;
using PacktStudyRoom.Models;
using PacktStudyRoom.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktStudyRoom.Services
{
    public interface IStudyRoomBookingService
    {
        public StudyRoomBookingResult BookStudyRoom(StudyRoomBooking request);
    }

    public class StudyRoomBookingService : IStudyRoomBookingService
    {

        private readonly IStudyRoomRepository _studyRoomRepository;

        private readonly IStudyRoomBookingRepository _studyRoomBookingRepository;

        public StudyRoomBookingService(IStudyRoomBookingRepository studyRoomBookingRepository, IStudyRoomRepository studyRoomRepository)
        {
            _studyRoomBookingRepository = studyRoomBookingRepository;

            _studyRoomRepository = studyRoomRepository;
        }
        public StudyRoomBookingResult BookStudyRoom(StudyRoomBooking request)
        {
            if (request == null)
            {
                throw new ArgumentException(nameof(request));
            }
            StudyRoomBookingResult result = new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                EMail = request.EMail,
                BookingDate = request.BookingDate
            };
            IEnumerable<int> bookedRooms = _studyRoomBookingRepository.GetAll(request.BookingDate).Select(u => u.StudyRoomId);
            IEnumerable<StudyRoom> availableRooms = _studyRoomRepository.GetAll().Where( u => !bookedRooms.Contains(u.Id));
            if (availableRooms.Any())
            {
                StudyRoomBooking studyRoomBooking = result;
                studyRoomBooking.StudyRoomId = availableRooms.FirstOrDefault().Id;
                _studyRoomBookingRepository.Book(studyRoomBooking);
                result.BookingId = studyRoomBooking.BookingId;
                result.Code = StudyRoomBookingCode.Success;

            }
            else
                result.Code = StudyRoomBookingCode.NoRoomAvailable;

            return result;
        }

        public IEnumerable<StudyRoomBooking> GetAllBooking()
        {
            return _studyRoomBookingRepository.GetAll(null);
        }
    }


}
