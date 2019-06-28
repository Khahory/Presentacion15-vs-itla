using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion15
{
    public class ClsArrayList
    {
        ArrayList Lista;

        public ClsArrayList()
        {
            Lista = new ArrayList();
        }

        public void capturarDatos()
        {
            Console.WriteLine("                   Dame los datos");

            //se agregaran la cadena tres veces
            string cadena;
            for (int i = 0; i < 3; i++)
            {
                cadena = Console.ReadLine();
                Lista.Add(cadena);
            }
        }

        //metodo para recorrer la lsita con el for-each
        public void mostrarDatos()
        {
            Console.WriteLine("-------------------------------------------------------");
            //item sera la variable que recorrera por la lista y  coleccion seria como el lugar en donde buscara
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
               
            }
            Console.ReadKey();
        }
    }
}
