using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrate
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Number { get; set; }
            public string Image { get; set; }
        public int Price { get; set; }
        public string Bed { get; set; }
        public string Bath  { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
