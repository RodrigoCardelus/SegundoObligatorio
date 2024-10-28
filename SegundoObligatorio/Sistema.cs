using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoObligatorio
{
    class Sistema
    {
        #region Atributos
        DateTime fechaInscripcion;
        string nombreEmpleado;
        int numeroIdentificatorio;
        static int proximonumeroidentificatorio = 1;
        Cursos Cursoinscripto;
        #endregion

        #region propiedades

        public DateTime Fechainscripcion
        {
            get { return fechaInscripcion; }
            set
            {
                fechaInscripcion = DateTime.Now;
            }
        }

        public string Nombremepleado
        {
            get { return nombreEmpleado; }
            set { nombreEmpleado = value; }
        }
        public int Numeroidentificatorio
        {
            set { numeroIdentificatorio = value; }

        }

        public Cursos cursoinscripto
        {
            get { return Cursoinscripto; }
            set { Cursoinscripto = value; }
        }

        #endregion

        #region Constructores
        public Sistema(string pNombreEmpleado, Cursos pcursoinscripto)
        {
            fechaInscripcion = DateTime.Now;
            Nombremepleado = pNombreEmpleado;
            Cursoinscripto = pcursoinscripto;
            Numeroidentificatorio = proximonumeroidentificatorio;
            proximonumeroidentificatorio++;
        }
        public Sistema()
        {
            fechaInscripcion = DateTime.Now;
            nombreEmpleado = "Vacio.";
            cursoinscripto = new Cursos();
            numeroIdentificatorio = proximonumeroidentificatorio;
            proximonumeroidentificatorio++;
        }

        #endregion

        #region Operaciones
        public override string ToString()
        {
            return "\n\nLa fecha de inscripcion es: " + fechaInscripcion + "\nEl nombre del empleado es: " + nombreEmpleado + "\nEl numero identificatorio es: " + numeroIdentificatorio;
        }

        #endregion

    }
}
