using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoafAndStranger.Models
{
    public class Stranger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int TopId { get; set; }
        public int LoafId { get; set; }

        //one-to-one
        public Loaf Loaf { get; set; }
        //one-to-one
        public Top Top { get; set; }
    }
}
