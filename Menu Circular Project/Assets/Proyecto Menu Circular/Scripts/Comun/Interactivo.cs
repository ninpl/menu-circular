//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Interactivo.cs (13/06/2017)													\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Control de la interactividad del objeto						\\
// Fecha Mod:		13/06/2017													\\
// Ultima Mod:		Version Inicial												\\
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
		public Accion[] opciones;// Opciones del menu circular
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Cuando el mouse hace click.</para>
		/// </summary>
		private void OnMouseDown()// Cuando el mouse hace click
		{
			// Abrir menu
			ManagerMenuCircular.instance.AbrirMenu();
		}
		#endregion
	}
}
