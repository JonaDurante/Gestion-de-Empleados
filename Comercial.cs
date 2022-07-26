using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados
{
    public class Comercial : Empleado
    {
        private double comision;
        public double Comision
        {
            get { return comision; }
            set { comision = value > 0? value : 0; }
        }
        public Comercial(string nombre, int edad, int salario, double comision) : base(nombre, edad, salario)
        {
            Comision = comision;
        }
        public override double GetPlus() => (GetEdad() > 20 && comision > 300) ? (GetSalario() + base.GetPlus()) : 0;

    }
}
