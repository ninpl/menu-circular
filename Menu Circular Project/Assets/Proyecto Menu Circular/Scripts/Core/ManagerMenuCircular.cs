//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// ManagerMenuCircular.cs (13/06/2017)											\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Manager del menu circular									\\
// Fecha Mod:		13/06/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio.UI
{
	/// <summary>
	/// <para>Manager del menu circular	</para>
	/// </summary>
	[AddComponentMenu("Moon Antonio/UI/ManagerMenuCircular")]
	public class ManagerMenuCircular : MonoBehaviour 
	{
		#region Instancia
		/// <summary>
		/// <para>Instancia de <see cref="ManagerMenuCircular"/>.</para>
		/// </summary>
		public static ManagerMenuCircular instance;				// Instancia de ManagerMenuCircular
		#endregion

		#region Variables Publicas
		/// <summary>
		/// <para>Prefab del menu circular.</para>
		/// </summary>
		public MenuCircular menu;								// Prefab del menu circular
		#endregion

		#region Inicializadores
		/// <summary>
		/// <para>Inicializador de <see cref="ManagerMenuCircular"/>.</para>
		/// </summary>
		private void Awake()// Inicializador de ManagerMenuCircular
		{
			// Singleton
			instance = this;
		}
		#endregion
	}
}
