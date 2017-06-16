//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Interactivo.cs (13/06/2017)													\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Control de la interactividad del objeto						\\
// Fecha Mod:		16/06/2017													\\
// Ultima Mod:		Visualizacion del titulo									\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System.Collections;
#endregion

namespace MoonAntonio.UI
{
	/// <summary>
	/// <para>Control de la interactividad del objeto</para>
	/// </summary>
	[AddComponentMenu("Moon Antonio/UI/Interactivo")]
	public class Interactivo : MonoBehaviour 
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Opciones del menu circular.</para>
		/// </summary>
		public Accion[] opciones;										// Opciones del menu circular
		/// <summary>
		/// <para>Titulo de la interaccion.</para>
		/// </summary>
		public string titulo;                                           // Titulo de la interaccion
		#endregion

		#region Inicializadores
		/// <summary>
		/// <para>Inicializador de <see cref="Interactivo"/>.</para>
		/// </summary>
		private void Start()// Inicializador de Interactivo
		{
			// Comprobacion y seleccion de titulo
			if (titulo == "" || titulo == null) titulo = gameObject.name;
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Cuando el mouse hace click.</para>
		/// </summary>
		private void OnMouseDown()// Cuando el mouse hace click
		{
			// Abrir menu
			ManagerMenuCircular.instance.AbrirMenu(this);
		}
		#endregion
	}
}
