using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion15
{
    class Program
    {
        static void Main(string[] args)
        {
            //      ClsArrayList clsArrayList = new ClsArrayList();
            //      clsArrayList.capturarDatos();
            //      clsArrayList.mostrarDatos();

            ClsHashMap clsHashMap = new ClsHashMap();
            clsHashMap.AgregarDatos();
            clsHashMap.MostrarDatos();
        }
    }
}
