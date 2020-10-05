using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models
{
    public class CigarMakerEdit
    {
        public readonly int MakerId;

        public string MakerName { get; set; }

        public virtual ICollection<Cigar> Cigars { get; set; }
    }
}
