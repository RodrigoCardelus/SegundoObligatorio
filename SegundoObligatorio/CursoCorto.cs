using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoObligatorio
{
    class CursoCorto:Cursos
    {
        #region Atributos
        //esta variableva a dar la opcion de programacion economia o diseño
        string opcion;
        #endregion

        #region Propiedades
        public string Opcion
        {
            get { return opcion; }
            set
            {
                if (value != "1" && value != "2" && value != "3")
                {
                    throw new Exception("\n\nLa opcion ingresada no es correcta.(Ingrese una opcion del 1 al 3).\n");
                }
                opcion = value;
            }
        }

        #endregion

        #region Constructores
        public CursoCorto(string pOpcion, string pIDE, string pNombre, int pDuracioncurso, int pPrecio):base(pIDE,pNombre,pDuracioncurso,pPrecio)
        {
            Opcion = pOpcion;
        }
        public CursoCorto()
            : base()
        {
            opcion = "Vacia";
        }

        #endregion

        #region Operaciones
        public override string ToString()
        {
           string resp = base.ToString();
            if (opcion=="1")
                {
                    resp += "\nLa opcion es: Programacion\n";
            }
            if (opcion == "2")
            {
                resp += "\nLa opcion es: Economia\n";
            }
            if (opcion == "3")
            {
                resp += "\nLa opcion es: Diseño\n";
            }
            return resp;
        }
        

        #endregion
    }
}
