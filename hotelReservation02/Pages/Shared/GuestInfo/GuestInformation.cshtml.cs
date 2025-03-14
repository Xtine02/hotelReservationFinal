using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace hotelReservation02.Pages.Admin
{
    public class GuestInformationModel : PageModel
    {
        public List<GuestInfo> Guests { get; set; } = new List<GuestInfo>();

        public void OnGet()
        {
            // TODO: Replace this with actual data from your database
            Guests = new List<GuestInfo>
            {
                new GuestInfo { RoomNumber = "0001", CustomerName = "John Smith", Mobile = "09123456789", Email = "johnsmith@gmail.com", RoomType = "DELUXE ROOM" },
                new GuestInfo { RoomNumber = "0002", CustomerName = "Jane Doe", Mobile = "09213456789", Email = "janedoe@gmail.com", RoomType = "DELUXE ROOM" }
            };
        }

        public class GuestInfo
        {
            public string RoomNumber { get; set; }
            public string CustomerName { get; set; }
            public string Mobile { get; set; }
            public string Email { get; set; }
            public string RoomType { get; set; }
        }
    }
