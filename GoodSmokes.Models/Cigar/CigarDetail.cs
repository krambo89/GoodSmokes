using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models
{
    public class CigarDetail
    {
   
        public int CigarId { get; set; }

        [Display(Name = "Name")]
        public string CigarName { get; set; }

        [Display(Name = "Brand ID")]
        public int MakerId { get; set; }

        [Display(Name = "Brand")]
        public string TheMaker { get; set; }
        [Display(Name = "Size ID")]
        public int CigarTypeId { get; set; }

        [Display(Name = "Size")]
        public string TheType { get; set; }
    }
}
