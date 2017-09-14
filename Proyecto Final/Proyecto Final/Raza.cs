using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Raza
    {
        public int Id;
        public string Nombre;
        public string Descripción;
        public int Mejora;

        public Raza ( int id, string nombre, string descripción, int mejora )
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripción = descripción;
            this.Mejora = mejora;

        }
    }
}
