using System.Text.Json;

namespace GestionDeEmpleados
{
    public class Prograam
    {
        static void Main(string[] args)
        {
            Repartidor oRepartidor = new Repartidor("Jonathan", 38, 1000, "zona 3");

            //var oRepartidorSerializado = JsonSerializer.Serialize(oRepartidor);
            //var oRepartidor1 = (Repartidor)oRepartidor.Clone();
            //var oRepartidor1 = JsonSerializer.Deserialize<Repartidor>(oRepartidorSerializado);

            oRepartidor1.SetNomrbe("Nicolas");
            Comercial oComercial = new Comercial( "Reina",27,2000, 400.00);


            Console.WriteLine("Nombre:" + oRepartidor.GetNombre() + "\n" + "Edad: " + oRepartidor.GetEdad() + "\n" + "Salario: " + oRepartidor.GetSalario() + "\n" + "Zona de Reparto: " + oRepartidor.Zona + "\n" + "Plus: " + oRepartidor.GetPlus());
            Console.WriteLine("*************");           
            
            Console.WriteLine("Nombre:" + oRepartidor1.GetNombre() + "\n" + "Edad: " + oRepartidor1.GetEdad() + "\n" + "Salario: " + oRepartidor1.GetSalario() + "\n" + "Zona de Reparto: " + oRepartidor1.Zona + "\n" + "Plus: " + oRepartidor1.GetPlus());
            
            Console.WriteLine("*************");
            Console.WriteLine("Nombre:" + oComercial.GetNombre() + "\n" + "Edad: " + oComercial.GetEdad() + "\n" + "Salario: "+ oComercial.GetSalario() + "\n" + "Comision: " + oComercial.Comision + "\n" + "Plus: " + oComercial.GetPlus());
            Console.ReadLine();
        }
    }
}
 
