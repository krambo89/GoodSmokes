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


        [ForeignKey(nameof(CigarMaker))]
        public int MakerId { get; set; }
        public virtual CigarMaker CigarMaker { get; set; }

        [ForeignKey(nameof(CigarType))]
        public int CigarTypeId { get; set; }
        public virtual CigarType CigarType { get; set; }


    }
}
