using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models.CigarType
{
    public class CigarTypeDetails
    {
        public int CigarTypeId { get; set; }
        public string CigarTypeName { get; set; }

        public ICollection<Cigar> CigarName { get; set; }
    }
}
