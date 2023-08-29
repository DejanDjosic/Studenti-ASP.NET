using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaIspita.Domain
{
   public class StudentBo
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int GodinaUpisa { get; set; }

        public SmerBo Smer { get; set; }
    }
}
