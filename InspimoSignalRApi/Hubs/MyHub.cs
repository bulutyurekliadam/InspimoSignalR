using InspimoSignalRApi.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace InspimoSignalRApi.Hubs
{
    public class MyHub : Hub
    {
        private readonly Context _context;

        public MyHub(Context context)
        {
            _context = context;
        }
        public static List<string> Names { get; set; } = new List<string>();
        public int ClientCount { get; set; } = 0;
        public static int RoomCount { get; set; } = 5; 
         
    }
}
