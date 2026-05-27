using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Models
{
    public class Operatori
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Roli { get; set; } // "Admin" ose "Operator"
    }
}
