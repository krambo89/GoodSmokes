using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CigarMaker
    {
        [Key]
        public int MakerId { get; set; }

        public string MakerName { get; set; }

        

    }
}
