using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion15
{
   public class ClsHashMap
    {
        Hashtable Tabla;

        //constructor
        public ClsHashMap()
        {
            Tabla = new Hashtable();
        }

        //metodo para agregar datos
        public void AgregarDatos()
        {
            Tabla.Add("001", "Producto 1");
            Tabla.Add("002", "Producto 2");
            Tabla.Add("003", "Producto 3");
            Tabla.Add("004", "Producto 4");
        }

        //metodo para mostrar datos
        public void MostrarDatos()
        {
            Console.WriteLine("Hay {0} elementos, dame la clave del elemento a buscar", Tabla.Count);
            string cadena = Console.ReadLine();

            if (Tabla[cadena] == null)
            {
                Console.WriteLine("El elemento no existe");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(Tabla[cadena]);
                Console.ReadKey();
            }

        }

    }
}
