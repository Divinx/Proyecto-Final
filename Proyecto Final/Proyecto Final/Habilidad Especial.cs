using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Habilidad_Especial
    {

        public int Id;
        public string Nombre;
        public string Descripción;

        public Habilidad_Especial( int id, string nombre, string descripción)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripción = descripción;

        }
    }

}
