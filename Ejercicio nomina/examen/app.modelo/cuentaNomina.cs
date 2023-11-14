using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.app.modelo
{
    internal class cuentaNomina: cuentaAhorro
    {
        public string ss { get; set; }

        public string empresa { get; set; }

        public double comision { get; set; }

        public cuentaNomina() { }


        public cuentaNomina( string nombre, string dni, string direccion,double saldo,string ss, string empresa, double comision, DateTime fechaDeNacmiento):base(nombre,dni,direccion,saldo,fechaDeNacmiento)
        {
            ss = ss;
            empresa = empresa;
            comision = comision;
        }

        public override double calcularSaldo()
        {
           double saldo = base.calcularSaldo();
            double comisiones = retiros * comision;
            return saldo - comisiones;

        }

        public override string ToString()
        {
            return base.ToString() + $"\nSeguridad social {ss}\nEmpresa: {empresa}\nComision: {comision}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            cuentaNomina other = (cuentaNomina)obj;
            return base.Equals(obj) && ss == other.ss && empresa == other.empresa && comision == other.comision;
        }

        }
}
