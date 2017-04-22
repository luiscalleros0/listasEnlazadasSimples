using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL_DE_INVENTARIO
{
    class Inventario
    {



        private int _contador;
        public int contador { get { return _contador; } }
        Producto inicio;

        public Inventario()
        {
            _contador = 0;
        }

        public void Agregar(Productos p)
        {

            if (primero == null)
            {
                primero == inicio;
            }
            else
            {
                producto tem = inicio;
                while (tem.siguente != null)
                {
                    tem = tem.siguiente;
                }
                tem.siguiente = nuevo;
            }
        }

        public Productos Buscar(int codigo)
        {
            Productos produ = null;

        }
        public void Borrar(int codigo)
        {

        }
        public string Reporte()
        {
            string cad = "";
            producto tem = inicion;
            while (tem != null)
            {
                datso = tem.tostring;
                tem = tem.siguente;
            }
        }

        public void Insertar(Productos p, int posicion)
        {

        }
    }
}
