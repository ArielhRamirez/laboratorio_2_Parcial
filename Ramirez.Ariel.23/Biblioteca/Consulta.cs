using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha 
        { 
            get 
            { 
                return fecha; 
            } 
        }

        public Paciente Paciente 
        {
            get
            {
                return paciente;
            }
        }

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{fecha} se ha atendido a {paciente.NombreCompleto}");
            return sb.ToString();
        }
    }
}
