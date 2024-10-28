using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoObligatorio
{
    class Cursos
    {
        #region Atributos

        string ide;
        string nombre;
        int duraciondelcurso;
        int precio;

        #endregion

        #region Propiedades

        public string Ide
        {
            get { return ide;}
            set
            {
                if (value.Length > 6)
                {
                    throw new Exception("\nEl IDE no puede contener mas de 6 caracteres.\n");
                }
                ide = value;
            }
        }
        public string Nombre
        {
            //no se si el nombre del curso tiene que ser diferente de "".
            get { return nombre; }
            set { nombre = value; }
        }
        public int Duracioncurso
        {
            get { return duraciondelcurso; }
            set { duraciondelcurso = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        #endregion

        #region Constructor
        public Cursos(string pIde, string pNombre, int pDuracioncurso, int pPrecio)
        {
            Ide = pIde;
            Nombre = pNombre;
            Duracioncurso = pDuracioncurso;
            Precio = pPrecio;

        }
        public Cursos()
        {
            ide = "vacio";
            Nombre = "Vacio";
            Duracioncurso = 0;
            Precio = 0;
        }

        #endregion

        #region Operaciones
        public override string ToString()
        {
            return "\n\nEl IDE es: " + ide + "\nEl nombre del curso es: " + nombre + "\nLa duracion del curso: " + duraciondelcurso +" semanas"+ "\nEl precio total es de: "+"$" + precio;
        }

        #endregion
    }
}
