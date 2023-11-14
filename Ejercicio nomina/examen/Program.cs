using examen.app.modelo;
using examen.app.negocio;
using static examen.app.negocio.imprimir;

namespace examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cuentaAhorro cuentaAhorro = new cuentaAhorro("Juan Pedro", "12345678", "Albarracin,12", 1000, new DateTime(2008, 5, 1));
            cuentaNomina cuentaNomina = new cuentaNomina("Jose Luis", "87654321", "Pio Felipe, 12", 2000, "123-45-6789", "Tajamar", 0.01, new DateTime(2008, 5, 1));
            // Compruebo calculaSaldo
            Console.WriteLine("COMPRUEBO SALDO CUENTA NOMINA");
            cuentaNomina.ingresos = 100;
            cuentaNomina.retiros = 10;
            Console.WriteLine(cuentaNomina.calcularSaldo());
            // FINAL Compruebo calculaSaldo
            // Coleccion Clientes
            coleccionClientes c = new coleccionClientes();
            c.agregarCliente(cuentaAhorro);
            c.agregarCliente(cuentaNomina);
            c.ordenarClientes();
            // Final Coleccion Clientes
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("CLIENTES ORDENADOS");
            // Console.WriteLine(c.ListarClientes().ToString());
            foreach (var cliente in c.listarClientes())
            {
                Console.WriteLine(cliente.ToString());
            }
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("IMPRIMIR");
            imprimir imprimir = new imprimirConsola();
            imprimir.imprimirCualquierCuenta(cuentaAhorro);
            imprimir.imprimirCualquierCuenta(cuentaNomina);
            Console.WriteLine("----------------------------------------");

            /*imprimir = new imprimirArchivo();
            imprimir.ImprimirCualquierCuenta(cuentaAhorro);
            imprimir.ImprimirCualquierCuenta(cuentaNomina);*/
        }
    }
}
    
