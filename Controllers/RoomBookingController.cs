using Microsoft.AspNetCore.Mvc;
using PacktStudyRoom.Models;
using PacktStudyRoom.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacktStudyRoom.Controllers
{
    public class RoomBookingController : Controller
    {
        private readonly StudyRoomBookingService _studyRoomBookingService;
        public IActionResult Index()
        {
            
            return View(_studyRoomBookingService.GetAllBooking()); 
        }

        public RoomBookingController(StudyRoomBookingService studyRoomBookingService)
        {
            _studyRoomBookingService = studyRoomBookingService;
        }
        public IActionResult Book()
        {

            return View();
        }

        public IActionResult Book(StudyRoomBooking studyRoomBooking)
        {

            return View();
        }

    }
}
