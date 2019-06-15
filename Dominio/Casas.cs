using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Casas
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }


        public override string ToString()//Al requerir un string de la clase cobertura devuelve el nombre
        {
            return Descripcion;
        }
    }
}
