using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models.CigarType
{
    public class CigarTypeListItems
    {
        [Display(Name = "Size ID")]
        public int CigarTypeId { get; set; }
        [Display(Name = "Size Name")]
        public string CigarTypeName { get; set; }

        public virtual List<Cigar> Cigars { get; set; }
    }
}
