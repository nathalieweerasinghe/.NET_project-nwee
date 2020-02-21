using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NWEE.MyAirport.EF
{
    public class Bagage
    { 
        public int BagageID { get; set; }
        [Required(ErrorMessage = "CodeIada is required")]
        public int VolID { get; set; } 
        public Vol vol { get; set; }
        public string CodeIada { get; set; }
        public DateTime DateCreation { get; set; }
        public string Classe { get; set; }
        public bool Prioritaire { get; set; }
        public char STA { get; set; }
        public string SSUR { get; set; }
        public string Destination { get; set; }
        public string Escale { get; set; }


    }
}
