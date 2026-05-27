using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Models
{
    public class Produkti
    { 
        public int Id { get; set; }
        public string EmriProduktit { get; set; }
        public int KategoriaId { get; set; }
        public string EmriKategorise { get; set; }
        public int FunitoriId { get; set; }
        public string EmriFurnitorit { get; set; }
        public int Sasia { get; set; }
        public decimal Cmimi { get; set; }
    }
}
