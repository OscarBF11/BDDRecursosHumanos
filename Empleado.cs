using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDRecursosHumanos
{
    class Empleado
    {
        public int idEmpleado;
        public string Nombre;
        public string Apellidos;
        public DateTime? FechaNac;
        public string Cargo;
        public Nullable<int> RIdDepartamento1;
        public decimal? Salario;

        public Departamento Depto;

        public override string ToString()
        {
            return  (Nombre == null ? "" : Nombre + " ") + 
                    (Apellidos == null ? "" : Apellidos) +
                    (Cargo==null ? "" : " (" + Cargo + ")");
        }

    }
}
