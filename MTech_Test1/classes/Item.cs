using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTech_Test1.classes
{
    internal class Item
    {
		public string nombre;
		public int cantidad;
		public double precio;

		public Item(string nombre, int cantidad, double precio)
		{
			this.nombre = nombre;
			this.cantidad = cantidad;
			this.precio = precio;
		}
	}
}
