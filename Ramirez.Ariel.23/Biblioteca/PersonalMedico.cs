using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        protected bool FinalizoResidencia 
        { 
            get; 
        }
        internal override string FichaExtra() 
        {
            string finalizoResidencia = FinalizoResidencia ? "SI" : "NO";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Finalizó residencia? {finalizoResidencia}");
            sb.AppendLine("ATENCIONES");

            foreach (Consulta consulta in consultas) 
            {
                sb.AppendLine(consulta.ToString());
            }

            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente) 
        {

            Consulta consulta = new Consulta(DateTime.Now,paciente);
            doctor.consultas.Add(consulta);
            return consulta;
        }

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esRecidente):base(nombre, apellido, nacimiento)
        {
            esResidente = esRecidente;
        }
    }
}
