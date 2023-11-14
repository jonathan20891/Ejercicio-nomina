using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.app.modelo
{
    public abstract class cliente
    {
        public string nombre { get; set; }
        public string dni { get; set; }

        public string direccion { get; set; }

        public DateTime fechaDeNacimiento { get; set; }

        public cliente() 
        {

        }

        public cliente (string nombre, string dni, string direccion, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.direccion = direccion;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public abstract double calcularSaldo();


        public override string ToString()
        {
            return $"nombre: {nombre}\nDNI: {dni}\nDireccion: {direccion}\nFecha de nacimiento: {fechaDeNacimiento.ToString("dd/mm/yyyy")}";
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false ;

            cliente other = (cliente)obj ;
            return dni == other.dni ;
        }
    }
}
