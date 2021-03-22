using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoafAndStranger.Models
{
    public class Top
    {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }
        public bool Occupied { get; set; }

        //One to many relationship
        public List<Stranger> Strangers { get; set; }
    }
}
