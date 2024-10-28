using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoObligatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            //Variables
            string opcion = "", cedula = "", nombre = "", telefono = "", direccion = "";
            string IDE = "", bm = "", ntd = "", tipocurso = "", empleado = "";
            int duracioncurso = 0, precio = 0, cont = 0;
            Alumno agre = new Alumno();
            #endregion

            #region Listas
            List<Alumno> listaalumnos = new List<Alumno>();
            List<Cursos> listacursos = new List<Cursos>();
            #endregion

            while (opcion != "0")
            {
                #region Menú
                Console.Clear();
                Console.Write("Integrantes: Rodrigo Cardelus 5217658-2, Leandro Reyes 5016595-3 ");
                Console.WriteLine("\n\n\t\t * * Gestión de cursos * *\n\n");
                Console.WriteLine("\t1- Mantenimiento de Alumnos");
                Console.WriteLine("\t2- Agregar Curso corto");
                Console.WriteLine("\t3- Agregar Curso especializacion");
                Console.WriteLine("\t4- Inscripcion a los cursos");
                Console.WriteLine("\t5- Listado de cursos");
                Console.WriteLine("\t6- Listado de inscripciones");
                Console.WriteLine("\t0- Salir.");
                Console.Write("\n\tIngrese la opción deseada: ");
                opcion = Console.ReadLine();
                #endregion Menú

                switch (opcion)
                {
                    #region Case 1: Mantenimiento de Alumnos
                    case "1":
                        try
                        {

                            Console.Clear();
                            Console.Write("\n\n\t * * Mantenimiento de Alumnos * * \n\n");
                            Console.Write("Cedula sin digito verificador:");
                            cedula = Console.ReadLine().Trim().ToUpper();
                            Alumno al = Buscar(listaalumnos, cedula);
                            if (al == null)
                            {
                                // alta
                                Console.WriteLine("El alumno no existe lo damos de alta---");
                                Console.Write("Nombre :");
                                nombre = Console.ReadLine().Trim().ToUpper();
                                Console.Write("Telefono :");
                                telefono = Console.ReadLine().Trim();
                                Console.Write("Direccion :");
                                direccion = Console.ReadLine().Trim().ToUpper();
                                Alumno a = new Alumno(cedula, nombre, telefono, direccion);
                                listaalumnos.Add(a);
                                Console.Write("\nSe agrego el alumno: "+a.Nombre+" correctamente al sistema.\n\n");

                            }
                            else
                            {
                                Console.Clear();
                                Console.Write("El alumno esta registado en el sistema como:\n");
                                Console.Write(al.ToString()+"\n\n");
                                // Baja o Modificacion
                                Console.WriteLine("\nElija que desea hacer: \n\n1 -Dar de Baja  \n2- Hacer Modificacion\nCualquier otra tecla para salir\n");
                                Console.Write("\nIngrese la opcion deseada: ");
                                bm = Console.ReadLine().Trim().ToUpper();
                                if (bm == "1")
                                {

                                    listaalumnos.Remove(al);
                                    Console.WriteLine("El alumno se dio de baja satisfactoriamente.");

                                }
                                else if (bm == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Nombre :" + al.Nombre);
                                    Console.WriteLine("Telefono :" + al.Telefono);
                                    Console.WriteLine("Direccion :" + al.Direccion);
                                    Console.WriteLine("\n\nSeleccione que desea modificar \n1 -Nombre  \n2 -Telefono  \n3 -Direccion\nCualquier otra tecla para salir\n");
                                    Console.Write("Ingrese la opcion deseada: ");
                                    ntd = Console.ReadLine().Trim().ToUpper();
                                    if (ntd == "1")
                                    {
                                        Console.Write("Nombre :");
                                        nombre = Console.ReadLine().Trim().ToUpper();
                                        Alumno a = new Alumno(al.Cedula, nombre, al.Telefono, al.Direccion);
                                        listaalumnos.Remove(al);
                                        listaalumnos.Add(a);
                                        Console.WriteLine("Se modifico nombre del alumno---");

                                    }
                                    else if (ntd == "2")
                                    {
                                        Console.Write("Telefono :");
                                        telefono = Console.ReadLine().Trim().ToUpper();
                                        Alumno a = new Alumno(al.Cedula, al.Nombre, telefono, al.Direccion);
                                        listaalumnos.Remove(al);
                                        listaalumnos.Add(a);
                                        Console.WriteLine("Se modifico telefono del alumno---");

                                    }
                                    else if (ntd == "3")
                                    {
                                        Console.Write("Direccion :");
                                        direccion = Console.ReadLine().Trim().ToUpper();
                                        Alumno a = new Alumno(al.Cedula, al.Nombre, al.Telefono, direccion);
                                        listaalumnos.Remove(al);
                                        listaalumnos.Add(a);
                                        Console.WriteLine("Se modifico direccion del alumno---");

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nIngrese opcion valida (1,2 o 3)\n\n");
                                    }
                                }
                                else
                                {
                                    Console.Write("\n\nNo ingreso una opcion correcta.(1 o 2)\n\n");

                                }

                            }


                            Console.Write("\nEnter para volver al menú....");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\n\nEl valor ingresado no tiene formato string....\n");
                            Console.Write("Enter para volver al menú....");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\n\n" + ex.Message + "\n");
                            Console.Write("Enter para volver al menú....");
                        }

                        break;
                    #endregion

                    #region Case 2: Agregar Curso corto
                    case "2":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\t * * Agregar Curso corto * *\n\n");
                            Console.Write("IDE :");
                            IDE = Console.ReadLine().Trim();
                            if (BuscarIDE(listacursos, IDE) == null)
                            {
                                Console.WriteLine("Elija una de las opciones:1-Programacion,2-Economia y 3-Diseño");
                                opcion = Console.ReadLine();
                                Console.Write("Nombre del curso: ");
                                nombre = Console.ReadLine().Trim().ToUpper();
                                Console.Write("Duracion del curso(cantidad de semanas): ");
                                duracioncurso = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Precio total del curso corto: ");
                                precio = Convert.ToInt32(Console.ReadLine());
                                Cursos a = new CursoCorto(opcion, IDE, nombre, duracioncurso, precio);
                                listacursos.Add(a);
                                Console.Clear();
                                Console.Write("\nSe agrego el curso correctamente.");
                                Console.Write(a.ToString());
                            }
                            else
                            {
                                Console.Write("No se puede usar ese IDE porque ya esta en uso");
                                Console.Write(BuscarIDE(listacursos, IDE).ToString());
                            }

                            Console.WriteLine("\nEnter para volver al menú....");
                            break;
                        }
                        catch (FormatException)
                        { Console.Write("No ingreso un caratecter de formato numerico."); }
                        catch (Exception ex)
                        { Console.Write(ex.Message); Console.WriteLine("\nEnter para volver al menú...."); }
                        break;
                    #endregion

                    #region Case 3: Agregar Curso especializacion
                    case "3":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\t * * Agregar Curso de especializacion * *\n\n");
                            Console.Write("IDE :");
                            IDE = Console.ReadLine().Trim();
                            if (BuscarIDE(listacursos, IDE) == null)
                            {
                                Console.Write("Ingrese los prerequisitos del curso:");
                                opcion = Console.ReadLine().Trim();
                                Console.Write("Nombre del curso :");
                                nombre = Console.ReadLine().Trim().ToUpper();
                                Console.Write("Duracion del curso(cantidad de semanas): ");
                                duracioncurso = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Precio total del curso especializado :");
                                precio = Convert.ToInt32(Console.ReadLine());
                                Cursos a = new CursoEspecializado(opcion, IDE, nombre, duracioncurso, precio);
                                listacursos.Add(a);
                                Console.Clear();
                                Console.Write("\nSe agrego el curso correctamente.");
                                Console.Write(a.ToString());
                            }
                            else
                            {
                                Console.Write("No se puede usar ese IDE porque ya esta en uso:\n");
                                Console.Write(BuscarIDE(listacursos, IDE).ToString());
                            }

                            Console.WriteLine("\n\nEnter para volver al menú....");
                            break;
                        }
                        catch (FormatException)
                        { Console.Write("No ingreso un caratecter de formato numerico."); }
                        catch (Exception ex)
                        { Console.Write(ex.Message); }
                        break;
                    #endregion

                    #region Case 4: Inscripcion a los cursos
                    case "4":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\t * * Inscripcion a los cursos * *\n\n");
                            Console.Write("Documentos del alumno: ");
                            cedula = Console.ReadLine();
                            Alumno al = new Alumno();
                            al = Buscar(listaalumnos, cedula);
                            if (al != null)
                            {
                                Console.WriteLine();
                                Console.Write(al.ToString());
                                Console.Write("\n\nCursos para inscripcion: \n\n1- Corto \n2- Especializado\n\n");
                                Console.Write("Ingrese la opcion deseada: ");
                                tipocurso = Console.ReadLine();
                                if (tipocurso == "1")
                                {
                                    Console.Clear();
                                    cont = 0;
                                    Console.Write("\nLista de Cursos Cortos Disponibles:");
                                    foreach (Cursos item in listacursos)
                                    {
                                        if (item is CursoCorto)
                                        {
                                            Console.Write(item.ToString());
                                            cont++;
                                        }
                                    }
                                    if (cont == 0)
                                    {
                                        throw new Exception("\n\nNo hay cursos cortos ingresados.\n\nEnter para continuar...");
                                    }

                                }
                                else if (tipocurso == "2")
                                {
                                    Console.Clear();
                                    cont = 0;
                                    Console.Write("\nLista de Cursos Especializados Disponibles:");
                                    foreach (Cursos item in listacursos)
                                    {
                                        if (item is CursoEspecializado)
                                        {
                                            Console.Write(item.ToString());
                                            cont++;
                                        }
                                    }
                                    if (cont == 0)
                                    {
                                        throw new Exception("\n\nNo hay cursos especializados ingresados.\n\nEnter para continuar...");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Ingrese opcion valida (1 o 2).");
                                }

                                Console.Write("\n\nIngrese el IDE del curso que desea inscribirse:");
                                IDE = Console.ReadLine();
                                Cursos cur = new Cursos();
                                cur = BuscarIDE(listacursos, IDE);
                                if (cur != null)
                                {
                                    Console.Write("Ingrese el nombre del empleado: ");
                                    empleado = Console.ReadLine();
                                    Sistema sis = new Sistema(empleado, cur);
                                    agre.AgregarInscripcion(sis);
                                    Console.WriteLine("\nSe inscibio el alumno: " + al.Nombre + " correctamente al sistema.\n");
                                }
                                else
                                {
                                    Console.Write("\n\nNo existe un curso con dicho IDE.\n\n");
                                }
                            }
                            else
                            {
                                Console.Write("\nLa cedula no esta registrada en manteniemiento de alumnos.\n\n");
                            }

                            Console.Write("Enter para volver al menú....");
                            break;
                        }
                        catch (FormatException)
                        { }
                        catch (Exception ex)
                        { Console.Write(ex.Message); }
                        break;
                    #endregion

                    #region Case 5: Listado de cursos
                    case "5":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\t * * Listado de cursos * *\n");
                            int i, j;
                            Cursos auxcurso = new Cursos();
                            for (i = 0; i < listacursos.Count - 1; i++)
                            {
                                for (j = 0; j < listacursos.Count - i - 1; j++)
                                {
                                    if ((listacursos[j + 1].Ide.CompareTo(listacursos[j].Ide) > 0))
                                    {

                                        auxcurso = listacursos[j + 1];
                                        listacursos[j + 1] = listacursos[j];
                                        listacursos[j] = auxcurso;

                                    }
                                }
                            }

                            int cont2 = 0;
                            foreach (Cursos item in listacursos)
                            {
                                Console.Write(item.ToString() + "Numero total de inscripciones al curso: " + agre.ContarIncripciones(item)+"\n-----------------------------------------------------------");
                                cont2++;
                            }
                            if (cont2 == 0)
                            {
                                Console.Write("\nNo hay ningun curso creado.");
                            }
                            Console.Write("\n\nEnter para volver al menú....");
                            break;
                        }
                        catch (FormatException)
                        { }
                        catch (Exception ex)
                        { Console.Write(ex.Message); }
                        break;
                    #endregion

                    #region Case 6: Listado de inscripciones
                    case "6":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\t * * Listado de inscripciones * *\n\n");

                            Console.Write("Ingrese IDE del curso que desea ver inscripciones: ");
                            string IDE1 = Console.ReadLine();
                            cont = 0;
                            if (BuscarIDE(listacursos, IDE1) != null)
                            {
                                
                                foreach (Sistema item in agre.Listafuera())
                                {
                                    if (item.cursoinscripto.Ide == IDE1)
                                    {
                                        Console.Write(item.ToString()+"\n---------------------------------------------------");
                                        cont++;
                                    }
                                }
                                if (cont == 0)
                                {
                                    Console.Write("\nNo hay inscripciones en dicho curso.");
                                }
                            }
                            else
                            {
                                Console.Write("\nNo Hay un curso con dicho IDE");
                            }

                            Console.Write("\n\nEnter para volver al menú....");
                            break;
                        }
                        catch (FormatException)
                        { }
                        catch (Exception ex)
                        { Console.Write(ex.Message); }
                        break;
                    #endregion

                    #region Case 0 y default
                    case "0":
                        Console.Clear();
                        Console.WriteLine("\n\n\tHa finalizado la ejecución del sistema.....");
                        Console.Write("\n\n\tEnter para SALIR.....");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\n\tLa opción ingresada no es válida.....");
                        Console.Write("\n\n\tEnter para CONTINUAR.....");
                        break;
                    #endregion


                }
                Console.ReadLine();
            }
        }

        static Alumno Buscar(List<Alumno> listaV, string cedula)
        {
            foreach (Alumno item in listaV)
            {
                if (item.Cedula == cedula)
                    return item;
            }
            return null;

        }

        static Cursos BuscarIDE(List<Cursos> lista, string IDE)
        {
            foreach (Cursos item in lista)
            {
                if (item.Ide == IDE)
                    return item;
            }
            return null;
        }


    }
}
