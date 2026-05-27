using System;
using System.Collections.Generic;
using System.Text;
namespace Store.Models
{
    public class Shitja
    {
        public int Id { get; set; }
        public int KlientiId { get; set; }
        public string EmriKlientit { get; set; }
        public int ProduktiId { get; set; }
        public string EmriProduktit { get; set; }
        public int Sasia { get; set; }
        public decimal Cmimi { get; set; }
        public decimal Total { get; set; }
        public DateTime Data { get; set; }
    }
}