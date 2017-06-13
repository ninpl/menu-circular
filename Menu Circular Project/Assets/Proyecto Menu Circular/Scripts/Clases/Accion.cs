//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Accion.cs (13/06/2017)														\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Clase de la accion de la interaccion						\\
// Fecha Mod:		13/06/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using System;
#endregion

namespace MoonAntonio.UI
{
	/// <summary>
	/// <para>Clase de la accion de la interaccion</para>
	/// </summary>
	[AddComponentMenu("Moon Antonio/UI/Clases/Accion")]
	public class Accion
	{
		#region Variables Privadas
		/// <summary>
		/// <para>Color de la accion</para>
		/// </summary>
		private Color color;										// Color de la accion
		/// <summary>
		/// <para>Sprite de la accion</para>
		/// </summary>
		private Sprite sprite;										// Sprite de la accion
		/// <summary>
		/// <para>Titulo de la accion</para>
		/// </summary>
		private string titulo;										// Titulo de la accion
		#endregion

		#region Propiedades
		/// <summary>
		/// <para>Color de la accion.</para>
		/// </summary>
		public Color Color
		{
			get { return color; }
			set { color = value; }
		}
		/// <summary>
		/// <para>Sprite de la accion</para>
		/// </summary>
		public Sprite Sprite
		{
			get { return sprite; }
			set { sprite = value; }
		}
		/// <summary>
		/// <para>Titulo de la accion</para>
		/// </summary>
		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}
		#endregion
	}
}
