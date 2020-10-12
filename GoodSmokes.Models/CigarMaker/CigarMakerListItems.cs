﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokes.Models.CigarMaker
{
    public class CigarMakerListItems
    {
        [Display(Name = "Brand ID")]
        public int MakerId { get; set; }

        [Display(Name = "Brand")]
        public string MakerName { get; set; }

        public virtual List<Cigar> Cigars { get; set; }
    }
}
