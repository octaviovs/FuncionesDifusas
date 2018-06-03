using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesDifusas.Funciones
{
    public class operaciones
    {
        public operaciones() {
        }

        public List<double> union(List<double> A, List<double> B) {
            List<double> Cadena = new List<double>();
            /*
             cuando se hace una interseccion se evalian los elementos y se selecciona el mayor 
             por ejemplo 
                A=1 2 3 4
                B=3 4 2 3
                = 3 4 3 4

            */
            try
            {
                if (A.Count == B.Count)
                {
                    int aux = 0;
                    foreach (var item in A)
                    {
                        Cadena.Add(
                           ( item>=B[aux])? item:  B[aux]
                            );
                        aux++;
                    }
                }
                else {
                    Cadena.Add(0);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return Cadena;
        }

        public List<double> interseccion(List<double> A, List<double> B)
        {
            List<double> Cadena = new List<double>();
            /*
             cuando se hace una interseccion se evalian los elementos y se selecciona el mayor 
             por ejemplo 
                A=1 2 3 4
                B=3 4 2 3
                = 3 4 3 4

            */
            try
            {
                if (A.Count == B.Count)
                {
                    int aux = 0;
                    foreach (var item in A)
                    {
                        Cadena.Add(
                           (item >= B[aux]) ? B[aux] : item
                            );
                        aux++;
                    }
                }
                else
                {
                    Cadena.Add(0);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return Cadena;
        }

        public List<double> complemento(List<double> x)
        {
            List<double> Cadena = new List<double>();
            foreach (var item in x)
            {
                if (item == 0)
                {
                    Cadena.Add(1);
                }
                else if (item == 1)
                {
                    Cadena.Add(0);
                }
                else {
                    Cadena.Add(1-item);
                }
            }

            return Cadena;
        }
    }
}
