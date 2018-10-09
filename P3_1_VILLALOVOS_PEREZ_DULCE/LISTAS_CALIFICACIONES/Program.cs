using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS_CALIFICACIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcion;
            Calificacion calificacionClase = new Calificacion(); 
            /*ESTE OBJETO ME AYUDA A PODER AÑADIR ELEMENTOS DE CAPTURA 
             * EN UNA LISTA EN ESTE CASO CADA QUE CAPTURO EL NOMBRE DE 
             * LA CLASE LO AGREGO A LA LISTA CREADA EN LA CLASE CALIFICACION*/
            Calificacion lista = new Calificacion();
            // Y ESE SE ENCARGA DE CREAR LA LISTA DE LAS CALIFICACIONES 
            Console.Write("\n\t>>CALIFICACIONES<<\n");
            do
            {
                try
                {
                    Console.Write("CLASES : "); // COMIENZO A PEDIRLE AL USUSARIO CUANTAS CLASES DESEA
                    int clases = int.Parse(Console.ReadLine());
                    for (int contar = 1; contar <= clases; contar++)
                    /* DECLARO DENTRO DEL FOR QUE LAS VECES QUE SE CICLE 
                     * DEBEN SER MAYOR O IGUAL AL NUMERO DE CLASES DESEADAS INICIALIZANDO EN 1 */
                    {
                        Console.Write("\tCLASE :  ");
                        string nombreClase = (Console.ReadLine());
                        Console.Write("\tALUMNOS DE CLASES : ");
                        int alumnos = int.Parse(Console.ReadLine());
                        for (int CONTA = 1; CONTA <= alumnos; CONTA++)
                        {
                            Console.Write("\t\t{0} ALUMNO CAL  : ", CONTA);
                            int alCalificacion = int.Parse(Console.ReadLine());
                            lista.Add(alCalificacion);
                            // AÑADE LOS ELEMENTOS INGRESADOS A LISTA              
                        }
                        calificacionClase.Add(nombreClase);
                        /* MANDO A LLAMAR AL METODO Add DESDE 
                         * LA CLASE CREADA ASI TOMA LOS VALORES 
                         * DE nombreClase Y LO AÑADE A LA LISTA */
                    }
                }

                catch (Exception) { Console.Write("\n\a\tERROR "); }
                //IMPRIMO LOS RESULTADO CON AYUDA DE UN FOREACH 
               

                foreach (var add in calificacionClase)
                {
                    Console.Write("\n\t>>CALIFICACIONES DE LOS ALUNMOS<<\n");
                    Console.WriteLine("CLASE : {0}", add);
                        foreach (var Add in lista)
                        {
                            Console.WriteLine("\tCALIFICACIONES : {0}", Add);
                        }
                        Console.WriteLine("\n\tTOTAL DE ALUMNOS : {0} ", lista.Count());
                    }  

                    lista.Remove(lista);
                    Console.ReadKey();
                    Console.Write("\n\a\tREINICIAR (SI /NO) : ");
                    opcion = Console.ReadLine();
                    lista.Clear();
                
            }
            while (opcion == "SI" || opcion == "si" || opcion == "Si");
        
            Console.ReadKey();
        }      
    }
}
