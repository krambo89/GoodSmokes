using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cigar
    {
        [Key]
        public int CigarId { get; set; }

        [Required]
        public string CigarName { get; set; }


        [ForeignKey(nameof(TheMaker))]
        public int MakerId { get; set; }
        public virtual CigarMaker TheMaker { get; set; }

        [ForeignKey(nameof(TheType))]
        public int CigarTypeId { get; set; }
        public virtual CigarType TheType { get; set; }


    }
}
