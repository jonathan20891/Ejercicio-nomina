using examen.app.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.app.negocio
{
    public class imprimirConsola: imprimir
    {
        public void imprimirCualquierCuenta(cliente cliente)
        {
            Console.WriteLine(cliente.ToString());

        }

    }
}
