﻿//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// MenuCircular.cs (13/06/2017)													\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Control del Menu Circular									\\
// Fecha Mod:		13/06/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonAntonio.UI
{
	/// <summary>
	/// <para>Control del Menu Circular</para>
	/// </summary>
	[AddComponentMenu("Moon Antonio/UI/MenuCircular")]
	public class MenuCircular : MonoBehaviour 
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Prefab del boton del menu circular.</para>
		/// </summary>
		public BtnMenuCircular btnPrefab;						// Prefab del boton del menu circular
		/// <summary>
		/// <para>Boton seleccionado actualmente.</para>
		/// </summary>
		public BtnMenuCircular seleccionado;                    // Boton seleccionado actualmente
		#endregion

		#region Actualizadores
		/// <summary>
		/// <para>Actualizador de <see cref="MenuCircular"/>.</para>
		/// </summary>
		private void Update()// Actualizador de MenuCircular
		{
			// Si levantamos el dedo del mouse se destuye el menu
			if (Input.GetMouseButtonUp(0)) Destroy(this.gameObject); 
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Inicializador de <see cref="MenuCircular"/></para>
		/// </summary>
		/// <param name="interac">Datos de la interaccion</param>
		public void AbrirBotones(Interactivo interac)// Inicializador de MenuCircular
		{
			// Representamos los botones
			for (int n = 0; n < interac.opciones.Length; n++)
			{
				// Instanciar el boton
				BtnMenuCircular newBtn = Instantiate(btnPrefab) as BtnMenuCircular;

				// Fijar el padre del boton
				newBtn.transform.SetParent(transform, false);

				// Algoritmo de ordenacion circular
				float theta = (2 * Mathf.PI / interac.opciones.Length) * n;
				float xPos = Mathf.Sin(theta);
				float yPos = Mathf.Cos(theta);

				// Asignacion de la posicion del boton
				newBtn.transform.localPosition = new Vector3(xPos, yPos, 0.0f) * 100.0f;
			}
		}
		#endregion
	}
}
