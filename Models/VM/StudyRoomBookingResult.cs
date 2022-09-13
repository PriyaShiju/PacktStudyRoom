using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PacktStudyRoom.Models.VM
{
    public enum StudyRoomBookingCode
    {
        Success,
        NoRoomAvailable
    }

    public class StudyRoomBookingResult : StudyRoomBooking
    {
        public StudyRoomBookingCode Code { get; set; }
    }
}
