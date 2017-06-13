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
	[Serializable]
	public class Accion
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Color de la accion</para>
		/// </summary>
		public Color color;											// Color de la accion
		/// <summary>
		/// <para>Sprite de la accion</para>
		/// </summary>
		public Sprite sprite;										// Sprite de la accion
		/// <summary>
		/// <para>Titulo de la accion</para>
		/// </summary>
		public string titulo;										// Titulo de la accion
		#endregion
	}
}
