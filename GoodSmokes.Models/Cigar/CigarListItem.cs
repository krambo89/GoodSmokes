using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models
{
    public class CigarListItems
    {
        public int CigarId { get; set; }

        public ICollection<Cigar> CigarName { get; set; }

        public int MakerId { get; set; }

        public int CigarTypeId { get; set; }
    }
}
