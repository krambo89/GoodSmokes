using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models.CigarType
{
    public class CigarTypeListItems
    {
        public int CigarTypeId { get; set; }
        public string CigarTypeName { get; set; }

        public virtual ICollection<Cigar> Cigars { get; set; }
    }
}
