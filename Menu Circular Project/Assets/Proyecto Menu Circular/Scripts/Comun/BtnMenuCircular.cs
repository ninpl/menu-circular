//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// BtnMenuCircular.cs (13/06/2017)												\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Control del boton del menu circular							\\
// Fecha Mod:		16/06/2017													\\
// Ultima Mod:		Implementada funcionalidad animacion de botones.			\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System;
#endregion

namespace MoonAntonio.UI
{
	/// <summary>
	/// <para>Control del boton del menu circular</para>
	/// </summary>
	[AddComponentMenu("Moon Antonio/UI/BtnMenuCircular")]
	public class BtnMenuCircular : MonoBehaviour , IPointerEnterHandler,IPointerExitHandler
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
		public MenuCircular menu;                           // Menu del boton
		/// <summary>
		/// <para>Velocidad de animacion de los botones.</para>
		/// </summary>
		public float velAnimacion = 0.8f;					// Velocidad de animacion de los botones
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Color base del boton</para>
		/// </summary>
		private Color colorBase;                            // Color base del boton
		#endregion

		#region Actualizadores
		/// <summary>
		/// <para>Inicio de animacion de los botones.</para>
		/// </summary>
		/// <returns></returns>
		private IEnumerator AnimacionBotonesIn()// Inicio de animacion de los botones
		{
			// Asignacion de variables
			transform.localScale = Vector3.zero;
			float timer = 0.0f;

			// Bucle
			while (timer < (1 / velAnimacion))
			{
				// Animacion
				timer += Time.deltaTime;
				transform.localScale = Vector3.one * timer * velAnimacion;
				yield return null;
			}
			// Reseteo
			transform.localScale = Vector3.one;
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>LLama a la animacion de los botones</para>
		/// </summary>
		public void AnimacionON()// LLama a la animacion de los botones
		{
			StartCoroutine(AnimacionBotonesIn());
		}
		#endregion

		#region Eventos
		/// <summary>
		/// <para>Cuando entra en el punto.</para>
		/// </summary>
		/// <param name="eventData">Datos del evento.</param>
		public void OnPointerEnter(PointerEventData eventData)// Cuando entra en el punto
		{
			menu.seleccionado = this;
			colorBase = circulo.color;
			circulo.color = Color.white;
		}

		/// <summary>
		/// <para>Cuando sale el punto.</para>
		/// </summary>
		/// <param name="eventData">Datos del evento.</param>
		public void OnPointerExit(PointerEventData eventData)// Cuando sale el punto
		{
			menu.seleccionado = null;
			circulo.color = colorBase;
		}
		#endregion
	}
}
