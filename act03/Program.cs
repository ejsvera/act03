using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act03
{
    class Program
    {
        static public List<Articulo> lista = new List<Articulo>();

        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                Console.WriteLine("1. Realizar inventario");
                Console.WriteLine("2. Listar inventario");
                Console.WriteLine("3. Buscar articulo");
                Console.WriteLine("4. Terminar");
                Console.Write("Su opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        ingresar();
                        break;
                    case 2:
                        listar();
                        break;
                    case 3:
                        buscar();
                        break;
                }
            } while (op != 4);
        }

        static void ingresar()
        {
            string opx;
            do
            {
                Console.Write("Id       :");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nombre   :");
                string nom = Console.ReadLine();

                Console.Write("Categoria:");
                string cat = Console.ReadLine();

                Console.Write("Cantidad :");
                int cant = int.Parse(Console.ReadLine());

                Console.Write("Estado   :");
                string est = Console.ReadLine();

                Console.Write("Fecha    :");
                DateTime fec = DateTime.Parse(Console.ReadLine());

                Articulo art = new Articulo();
                art.Id = id;
                art.Nombre = nom;
                art.Categoria = cat;
                art.Cantidad = cant;
                art.Estado = est;
                art.Fecha = fec;
                lista.Add(art);
                Console.WriteLine("Articulos en lista: " + lista.Count);

                Console.Write("¿Continua?(S/N):");
                opx = Console.ReadLine().ToUpper();
            } while (opx.Equals("S"));
        }

        static void listar()
        {
            foreach (Articulo x in lista)
            {
                Console.Write("Articulo :" + x.Id + " / " + x.Nombre + " / " + x.Categoria + " / ");
                Console.WriteLine(x.Cantidad + " / " + x.Estado + " / " + x.Fecha);
            }
        }

        static void buscar()
        {
            Console.Write("Nombre a buscar :");
            string nom = Console.ReadLine();
            foreach (Articulo x in lista)
            {
                if (x.Nombre.Equals(nom))
                {
                    Console.Write("Articulo :" + x.Id + " / " + x.Nombre + " / " + x.Categoria + " / ");
                    Console.WriteLine(x.Cantidad + " / " + x.Estado + " / " + x.Fecha);
                }
            }

        }
    }
}
