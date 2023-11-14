using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.app.modelo
{
    public class cuentaAhorro: cliente
    {
        public double saldoAnterior { get; set; }

        public double ingresos { get; set; }

        public double retiros { get; set; }


        public cuentaAhorro() { }

        public cuentaAhorro (string nombre, string dni, string direccion, double saldo, DateTime fechaDeNacimiento): base(nombre,dni,direccion, fechaDeNacimiento) 
        { 
         saldoAnterior = saldo;
        
        }

        public override double calcularSaldo()
        {
            return saldoAnterior + ingresos - retiros;
        }

        public double calcularSaldo(double tasaInteres)
        {
            return (saldoAnterior + tasaInteres) + ingresos - retiros;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSaldo Anterior: {saldoAnterior}\nIngresos: {ingresos}\nRetiros: {retiros}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            cuentaAhorro other = (cuentaAhorro)obj;
            return base.Equals(obj) && saldoAnterior == other.saldoAnterior;
        }


    }
}
