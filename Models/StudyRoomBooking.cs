using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PacktStudyRoom.Models
{
    public class StudyRoomBooking //: StudyRoomBookingBase
    {
        [Key]
        public int BookingId { get; set; }

        public int StudyRoomId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string EMail { get; set; }

        [DataType(DataType.Date)]
        [DateInFuture]
        public DateTime BookingDate { get; set; }

    }

}
