using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MTech_Test1.classes
{
    internal class ShoppingCart
    {
		private DateTime fecha_compra = new DateTime();
		private List<Item> items = new List<Item>();
		private double total_compra;

		public ShoppingCart()
		{
		}

		//Función de Agregar Items a la Lista del ShoppingCart
		public void agregarItem(Item item)
		{
			//Se añade instancia de Item a la Lista
			items.Add(item);

			//Se incrementa el Total de Compra
			this.total_compra += (item.precio * item.cantidad);

			/**
			 * .ToString("C", CultureInfo.CurrentCulture) => Formato de Moneda para la Cultura Actual (Mostrar Símbolo de Pesos)
			 */
			Console.WriteLine("==============================");
			Console.WriteLine("Item " + item.nombre + 
				" con Cantidad de " + item.cantidad +
				" y Precio de " + item.precio + " Añadido!");

			Console.WriteLine("CANTIDAD DE ITEMS EN LISTA: " + this.obtenerCantidadItems());
			Console.WriteLine("TOTAL DE COMPRA ACTUAL: " + this.obtenerTotalCompra().ToString("C", CultureInfo.CurrentCulture));
			Console.WriteLine("==============================\n");
		}

		//Función para Comprar Items
		public void comprar()
        {
			//Se asigna la Fecha Actual
			this.fecha_compra = DateTime.Now;

			Console.WriteLine("==============================");
			Console.WriteLine("Ticket de Compra\n");

			Console.WriteLine("Fecha de Compra: " + fecha_compra.ToString() + "\n");

			//Recorremos Items para Imprimir su Información en el Ticket

			/**
			 * .ToString("C", CultureInfo.CurrentCulture) => Formato de Moneda para la Cultura Actual (Mostrar Símbolo de Pesos)
			 */
			items.ForEach(item =>
            {
				Console.WriteLine(
				"Item: " + item.nombre +
				" Cantidad: " + item.cantidad +
				" Precio: " + item.precio.ToString("C", CultureInfo.CurrentCulture) +
				" Total: " + (item.cantidad * item.precio).ToString("C", CultureInfo.CurrentCulture));
			});

			Console.WriteLine("\nTotal de Compra: " + this.obtenerTotalCompra().ToString("C", CultureInfo.CurrentCulture));
			Console.WriteLine("==============================");

			//Termina la Compra, se limpia el Carrito
			this.items.Clear();
        }

		//Función para Obtener Cantidad de Items
		public int obtenerCantidadItems()
        {
			return items.Count;
        }

		//Función para Obtener Total de Compra
		public double obtenerTotalCompra()
		{
			return this.total_compra;
		}
	}
}
