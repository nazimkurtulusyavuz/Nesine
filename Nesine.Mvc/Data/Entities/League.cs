using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nesine.Mvc.Data.Entities
{
    public class League
    {
        public int Id { get; set; }
        public List<Match> Matches { get; set; }

    }
}
