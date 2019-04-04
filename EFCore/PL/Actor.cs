using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.PL
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public List<ActorMovie> Character { get; set; }
    }
}
