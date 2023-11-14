using examen.app.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace examen.app.negocio
{


    public class ImprimirArchivo
    {
        public void ImprimirCualquierCuenta(cliente cliente)
        {
            string texto = cliente.ToString();
            File.WriteAllText("datos" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt", texto);
        }
    }

}
