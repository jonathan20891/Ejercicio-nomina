using examen.app.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.app.negocio
{
    public interface imprimir
    {

        void imprimirCualquierCuenta(cliente cliente);


        public class coleccionClientes
        {

            private List<app.modelo.cliente> clientes;

            public coleccionClientes() 
            {
              clientes = new List<app.modelo.cliente>();
            
            }

            public void agregarCliente(app.modelo.cliente cliente)
            {
            clientes.Add(cliente);

                ordenarClientes();
            
            }

            public void ordenarClientes()
            {
                clientes.Sort((x, y) => {
                    int resultado = x.nombre.CompareTo(y.nombre);
                    if (resultado == 0)
                    {
                        resultado = x.fechaDeNacimiento.CompareTo(y.fechaDeNacimiento);
                    }
                    return resultado;
                });
            }

            public List<app.modelo.cliente> listarClientes()
            {
              return clientes;
            
            }

        }


    }
}
