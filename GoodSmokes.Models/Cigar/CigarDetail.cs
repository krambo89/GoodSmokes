using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models
{
    public class CigarDetail
    {
        public int CigarId { get; set; }

        public string CigarName { get; set; }

        public int MakerId { get; set; }

        public string TheMaker { get; set; }
        public int CigarTypeId { get; set; }

        public string TheType { get; set; }
    }
}
