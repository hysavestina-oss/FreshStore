using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Models
{
    public class Klienti
    {
        public int Id { get; set; }
        public string? Emri { get; set; }
        public string? NrTelefoni { get; set; }
        public string? Email { get; set; }
    }
}
