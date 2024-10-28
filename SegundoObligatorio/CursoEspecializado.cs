using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoObligatorio
{
    class CursoEspecializado:Cursos
    {
        #region Atributos
        //esta variable permite poner al usuario el nombre que quiera al curso
        string prerequisitos;
        #endregion

        #region Propiedades
        public string Nombrecurso
        {
            get { return prerequisitos; }
            set 
            {
                if (value == "")
                {
                    throw new Exception("El nombre del curso no puede ser vacio.");
                }
                prerequisitos = value;
            }
        }

        #endregion

        #region constructores
        public CursoEspecializado(string pNombrecurso, string pIDE, string pNombre, int pDuracioncurso, int pPrecio)
            : base(pIDE, pNombre, pDuracioncurso, pPrecio)
        {
            prerequisitos = pNombrecurso;
        }
        public CursoEspecializado()
            : base()
        {
            prerequisitos = "Vacio";
        }
        #endregion

        #region operaciones
        public override string ToString()
        {
            string resp = base.ToString();
            resp += "\nLos prerequisitos del curso son: " + prerequisitos+"\n";
            return resp;
        }
        #endregion
    }
}
