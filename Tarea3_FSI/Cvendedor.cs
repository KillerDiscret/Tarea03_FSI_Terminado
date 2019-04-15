using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_FSI
{
   public class Cvendedor
    {
        private int codigo;
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }

        }
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        private int monto;
        public int Monto
        {
            get
            {
                return monto;
            }
            set
            {
                monto = value;
            }
        }
        //constructor

        public Cvendedor(int acodigo, string anombre, int amonto)
        {
            codigo = acodigo;
            nombre = anombre;
            monto = amonto;
        }
    }
}
