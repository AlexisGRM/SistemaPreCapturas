using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Atributos
    {
        public string nombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public DateTime fechaNac { get; set; }
        public string rfc { get; set; }
        public int lugarNac { get; set; }
        public byte nacion { get; set; }
        public string calle { get; set; }
        public string numExter { get; set; }
        public string numInter { get; set; }
        public string colonia { get; set; }
        public string cp { get; set; }
        public int ciudad { get; set; }
        public string genero { get; set; }
        public string curp { get; set; }
        public byte idEstatus { get; set; }
        public string usuarioCap { get; set; }
        public string compuCap { get; set; }
        public DateTime fechaCap { get; set; }


        public string idDependencia { get; set; }
        public string idDepartamento { get; set; }
        public int idPartida { get; set; }
        public Int16 ejercicioPartida { get; set; }
        public string unidAdmin { get; set; }
        public Int16 ejercicioUnidad { get; set; }
        //public int idPrestServic { get; set; }
        public int idSolicitante { get; set; }
        public string OC_IDOcupacion { get; set; }
        public decimal importTotal { get; set; }
        public decimal importMnesual { get; set; }
        public DateTime fechaIni { get; set; }
        public DateTime fechaFin { get; set; }
        public Int16 idEstatContratServic { get; set; }
       // public string usuarioCap2 { get; set; }
       // public string compuCap2 { get; set; }
        public string activ { get; set; }
        public string observac { get; set; }
        public byte ST_IDSubtipo { get; set; }

        /*public byte curriculum { get; set; }
        public byte comprobEstu { get; set; }
        public byte cartaNoAnte { get; set; }
        public byte identifi { get; set; }
        public byte cartaNoInhabi { get; set; }
        public byte actaNac { get; set; }
        public byte curp2 { get; set; }
        public byte comprobDOM { get; set; }*/

        

    }
}
