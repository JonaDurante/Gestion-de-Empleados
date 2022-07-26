using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados
{
    public abstract class Empleado
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private int salario { get; set; }
        private double plus { get; } = 400;
        public Empleado(string nombre, int edad, int salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }
        public string GetNombre() => nombre;
        public string GetNombre (string ARG) => nombre;
        public void SetNomrbe(string nombre) => this.nombre = !string.IsNullOrEmpty(nombre) ? nombre : "N/N"; 
        public int GetEdad() => edad;
        public void SetEdad(int edad) => this.edad = edad > 0? edad : 0;
        public int GetSalario() => salario;
        public void SetSalario(int salario) => this.salario = salario > 0 ? salario : 0;
        public virtual double GetPlus() => plus;
    }
}
