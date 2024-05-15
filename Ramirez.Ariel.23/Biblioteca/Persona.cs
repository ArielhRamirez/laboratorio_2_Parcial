using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public int Edad 
        {
            get 
            {
                return DateTime.Today.AddTicks(- this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto 
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{apellido},{nombre}");
                return sb.ToString();
            }
        }

        internal abstract string FichaExtra();

        public string FichaPersonal(Persona p) 
        {
            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine(NombreCompleto);
            sb2.AppendLine($"EDAD: {Edad}");
            sb2.AppendLine($"{ barrioRecidencia},{nacimiento}");
            return sb2.ToString();
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia):this(nombre, apellido, nacimiento)
        {
            this.barrioRecidencia = barrioRecidencia;
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}