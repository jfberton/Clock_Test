using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Test.Models
{
    internal class Alarma
    {
        public Guid Id { get; set; }
        public string Hora { get; set; }
        public string AM_PM { get; set; }
        public string Descripcion { get; set; }
    }
}
