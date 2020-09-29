using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CigarType
    {
        [Key]
        public int CigarTypeId { get; set; }

        public string CigarTypeName { get; set; }

        public ICollection<Cigar> CigarName { get; set; }


    }
}

