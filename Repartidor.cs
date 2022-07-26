using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados
{
    public class Repartidor : Empleado, ICloneable
    {
        private string zona;

        public string Zona
        {
            get { return zona; }
            set { zona = !string.IsNullOrEmpty(zona) ? zona : "zona 1"; }
        }
        public Repartidor(string nombre, int edad, int salario, string zona) : base(nombre, edad, salario)
        {
            this.zona = zona;
        }
        public override double GetPlus() => (GetEdad() < 35 && Zona =="zona 3") ? (base.GetSalario() + base.GetPlus()) : 0;

    }
}
