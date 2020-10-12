using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models
{
    public class CigarMakerCreate
    {
        [Display(Name = "Brand")]
        public string MakerName { get; set; }

        
    }
}
