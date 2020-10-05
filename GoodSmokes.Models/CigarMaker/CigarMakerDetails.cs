using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models
{
    public class CigarMakerDetails
    {
        public int MakerId { get; set; }
        public string MakerName { get; set; }



        public List<string> TheirCigars { get; set; }


    }
}
