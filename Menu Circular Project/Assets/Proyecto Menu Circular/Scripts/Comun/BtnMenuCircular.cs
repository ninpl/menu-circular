//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// BtnMenuCircular.cs (13/06/2017)												\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Control del boton del menu circular							\\
// Fecha Mod:		13/06/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace MoonAntonio.UI
{
	/// <summary>
	/// <para>Control del boton del menu circular</para>
	/// </summary>
	[AddComponentMenu("Moon Antonio/UI/BtnMenuCircular")]
	public class BtnMenuCircular : MonoBehaviour 
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Circulo del boton.</para>
		/// </summary>
		public Image circulo;								// Circulo del boton
		/// <summary>
		/// <para>Icono del boton.</para>
		/// </summary>
		public Image icono;									// Icono del boton
		/// <summary>
		/// <para>Titulo del boton.</para>
		/// </summary>
		public string titulo;                               // Titulo del boton
		/// <summary>
		/// <para>Menu del boton</para>
		/// </summary>
		public MenuCircular menu;							// Menu del boton
		#endregion
	}
}
