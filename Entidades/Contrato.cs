using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Contrato
    {
        public int Folio { get; set; }
        public string Prestador { get; set; }
        public String UnidadAdministrativa { get; set; }
        public int Partida { get; set; }
        public int Ejercicio { get; set; }
        public string Dependencia { get; set; }
        public string Departamento { get; set; }
        public String Ocupacion { get; set; }
        public decimal ImporteTotal { get; set; }
        public String Estatus { get; set; }

    }
}
