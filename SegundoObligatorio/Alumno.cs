using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoObligatorio
{
    class Alumno
    {
        #region Atributos

        string cedula;
        string nombre;
        string telefono;
        string direccion;
        List<Sistema> listainscipciones=new List<Sistema>();
        #endregion

        #region Propiedades
        public int cant
        {
            get { return listainscipciones.Count; }
        }

        public string Cedula
        {
            get { return cedula; }
            set
            {
                if (value.Length != 7)
                {
                    throw new Exception("La cedula debe contener 7 caracteres.");
                }
                cedula = value; 
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El nombre no puede ser vacio");
                }
                nombre = value;
            }
        }
        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (value.Length < 8 || value.Length > 9)
                {
                    throw new Exception("El numero de telefono debe tener de 8 a 9 digitos.");
                }
                telefono = value;
            }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        #endregion

        #region Constructores

        public Alumno(string pCedula, string pNombre, string pTelefono, string pDireccion)
        {
            Cedula = pCedula;
            Nombre = pNombre;
            Telefono = pTelefono;
            Direccion = pDireccion;
            
           
        }

        public Alumno()
        {
            cedula = "Vacio";
            nombre = "Vacio";
            telefono = "Vacio";
            direccion = "Vacio";
            
        }

        #endregion

        #region Operaciones

        public override string ToString()
        {
            return "\nNombre de alumno: " + nombre + "\nLa cedula es: " + cedula + "\nEl telefono es: " + telefono + "\nSu direccion es: " + direccion;
        }

        public void AgregarInscripcion(Sistema Inscripcion)
        {

            listainscipciones.Add(Inscripcion);
        }

        public int ContarIncripciones(Cursos curso)
        {
            int cont = 0;

            for (int j = 0; j < listainscipciones.Count; j++)
            {
                if (curso.Ide == listainscipciones[j].cursoinscripto.Ide)
                {
                    cont++;
                }
            }

            return cont;
        }

        public void Mostarlista()
        {
            foreach (Sistema item in listainscipciones)
            {
                Console.Write(item.ToString());
            }
        }
        public List<Sistema> Listafuera()
        {
            return listainscipciones;
        }



        #endregion

    }
}
