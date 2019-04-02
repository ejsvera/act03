using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act03
{
    class Articulo
    {
        private int id;
        private string nombre;
        private string categoria;
        private int cantidad;
        private string estado;
        private DateTime fecha;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Articulo()
        {
        }

        public Articulo(int ide, string nom, string cat, int can, string est, DateTime fec)
        {
            id = ide;
            nombre = nom;
            categoria = cat;
            cantidad = can;
            estado = est;
            fecha = fec;
        }
    }
}
