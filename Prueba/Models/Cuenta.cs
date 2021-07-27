using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class Cuenta
    {
        public int Numero { get; set; }
        public string  SaldoTotal { get; set; }

        public int CodigoSocio { get; set; }

        public int Estado { get; set; }
    }
}
