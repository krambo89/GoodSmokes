using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models.CigarMaker
{
    public class CigarMakerListItems
    {
        public int MakerId { get; set; }

        public string MakerName { get; set; }

        public virtual List<Cigar> Cigars { get; set; }
    }
}
