using PacktStudyRoom.Data;
using PacktStudyRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktStudyRoom.Services
{
    public interface IStudyRoomService
    {
        public IEnumerable<StudyRoom> GetAll();
    }
    public class StudyRoomService : IStudyRoomService
    {
        
        private readonly IStudyRoomRepository _studyRoomRepository;

        public StudyRoomService(IStudyRoomRepository StudyRoomRepository )
        {
            _studyRoomRepository = StudyRoomRepository;
        }

        public IEnumerable<StudyRoom> GetAll()
        {
            return _studyRoomRepository.GetAll();
        }
    }
}
